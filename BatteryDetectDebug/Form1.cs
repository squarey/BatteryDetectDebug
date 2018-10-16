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
        private const int SMOKE_STATUS_NONE = 0;
        private const int SMOKE_STATUS_SMALL = 1;
        private const int SMOKE_STATUS_MIDDLE = 2;
        private const int SMOKE_STATUS_BIG = 3;

        private int ReceivedTimes = 0;
        private byte[] SP_RX_Buffer = new byte[512];
        private int SP_ReadBytes = 0;

        private const bool SHOW_TEMP_AD_VALUE = false;
        //设置的当前电源状态
        private int _SetPowerStatus = 0;
        //设置的灵敏度
        private int _SetSensitivityValue = 0;
        //设置当前的回退时间
        private int _SetBackTimeValue = 0;
        private int _CurADMaxValue = 0;
        private int _CurADMinValue = 1024;
        private int _CurADAverageValue = 0;
        /*
        private int _SmokeReduceCnt = 0;
        private bool _SmokeReduceFlag = false;
        private bool _StartAdjustFlag = false;
        private bool _StartCompareADValue = false;
        private int _FirstAdjustCnt = 0;
        private int _LastSmokeStatus = SMOKE_STATUS_NONE;
        private Thread _TimerThread = null;
        */
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
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataRecived);
            this.FormClosed += new FormClosedEventHandler(BatteryDetect_FormClosed);
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
        //检测到的AD最大值
        private void SetLabelADMaxValueText(Object Text)
        {
            this.LabelADMaxValue.Text = Text.ToString();
        }
        //检测到的AD最小值
        private void SetLabelADMinValueText(Object Text)
        {
            this.LabelADMinValue.Text = Text.ToString();
        }
        //检测到的AD平均值
        private void SetLabelADAveValueText(Object Text)
        {
            this.LabelADAveValue.Text = Text.ToString();
        }
        //设置版本号显示
        private void SetLabelVersionText(Object Text)
        {
            this.LabelVersion.Text = Text.ToString();
        }
        //灵敏度
        private void SetLableSensitValueText(Object Text)
        {
            this.LableSensitValue.Text = Text.ToString();
        }
        //电源状态
        private void SetLabelPowerStatusValueText(Object Text)
        {
            this.LabelPowerStatusValue.Text = Text.ToString();
        }
        //档位回退时间
        private void SetLabelBackTimeValueText(Object Text)
        {
            this.LabelBackTimeValue.Text = Text.ToString();
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
                if (SP_ReadBytes >= 512)
                {
                    SP_ReadBytes = 0;
                }
                if (serialPort1.IsOpen)
                {
                    DataByte = (byte)serialPort1.ReadByte();
                    SP_RX_Buffer[SP_ReadBytes] = DataByte;
                    SP_ReadBytes++;
                    NumberBytes--;
                }
            }
            
            if (SP_ReadBytes < 10)
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
                    int AdjustValue = 0;
                    int CalValue = 0;
                    int k = 0;
                    if ((i + 9) >= SP_ReadBytes)
                    {
                        return;
                    }
                    int FrameLen = i + 10;
                    for (k = i; k < FrameLen; k++)
                    {
                        DataString = DataString + String.Format("{0:X2}", SP_RX_Buffer[k]) + " ";
                    }
                    /* for (j = 0; j < SP_ReadBytes; j++)
                     {
                         ReceivedString = ReceivedString + String.Format("{0:X2}", SP_RX_Buffer[j]) + " ";
                     }*/
                    // Debug.WriteLine("DataString: " + DataString);
                    //计算校验位
                    for (j = 0; j < 8; j++)
                    {
                        CalValue += SP_RX_Buffer[i + j];
                    }
                    //获取协议中的校验位
                    AdjustValue = (SP_RX_Buffer[i + 8] << 8) | SP_RX_Buffer[i + 9];
                    if (AdjustValue != CalValue)
                    {
                        Debug.WriteLine("Wanhe Adjust fail! AdjustValue " + AdjustValue + " CalValue:" + CalValue + " i:" + i);
                        Debug.WriteLine("SP_RX_Buffer[i + 8] = " + String.Format("{0:X2}", SP_RX_Buffer[i + 8]) + " SP_RX_Buffer[i + 9] = " + String.Format("{0:X2}", SP_RX_Buffer[i + 9]));
                        return;
                    }

                    int TempValue = 0;
                    int CurSmokeStatus;
                    String TempString;
                    ReceivedTimes++;
                    //当前档位
                    // TempValue = SP_RX_Buffer[i + 3];
                    //LabelCurrentSpeed.Text = TempValue + "";
                    m_SyncContext.Post(SetLabelCurrentSpeedText, SP_RX_Buffer[i + 3] + "");
                    //当前ADC值
                    TempValue = (SP_RX_Buffer[i + 4] << 8) | SP_RX_Buffer[i + 5];
                    
                    /*
                                        CurSmokeStatus = ADValueCalculation(TempValue, DataString);
                                        if (CurSmokeStatus < _LastSmokeStatus)
                                        {
                                            //烟雾档位减小持续3秒则算稳定
                                            if (_SmokeReduceCnt >= 30)
                                            {
                                                if (_LastSmokeStatus > SMOKE_STATUS_NONE)
                                                {
                                                    _LastSmokeStatus--;
                                                }
                                                _SmokeReduceFlag = false;
                                            }
                                            else if (0 == _SmokeReduceCnt)
                                            {
                                                _SmokeReduceFlag = true;
                                            }
                                        }
                                        else
                                        {
                                            _LastSmokeStatus = CurSmokeStatus;
                                            _SmokeReduceFlag = false;
                                        }
                    */
                    TempString = TempValue + "  ";
                    _CurADAverageValue += TempValue;
                    _CurADAverageValue /= 2;
                    m_SyncContext.Post(SetLabelADAveValueText, _CurADAverageValue + "");
                    if (_CurADMaxValue < TempValue)
                    {
                        _CurADMaxValue = TempValue;
                        m_SyncContext.Post(SetLabelADMaxValueText, _CurADMaxValue + "");
                    }
                    if (_CurADMinValue > TempValue)
                    {
                        _CurADMinValue = TempValue;
                        m_SyncContext.Post(SetLabelADMinValueText, _CurADMinValue + "");
                    }
                    //LabelADValue.Text = TempString;
                    m_SyncContext.Post(SetLabelADValueText, TempString);
                    //LabelReceivedData.Text = DataString;
                    m_SyncContext.Post(SetLabelReceivedDataText, DataString);
                    //LabelReceivedCnt.Text = ReceivedTimes + "";
                    m_SyncContext.Post(SetLabelReceivedCntText, ReceivedTimes + "");
                    SP_ReadBytes = 0;
                    //Debug.WriteLine("DataString:" + DataString);
                    return;
                }
                //自定义协议
                else if ((0x55 == SP_RX_Buffer[i]) && (0xaa == SP_RX_Buffer[i + 1]))
                {
                    int IsDo = 0;
                    int DataPos = 0;
                    int Cmd = 0;
                    int AdjustValue1 = 0;
                    int AdjustValue2 = 0;
                    int PowerStatus = 0;
                    int SensitivityValue = 0;
                    int BackTimeSetValue = 0;
                    int Version = 0;

                    //判断是否是有效帧
                    if ((i + 9) >= SP_ReadBytes)
                    {
                        return;
                    }
                    //计算校验位
                    for (j = 0; j < 8; j++)
                    {
                        AdjustValue1 += SP_RX_Buffer[i + j];
                    }
                    AdjustValue2 = (SP_RX_Buffer[i + 8] << 8) | SP_RX_Buffer[i + 9];
                    //校验错误则不处理
                    if (AdjustValue1 != AdjustValue2)
                    {
                        return;
                    }
                    else
                    {
                        IsDo = 1;
                        //记录帧开始的位置
                        DataPos = i;
                        //如果有正确的帧  则复位串口接收的长度
                    }
                    if (0 == IsDo)
                    {
                        return;
                    }
                    else
                    {
                        //获取命令字
                        Cmd = SP_RX_Buffer[DataPos + 2];
                        //命令是返回数据
                        if (0 != (Cmd & 0x10))
                        {
                            PowerStatus = SP_RX_Buffer[DataPos + 3];
                            SensitivityValue = SP_RX_Buffer[DataPos + 4];
                            BackTimeSetValue = SP_RX_Buffer[DataPos + 5];
                            Version = SP_RX_Buffer[DataPos + 7];
                            if (0 == PowerStatus)
                            {
                                m_SyncContext.Post(SetLabelPowerStatusValueText, "关");
                            }
                            else
                            {
                                m_SyncContext.Post(SetLabelPowerStatusValueText, "开");
                            }
                            m_SyncContext.Post(SetLableSensitValueText, SensitivityValue + "%");
                            m_SyncContext.Post(SetLabelBackTimeValueText, BackTimeSetValue + "秒");
                            m_SyncContext.Post(SetLabelVersionText, Version + "");
                        }
                    }
                    SP_ReadBytes = 0;
                }
            }

        }
        private void SerialPortDataSend(bool IsWrite)
        {
            if (serialPort1.IsOpen)
            {
                int i = 0;
                int AdjustValue = 0;
                String SendString = "";
                byte[] SendData = new byte[10];
                SendData[0] = 0x55;
                SendData[1] = 0xaa;
                if (IsWrite)
                {
                    SendData[2] = 0x08;
                }
                else
                {
                    SendData[2] = 0x01;
                }
                SendData[3] = (byte)(_SetPowerStatus & 0xff);
                SendData[4] = (byte)(_SetSensitivityValue & 0xff);
                SendData[5] = (byte)(_SetBackTimeValue & 0xff);
                SendData[6] = 0;
                SendData[7] = 0;
                for (i = 0; i < 10; i++)
                {
                    AdjustValue += SendData[i];
                }
                SendData[8] = (byte)((AdjustValue >> 8) & 0xff);
                SendData[9] = (byte)(AdjustValue & 0xff);
                for (i = 0; i < 10; i++)
                {
                    SendString = SendString + String.Format("{0:X2}", SendData[i]) + " ";
                }
                Debug.WriteLine("SendString: " + SendString);
                serialPort1.DiscardOutBuffer();
                serialPort1.Write(SendData, 0, 10);
            }
            else
            {
                MessageBox.Show("串口未打开！");
            }
        }
