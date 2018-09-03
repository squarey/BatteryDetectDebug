using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryDetectDebug
{
    public partial class BatteryDetectDebug : Form
    {
        private const Int32 DefaultBaudRate = 9600;
        private const byte CMD_SET_FIRE_STATUS = 0x81;
        private const byte CMD_SET_OPEN_FIRE_TEMPERATURE = 0x82;
        private const byte CMD_SET_SWITCH_SPEED_VAVLE = 0x83;
        private const byte CMD_SET_FORBIDEN_TEMP_FIRE = 0x84;
        private const byte CMD_SET_SPEED_BACK_TIME = 0x85;
        private const byte CMD_SET_TEMP_FIRE_STABLE_TIME = 0x86;

        private const byte CMD_GET_TEMPERATURE = 0x01;
        private const byte CMD_GET_FIRE_STATUS = 0x02;
        private const byte CMD_GET_ADC_REF_VALUE = 0x03;
        private const byte CMD_GET_VERSION = 0x04;
        private const byte CMD_GET_SPEED_BACK_TIME = 0x05;
        private const byte CMD_GET_TEMP_FIRE_STABLE_TIME = 0x06;
        private const byte CMD_GET_OPEN_FIRE_TEMP = 0x07;
        private const byte CMD_GET_SWITCH_SPEED_VAVLE = 0x08;

        private const int DEF_MIN_DATA_LEN = 5;

        private int ReceivedTimes = 0;
        private byte[] SP_RX_Buffer = new byte[512];
        private int SP_ReadBytes = 0;
        private String StringTemperatureValue = "---";
        private String StringTemperatureAD = "";

        private const bool SHOW_TEMP_AD_VALUE = false;
        SynchronizationContext m_SyncContext = null;
        public BatteryDetectDebug()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
            //跨线程更新UI
            if (null == m_SyncContext)
            {
                m_SyncContext = SynchronizationContext.Current;
            }
            String[] ComList = SerialPort.GetPortNames();
            BoxCom.Items.Clear();
            BoxCom.Items.AddRange(ComList);
            Debug.WriteLine("BoxCom.Items.Count:" + BoxCom.Items.Count);
            if(0 != BoxCom.Items.Count)
            {
                BoxCom.SelectedIndex = 0;
            }
            BoxReadList.SelectedIndex = 0;
            BoxSetList.SelectedIndex = 0;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataRecived);
        }
        //设置串口成功接收数据的次数显示
        private void SetLabelReceivedCntText(Object Text)
        {
            this.LabelReceivedCnt.Text = Text.ToString() ;
        }
        //设置串口接收的数据显示
        private void SetLabelReceivedDataText(Object Text)
        {
            this.LabelReceivedData.Text = Text.ToString();
        }
        //设置当前档位显示
        private void SetLabelCurrentSpeedText(Object Text)
        {
            this.LabelCurrentSpeed.Text = Text.ToString();
        }
        //设置AD数字值显示
        private void SetLabelADValueText(Object Text)
        {
            this.LabelADValue.Text = Text.ToString();
        }
        //设置版本号显示
        private void SetlabelVersionText(Object Text)
        {
            this.labelVersion.Text = Text.ToString();
        }
        //设置AD参考值显示
        private void SetLabelRefADCText(Object Text)
        {
            this.LabelRefADC.Text = Text.ToString();
        }
        //设置当前温度显示
        private void SetLabelTempText(Object Text)
        {
            this.LabelTemp.Text = Text.ToString();
        }
        //设置当前温度点火状态显示
        private void SetLabelFire1Text(Object Text)
        {
            this.LabelFire1.Text = Text.ToString();
        }
        //设置当前设置点火状态显示
        private void SetLabelFire2Text(Object Text)
        {
            this.LabelFire2.Text = Text.ToString();
        }
        //设置开火温度显示
        private void SetLabelTempFireText(Object Text)
        {
            this.LabelTempFire.Text = Text.ToString();
        }
        //设置跳档值显示
        private void SetLabelSpeedVavleText(Object Text)
        {
            this.LabelSpeedVavle.Text = Text.ToString();
        }
        //设置档位回退时间显示
        private void SetLabelSpeedBackTimeText(Object Text)
        {
            this.LabelSpeedBackTime.Text = Text.ToString();
        }
        //设置开火温度稳定时间显示
        private void SetLabelTempFireStableText(Object Text)
        {
            this.LabelTempFireStable.Text = Text.ToString();
        }
        private void SerialPortDataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            
            int NumberBytes = 0;
            String DataString = "";
            String ReceivedString = "";
            byte DataByte = 0;
            NumberBytes = serialPort1.BytesToRead;
            //Debug.WriteLine("NumberBytes:" + NumberBytes + " SP_ReadBytes:" + SP_ReadBytes);
            while (NumberBytes > 0)
            {
                DataByte = (byte)serialPort1.ReadByte();
                SP_RX_Buffer[SP_ReadBytes] = DataByte;
                SP_ReadBytes++;
                NumberBytes--;
            }
            
            if (SP_ReadBytes < 5)
            {
                return;
            }
            else if(SP_ReadBytes >= 512)
            {
                SP_ReadBytes = 0;
            }
            int i = 0;
            int j = 0;
               
            if (e.EventType == SerialData.Eof)
            {
                Debug.WriteLine("EOF INT");
            }
            
            for (i = 0; i < SP_ReadBytes; i++)
            {
                if((i + DEF_MIN_DATA_LEN - 1) >= SP_ReadBytes)
                {
                    return;
                }
                //万和协议
                if ((SP_RX_Buffer[i] == SP_RX_Buffer[i + 1]) && (0x55 == SP_RX_Buffer[i]))
                {
                    int AdjustValue;
                    int CalValue = 0;
                    if ((i + 9) >= SP_ReadBytes)
                    {
                        return;
                    }
                    for (; i < 10; i++)
                    {
                        DataString = DataString + String.Format("{0:X2}", SP_RX_Buffer[i]) + " ";
                    }
                    for (j = 0; j < SP_ReadBytes; j++)
                    {
                        ReceivedString = ReceivedString + String.Format("{0:X2}", SP_RX_Buffer[j]) + " ";
                    }
                    Debug.WriteLine("ReceivedString: " + ReceivedString);
                    //计算校验位
                    for (j = 0; j < 8; j++)
                    {
                        CalValue += SP_RX_Buffer[i + j];
                    }
                    //获取协议中的校验位
                    AdjustValue = (SP_RX_Buffer[i + 8] << 8) | SP_RX_Buffer[i + 9];
                    if (AdjustValue != CalValue)
                    {
                        Debug.WriteLine("Wanhe Adjust fail! AdjustValue " + AdjustValue + " CalValue:" + CalValue);
                        return;
                    }
                    
                    int TempValue = 0;
                    String TempString;
                    ReceivedTimes++;
                    //当前档位
                    TempValue = SP_RX_Buffer[3];
                    //LabelCurrentSpeed.Text = TempValue + "";
                    m_SyncContext.Post(SetLabelCurrentSpeedText, TempValue + "");
                    //当前ADC值
                    TempValue = (SP_RX_Buffer[4] << 8) | SP_RX_Buffer[5];
                    TempString = TempValue + "  ";
                    //LabelADValue.Text = TempString;
                    m_SyncContext.Post(SetLabelADValueText, TempString);
                    //LabelReceivedData.Text = DataString;
                    m_SyncContext.Post(SetLabelReceivedDataText, DataString);
                    //LabelReceivedCnt.Text = ReceivedTimes + "";
                    m_SyncContext.Post(SetLabelReceivedCntText, ReceivedTimes + "");
                    if(SHOW_TEMP_AD_VALUE)
                    {
                        TempValue = (SP_RX_Buffer[6] << 8) | SP_RX_Buffer[7];
                        StringTemperatureAD = TempValue + "";
                        m_SyncContext.Post(SetLabelTempText, StringTemperatureValue + "  " + StringTemperatureAD);
                    }
                    SP_ReadBytes = 0;
                    //Debug.WriteLine("DataString:" + DataString);
                    return;
                }
                //自定义协议
                else if(SP_RX_Buffer[i] == 0xaa)
                {
                    int CalValue = 0;
                    int Cmd = 0;
                    if ((i + 4) >= SP_ReadBytes)
                    {
                        return;
                    }
                    for (j = 0; j < SP_ReadBytes; j++)
                    {
                        ReceivedString = ReceivedString + String.Format("{0:X2}", SP_RX_Buffer[j]) + " ";
                    }
                    Debug.WriteLine("ReceivedString: " + ReceivedString);
                    //计算校验位
                    for (j = 0; j < 4; j++)
                    {
                        CalValue += SP_RX_Buffer[i + j];
                    }
                    CalValue &= 0xff;
                    if (CalValue != SP_RX_Buffer[i + 4])
                    {
                        Debug.WriteLine("Customer Adjust fail! AdjustValue " + SP_RX_Buffer[i + 4] + " CalValue:" + CalValue);
                        return;
                    }
                    Cmd = SP_RX_Buffer[i + 1];
                    if (0 != (Cmd & 0x80))
                    {
                        int TempValue = 0;
                        switch (Cmd & 0x7f)
                        {
                            //温度值
                            case 0x01:
                                //LabelTemp.Text = SP_RX_Buffer[i + 3] + "";
                                StringTemperatureValue = SP_RX_Buffer[i + 3] + "";
                                m_SyncContext.Post(SetLabelTempText, StringTemperatureValue + "  " + StringTemperatureAD);
                                break;
                            //点火状态
                            case 0x02:
                                //LabelFire1.Text = "温度检测" + ((0 == SP_RX_Buffer[i + 2]) ? "关火" : "开火");
                                //LabelFire2.Text = "设置火" + ((0 == SP_RX_Buffer[i + 3]) ? "关" : "开");
                                m_SyncContext.Post(SetLabelFire1Text, "温度检测" + ((0 == SP_RX_Buffer[i + 2]) ? "关火" : "开火"));
                                m_SyncContext.Post(SetLabelFire2Text, "设置火" + ((0 == SP_RX_Buffer[i + 3]) ? "关" : "开"));
                                break;
                            //ADC参考值
                            case 0x03:
                                TempValue = (SP_RX_Buffer[i + 2] << 8) | SP_RX_Buffer[i + 3];
                                //LabelRefADC.Text = TempValue + "";
                                m_SyncContext.Post(SetLabelRefADCText, TempValue + "");
                                break;
                            //版本号
                            case 0x04:
                                TempValue = (SP_RX_Buffer[i + 2] << 8) | SP_RX_Buffer[i + 3];
                                //labelVersion.Text = TempValue + "";
                                m_SyncContext.Post(SetlabelVersionText, TempValue + "");
                                break;
                            //档位回退时间
                            case 0x05:
                                TempValue = SP_RX_Buffer[i + 3];
                                //LabelSpeedBackTime.Text = TempValue + "";
                                m_SyncContext.Post(SetLabelSpeedBackTimeText, TempValue + "");
                                break;
                            //开火温度稳定时间
                            case 0x06:
                                TempValue = SP_RX_Buffer[i + 3];
                                //LabelTempFireStable.Text = TempValue + "";
                                m_SyncContext.Post(SetLabelTempFireStableText, TempValue + "");
                                break;
                            //开火温度
                            case 0x07:
                                TempValue = SP_RX_Buffer[i + 3];
                                //LabelTempFire.Text = TempValue + "";
                                m_SyncContext.Post(SetLabelTempFireText, TempValue + "");
                                break;
                            case 0x08:
                                TempValue = SP_RX_Buffer[i + 3];
                                //LabelSpeedVavle.Text = TempValue + "";
                                m_SyncContext.Post(SetLabelSpeedVavleText, TempValue + "");
                                break;
                            default:
                                Debug.WriteLine("Invaild cmd");
                                break;
                        }
                    }
                    SP_ReadBytes = 0;
                }
            }
            
        }
        private void SerialPortDataSend(byte Cmd, int Data)
        {
            if (serialPort1.IsOpen)
            {
                int i = 0;
                byte AdjustValue = 0;
                String SendString = "";
                byte[] SendData = new byte[5];
                SendData[0] = 0xaa;


                SendData[1] = Cmd;
                SendData[2] = (byte)((Data >> 8) & 0xff);
                SendData[3] = (byte)(Data & 0xff);
                for (i = 0; i < 4; i++)
                {
                    AdjustValue += SendData[i];
                }
                SendData[4] = AdjustValue;
                for (i = 0; i < 5; i++)
                {
                    SendString = SendString + String.Format("{0:X2}", SendData[i]) + " ";
                }
                Debug.WriteLine("SendString: " + SendString);
                serialPort1.DiscardOutBuffer();
                serialPort1.Write(SendData, 0, 5);
            }
            else
            {
                MessageBox.Show("串口未打开！");
            }
        }

        private void LabelSpeedText_Click(object sender, EventArgs e)
        {

        }

        private void BoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if(-1 == BoxCom.SelectedIndex)
            {
                MessageBox.Show("请选择正确的端口");
                return;
            }
            //如果串口没有打开则打开串口  如果已经打开则关闭串口
            if (false == serialPort1.IsOpen)
            {
                //设置串口名称
                serialPort1.PortName = BoxCom.GetItemText(BoxCom.SelectedItem);
                Debug.WriteLine("PortName:" + BoxCom.GetItemText(BoxCom.SelectedItem));
                //设置串口波特率
                serialPort1.BaudRate = DefaultBaudRate;
                //设置串口停止位 1位停止位
                serialPort1.StopBits = StopBits.One;
                //设置串口数据位 8位数据位
                serialPort1.DataBits = 8;
                //设置串口奇偶校验位   无校验
                serialPort1.Parity = Parity.None;
                serialPort1.ReceivedBytesThreshold = 1;
                try
                {
                    serialPort1.Open();
                    BtnOpen.Text = "关闭串口";
                    BoxCom.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("串口打开失败！");
                }
            }
            else
            {
                serialPort1.Close();
                ReceivedTimes = 0;
                SP_ReadBytes = 0;
                LabelReceivedCnt.Text = ReceivedTimes + "";
                BtnOpen.Text = "打开串口";
                BoxCom.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                SerialPortDataSend(CMD_SET_FORBIDEN_TEMP_FIRE, 1);
            }
            else
            {
                SerialPortDataSend(CMD_SET_FORBIDEN_TEMP_FIRE, 0);
            }
        }

        private void CheckBoxOpenFire_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxOpenFire.CheckState == CheckState.Checked)
            {
                SerialPortDataSend(CMD_SET_FIRE_STATUS, 1);
            }
            else
            {
                SerialPortDataSend(CMD_SET_FIRE_STATUS, 0);
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            int Select = -1;
            Select = BoxReadList.SelectedIndex;
            switch (Select)
            {
                //读当前温度
                case 0:
                    SerialPortDataSend(CMD_GET_TEMPERATURE, 0);
                    break;
                //读版本号
                case 1:
                    SerialPortDataSend(CMD_GET_VERSION, 0);
                    break;
                //读灵敏度
                case 2:
                    SerialPortDataSend(CMD_GET_SWITCH_SPEED_VAVLE, 0);
                    break;
                //读开火温度
                case 3:
                    SerialPortDataSend(CMD_GET_OPEN_FIRE_TEMP, 0);
                    break;
                //读火焰状态
                case 4:
                    SerialPortDataSend(CMD_GET_FIRE_STATUS, 0); 
                    break;
                //读AD参考值
                case 5:
                    SerialPortDataSend(CMD_GET_ADC_REF_VALUE, 0); 
                    break;
                //读档位回退时间
                case 6:
                    SerialPortDataSend(CMD_GET_SPEED_BACK_TIME, 0);
                    break;
                //读开火温度稳定时间
                case 7:
                    SerialPortDataSend(CMD_GET_TEMP_FIRE_STABLE_TIME, 0);
                    break;
                default:
                    break;
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            int Select = -1;
            int TempValue = 0;
            Select = BoxSetList.SelectedIndex;
            TempValue = Convert.ToInt32(EditSetData.Text, 10);
            switch (Select)
            {
                //灵敏度
                case 0:
                    if ((TempValue < 0) || (TempValue > 100))
                    {
                        MessageBox.Show("错误:跳档值范围为0-100,当前值:" + EditSetData.Text);
                        return;
                    }
                    SerialPortDataSend(CMD_SET_SWITCH_SPEED_VAVLE, TempValue);
                    break; 
                //设置开火温度
                case 1:
                    if ((TempValue < 0) || (TempValue > 100))
                    {
                        MessageBox.Show("错误:开火温度范围为0-100,当前值:" + EditSetData.Text);
                        return;
                    }
                    SerialPortDataSend(CMD_SET_OPEN_FIRE_TEMPERATURE, TempValue);
                    break;
                //档位回退时间
                case 2:
                    if ((TempValue < 0) || (TempValue > 255))
                    {
                        MessageBox.Show("错误:档位回退时间范围为0-255,当前值:" + EditSetData.Text);
                        return;
                    }
                    SerialPortDataSend(CMD_SET_SPEED_BACK_TIME, TempValue);
                    break;
                //开火温度稳定时间
                case 3:
                    if ((TempValue < 0) || (TempValue > 255))
                    {
                        MessageBox.Show("错误:开火温度稳定时间范围为0-255,当前值:" + EditSetData.Text);
                        return;
                    }
                    SerialPortDataSend(CMD_SET_TEMP_FIRE_STABLE_TIME, TempValue);
                    break;
                default:
                    break;
                    
            }
        }
    }
}