/*
        private int IntAbs(int a, int b)
        {
            if(a > b)
            {
                return (a - b);
            }
            else
            {
                return (b - a);
            }
        }
        //使用AD值判断此时是否有烟雾
        private int ADValueCalculation(int ADValue, String s)
        {
            //确保前面已经将激光关闭才重新校准值
            _StartCompareADValue = true;
            if (_StartCompareADValue)
            {
                //判断是否在抖动范围内, 如果是在抖动范围内 则重新计算最大值
                if(IntAbs(_CurADMaxValue, ADValue) < 50)
                {
                    _CurADMaxValue += ADValue;
                    _CurADMaxValue /= 2;
                    return SMOKE_STATUS_NONE;
                }
                else
                {
                    if(ADValue < _CurADMaxValue)
                    {
                        int Dif = 0;
                        int Percent = 0;
                        Dif = (_CurADMaxValue - ADValue) * 100 ;
                        Percent = Dif / _CurADMaxValue;
                         if(_CurADMinValue > ADValue)
                         {
                            Debug.WriteLine("_CurADMinValue " + _CurADMinValue + " ADValue " + ADValue);
                            Debug.WriteLine("Received data string " + s);
                            _CurADMinValue = ADValue;
                         }
                        //如果变化是在5%以内 则说明有小烟
                        if (Percent <= 5)
                        {
                            return SMOKE_STATUS_SMALL;
                        }//如果变化在5%-10%内则 则说明有中烟
                        else if(Percent <= 10)
                        {
                            return SMOKE_STATUS_MIDDLE;
                        }//变化大于10% 则说明有大烟
                        else
                        {
                            return SMOKE_STATUS_BIG;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Maybe this ADValue " + ADValue + " is error, _CurADMaxValue " + _CurADMaxValue);
                        if(ADValue < 1024)
                        {
                            _CurADMaxValue += ADValue;
                            _CurADMaxValue /= 2;
                        }
                        return SMOKE_STATUS_NONE;
                    }
                }
            }
            else
            {
                return SMOKE_STATUS_NONE;
            }
            
        }
        private void LabelSpeedText_Click(object sender, EventArgs e)
        {

        }

        private void BoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //开启线程来计时
        private void TimerThread_cb()
        {
            while(true)
            {
                if (_StartAdjustFlag)
                {
                    _FirstAdjustCnt++;
                }
                else
                {
                    _FirstAdjustCnt = 0;
                }
                if(_SmokeReduceFlag)
                {
                    _SmokeReduceCnt++;
                    if(_SmokeReduceCnt > 311)
                    {
                        _SmokeReduceCnt = 0;
                    }
                }
                else
                {
                    _SmokeReduceCnt = 0;
                }
                Thread.Sleep(100);
            }
        }
        private void StartTimerThread()
        {
            _TimerThread = new Thread(TimerThread_cb);
            _TimerThread.Start();
        }
        private void CloseTimerThread()
        {
            if(null != _TimerThread)
            {
                _TimerThread.Abort();
            }
        }
 */
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
                    //StartTimerThread();
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
               // CloseTimerThread();
                _CurADMaxValue = 0;
                _CurADMinValue = 1024;
            }
        }
        private void BatteryDetect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Close window");
            //CloseTimerThread();
            //serialPort1.Close();
        }

        private void BtnSetParam_Click(object sender, EventArgs e)
        {
            String TempString;
            int TempValue = 0;
            //获取灵敏度值
            TempString = this.EditSensit.Text;
            if(0 == TempString.Length)
            {
                MessageBox.Show("请输入设置的灵敏度值!");
                return;
            }
            TempValue = Convert.ToInt32(TempString);
            if ((TempValue > 95) || (TempValue < 1))
            {
                MessageBox.Show("灵敏度可设置范围 1%-95% !");
                return;
            }
            _SetSensitivityValue = TempValue;
            //获取回退时间值
            TempString = this.EditBackTime.Text;
            if (0 == TempString.Length)
            {
                MessageBox.Show("请输入设置的回退时间!");
                return;
            }
            TempValue = Convert.ToInt32(TempString);
            if ((TempValue > 95) || (TempValue < 1))
            {
                MessageBox.Show("回退时间可设置范围 1秒-255秒 !");
                return;
            }
            _SetBackTimeValue = TempValue;
            SerialPortDataSend(true);
        }

        private void CheckPowerStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckPowerStatus.CheckState == CheckState.Checked)
            {
                _SetPowerStatus = 1;
            }
            else
            {
                _SetPowerStatus = 0;
            }
            SerialPortDataSend(true);
        }

        private void BtnReadParam_Click(object sender, EventArgs e)
        {
            SerialPortDataSend(false);
        }
    }
}
