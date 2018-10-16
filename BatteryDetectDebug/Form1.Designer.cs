namespace BatteryDetectDebug
{
    partial class BatteryDetectDebug
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelReceivedText = new System.Windows.Forms.Label();
            this.LabelReceivedData = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.LabelSpeedText = new System.Windows.Forms.Label();
            this.BoxCom = new System.Windows.Forms.ComboBox();
            this.LabelCurrentSpeed = new System.Windows.Forms.Label();
            this.LabelADValueText = new System.Windows.Forms.Label();
            this.LabelADValue = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelReceivedCnt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LabelADAveValueText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelADAveValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelADMaxValueText = new System.Windows.Forms.Label();
            this.LabelADMinValueText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelADMaxValue = new System.Windows.Forms.Label();
            this.LabelADMinValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnReadParam = new System.Windows.Forms.Button();
            this.CheckPowerStatus = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSetParam = new System.Windows.Forms.Button();
            this.EditSensit = new System.Windows.Forms.TextBox();
            this.EditBackTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LableSensitValue = new System.Windows.Forms.Label();
            this.LabelBackTimeValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPowerStatusText = new System.Windows.Forms.Label();
            this.LabelPowerStatusValue = new System.Windows.Forms.Label();
            this.LabelSensitText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelReceivedText
            // 
            this.LabelReceivedText.AutoSize = true;
            this.LabelReceivedText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelReceivedText.Location = new System.Drawing.Point(3, 10);
            this.LabelReceivedText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelReceivedText.Name = "LabelReceivedText";
            this.LabelReceivedText.Size = new System.Drawing.Size(142, 19);
            this.LabelReceivedText.TabIndex = 0;
            this.LabelReceivedText.Text = "接收到的数据：";
            // 
            // LabelReceivedData
            // 
            this.LabelReceivedData.AutoSize = true;
            this.LabelReceivedData.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelReceivedData.Location = new System.Drawing.Point(3, 152);
            this.LabelReceivedData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelReceivedData.Name = "LabelReceivedData";
            this.LabelReceivedData.Size = new System.Drawing.Size(39, 19);
            this.LabelReceivedData.TabIndex = 1;
            this.LabelReceivedData.Text = "---";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOpen.Location = new System.Drawing.Point(3, 69);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(106, 32);
            this.BtnOpen.TabIndex = 3;
            this.BtnOpen.Text = "打开串口";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // LabelSpeedText
            // 
            this.LabelSpeedText.AutoSize = true;
            this.LabelSpeedText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSpeedText.Location = new System.Drawing.Point(3, 181);
            this.LabelSpeedText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelSpeedText.Name = "LabelSpeedText";
            this.LabelSpeedText.Size = new System.Drawing.Size(95, 19);
            this.LabelSpeedText.TabIndex = 4;
            this.LabelSpeedText.Text = "当前档位:";
            // 
            // BoxCom
            // 
            this.BoxCom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BoxCom.FormattingEnabled = true;
            this.BoxCom.Location = new System.Drawing.Point(3, 34);
            this.BoxCom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BoxCom.Name = "BoxCom";
            this.BoxCom.Size = new System.Drawing.Size(121, 27);
            this.BoxCom.TabIndex = 5;
            // 
            // LabelCurrentSpeed
            // 
            this.LabelCurrentSpeed.AutoSize = true;
            this.LabelCurrentSpeed.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCurrentSpeed.Location = new System.Drawing.Point(3, 205);
            this.LabelCurrentSpeed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelCurrentSpeed.Name = "LabelCurrentSpeed";
            this.LabelCurrentSpeed.Size = new System.Drawing.Size(39, 19);
            this.LabelCurrentSpeed.TabIndex = 6;
            this.LabelCurrentSpeed.Text = "---";
            // 
            // LabelADValueText
            // 
            this.LabelADValueText.AutoSize = true;
            this.LabelADValueText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADValueText.Location = new System.Drawing.Point(3, 7);
            this.LabelADValueText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelADValueText.Name = "LabelADValueText";
            this.LabelADValueText.Size = new System.Drawing.Size(96, 19);
            this.LabelADValueText.TabIndex = 7;
            this.LabelADValueText.Text = "当前AD值:";
            // 
            // LabelADValue
            // 
            this.LabelADValue.AutoSize = true;
            this.LabelADValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADValue.Location = new System.Drawing.Point(3, 5);
            this.LabelADValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelADValue.Name = "LabelADValue";
            this.LabelADValue.Size = new System.Drawing.Size(39, 19);
            this.LabelADValue.TabIndex = 8;
            this.LabelADValue.Text = "---";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.BoxCom);
            this.flowLayoutPanel1.Controls.Add(this.BtnOpen);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.LabelReceivedData);
            this.flowLayoutPanel1.Controls.Add(this.LabelSpeedText);
            this.flowLayoutPanel1.Controls.Add(this.LabelCurrentSpeed);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 437);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "串口选择:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LabelReceivedText);
            this.flowLayoutPanel2.Controls.Add(this.LabelReceivedCnt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 107);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 37);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // LabelReceivedCnt
            // 
            this.LabelReceivedCnt.AutoSize = true;
            this.LabelReceivedCnt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelReceivedCnt.Location = new System.Drawing.Point(151, 10);
            this.LabelReceivedCnt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LabelReceivedCnt.Name = "LabelReceivedCnt";
            this.LabelReceivedCnt.Size = new System.Drawing.Size(39, 19);
            this.LabelReceivedCnt.TabIndex = 9;
            this.LabelReceivedCnt.Text = "---";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LabelADAveValueText);
            this.panel5.Controls.Add(this.LabelADValueText);
            this.panel5.Location = new System.Drawing.Point(3, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 32);
            this.panel5.TabIndex = 12;
            // 
            // LabelADAveValueText
            // 
            this.LabelADAveValueText.AutoSize = true;
            this.LabelADAveValueText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADAveValueText.Location = new System.Drawing.Point(127, 7);
            this.LabelADAveValueText.Name = "LabelADAveValueText";
            this.LabelADAveValueText.Size = new System.Drawing.Size(76, 19);
            this.LabelADAveValueText.TabIndex = 10;
            this.LabelADAveValueText.Text = "平均值:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LabelADAveValue);
            this.panel6.Controls.Add(this.LabelADValue);
            this.panel6.Location = new System.Drawing.Point(3, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(405, 31);
            this.panel6.TabIndex = 13;
            // 
            // LabelADAveValue
            // 
            this.LabelADAveValue.AutoSize = true;
            this.LabelADAveValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADAveValue.Location = new System.Drawing.Point(127, 5);
            this.LabelADAveValue.Name = "LabelADAveValue";
            this.LabelADAveValue.Size = new System.Drawing.Size(39, 19);
            this.LabelADAveValue.TabIndex = 11;
            this.LabelADAveValue.Text = "---";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelADMaxValueText);
            this.panel2.Controls.Add(this.LabelADMinValueText);
            this.panel2.Location = new System.Drawing.Point(3, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 36);
            this.panel2.TabIndex = 14;
            // 
            // LabelADMaxValueText
            // 
            this.LabelADMaxValueText.AutoSize = true;
            this.LabelADMaxValueText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADMaxValueText.Location = new System.Drawing.Point(0, 9);
            this.LabelADMaxValueText.Name = "LabelADMaxValueText";
            this.LabelADMaxValueText.Size = new System.Drawing.Size(85, 19);
            this.LabelADMaxValueText.TabIndex = 8;
            this.LabelADMaxValueText.Text = "最大值：";
            // 
            // LabelADMinValueText
            // 
            this.LabelADMinValueText.AutoSize = true;
            this.LabelADMinValueText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADMinValueText.Location = new System.Drawing.Point(127, 9);
            this.LabelADMinValueText.Name = "LabelADMinValueText";
            this.LabelADMinValueText.Size = new System.Drawing.Size(76, 19);
            this.LabelADMinValueText.TabIndex = 9;
            this.LabelADMinValueText.Text = "最小值:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelADMaxValue);
            this.panel3.Controls.Add(this.LabelADMinValue);
            this.panel3.Location = new System.Drawing.Point(3, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 36);
            this.panel3.TabIndex = 15;
            // 
            // LabelADMaxValue
            // 
            this.LabelADMaxValue.AutoSize = true;
            this.LabelADMaxValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADMaxValue.Location = new System.Drawing.Point(0, 15);
            this.LabelADMaxValue.Name = "LabelADMaxValue";
            this.LabelADMaxValue.Size = new System.Drawing.Size(39, 19);
            this.LabelADMaxValue.TabIndex = 9;
            this.LabelADMaxValue.Text = "---";
            // 
            // LabelADMinValue
            // 
            this.LabelADMinValue.AutoSize = true;
            this.LabelADMinValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelADMinValue.Location = new System.Drawing.Point(127, 15);
            this.LabelADMinValue.Name = "LabelADMinValue";
            this.LabelADMinValue.Size = new System.Drawing.Size(39, 19);
            this.LabelADMinValue.TabIndex = 10;
            this.LabelADMinValue.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "软件版本:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(504, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 437);
            this.panel1.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(4, 227);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(279, 198);
            this.panel7.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.BtnReadParam);
            this.panel9.Controls.Add(this.CheckPowerStatus);
            this.panel9.Location = new System.Drawing.Point(137, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(135, 188);
            this.panel9.TabIndex = 6;
            // 
            // BtnReadParam
            // 
            this.BtnReadParam.AutoSize = true;
            this.BtnReadParam.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnReadParam.Location = new System.Drawing.Point(19, 63);
            this.BtnReadParam.Name = "BtnReadParam";
            this.BtnReadParam.Size = new System.Drawing.Size(75, 29);
            this.BtnReadParam.TabIndex = 1;
            this.BtnReadParam.Text = "读取";
            this.BtnReadParam.UseVisualStyleBackColor = true;
            this.BtnReadParam.Visible = false;
            this.BtnReadParam.Click += new System.EventHandler(this.BtnReadParam_Click);
            // 
            // CheckPowerStatus
            // 
            this.CheckPowerStatus.AutoSize = true;
            this.CheckPowerStatus.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckPowerStatus.Location = new System.Drawing.Point(8, 14);
            this.CheckPowerStatus.Name = "CheckPowerStatus";
            this.CheckPowerStatus.Size = new System.Drawing.Size(104, 23);
            this.CheckPowerStatus.TabIndex = 0;
            this.CheckPowerStatus.Text = "开启电源";
            this.CheckPowerStatus.UseVisualStyleBackColor = true;
            this.CheckPowerStatus.CheckedChanged += new System.EventHandler(this.CheckPowerStatus_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.BtnSetParam);
            this.panel8.Controls.Add(this.EditSensit);
            this.panel8.Controls.Add(this.EditBackTime);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(133, 188);
            this.panel8.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(76, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(76, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "灵敏度:";
            // 
            // BtnSetParam
            // 
            this.BtnSetParam.AutoSize = true;
            this.BtnSetParam.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetParam.Location = new System.Drawing.Point(18, 120);
            this.BtnSetParam.Name = "BtnSetParam";
            this.BtnSetParam.Size = new System.Drawing.Size(75, 29);
            this.BtnSetParam.TabIndex = 4;
            this.BtnSetParam.Text = "设置";
            this.BtnSetParam.UseVisualStyleBackColor = true;
            this.BtnSetParam.Click += new System.EventHandler(this.BtnSetParam_Click);
            // 
            // EditSensit
            // 
            this.EditSensit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EditSensit.Location = new System.Drawing.Point(7, 31);
            this.EditSensit.MaxLength = 2;
            this.EditSensit.Name = "EditSensit";
            this.EditSensit.Size = new System.Drawing.Size(72, 29);
            this.EditSensit.TabIndex = 2;
            // 
            // EditBackTime
            // 
            this.EditBackTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EditBackTime.Location = new System.Drawing.Point(7, 85);
            this.EditBackTime.MaxLength = 3;
            this.EditBackTime.Name = "EditBackTime";
            this.EditBackTime.Size = new System.Drawing.Size(72, 29);
            this.EditBackTime.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "回退时间:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(0, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "设置:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "状态:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.LabelBackTimeValue);
            this.panel4.Controls.Add(this.LableSensitValue);
            this.panel4.Controls.Add(this.LabelVersion);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.LabelPowerStatusText);
            this.panel4.Controls.Add(this.LabelPowerStatusValue);
            this.panel4.Controls.Add(this.LabelSensitText);
            this.panel4.Location = new System.Drawing.Point(4, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 134);
            this.panel4.TabIndex = 20;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelVersion.Location = new System.Drawing.Point(104, 9);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(39, 19);
            this.LabelVersion.TabIndex = 23;
            this.LabelVersion.Text = "---";
            // 
            // LableSensitValue
            // 
            this.LableSensitValue.AutoSize = true;
            this.LableSensitValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LableSensitValue.Location = new System.Drawing.Point(105, 69);
            this.LableSensitValue.Name = "LableSensitValue";
            this.LableSensitValue.Size = new System.Drawing.Size(39, 19);
            this.LableSensitValue.TabIndex = 17;
            this.LableSensitValue.Text = "---";
            // 
            // LabelBackTimeValue
            // 
            this.LabelBackTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelBackTimeValue.AutoSize = true;
            this.LabelBackTimeValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelBackTimeValue.Location = new System.Drawing.Point(104, 97);
            this.LabelBackTimeValue.Name = "LabelBackTimeValue";
            this.LabelBackTimeValue.Size = new System.Drawing.Size(39, 19);
            this.LabelBackTimeValue.TabIndex = 19;
            this.LabelBackTimeValue.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "回退时间:";
            // 
            // LabelPowerStatusText
            // 
            this.LabelPowerStatusText.AutoSize = true;
            this.LabelPowerStatusText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPowerStatusText.Location = new System.Drawing.Point(3, 38);
            this.LabelPowerStatusText.Name = "LabelPowerStatusText";
            this.LabelPowerStatusText.Size = new System.Drawing.Size(95, 19);
            this.LabelPowerStatusText.TabIndex = 14;
            this.LabelPowerStatusText.Text = "电源状态:";
            // 
            // LabelPowerStatusValue
            // 
            this.LabelPowerStatusValue.AutoSize = true;
            this.LabelPowerStatusValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPowerStatusValue.Location = new System.Drawing.Point(104, 38);
            this.LabelPowerStatusValue.Name = "LabelPowerStatusValue";
            this.LabelPowerStatusValue.Size = new System.Drawing.Size(39, 19);
            this.LabelPowerStatusValue.TabIndex = 15;
            this.LabelPowerStatusValue.Text = "---";
            // 
            // LabelSensitText
            // 
            this.LabelSensitText.AutoSize = true;
            this.LabelSensitText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSensitText.Location = new System.Drawing.Point(3, 69);
            this.LabelSensitText.Name = "LabelSensitText";
            this.LabelSensitText.Size = new System.Drawing.Size(96, 19);
            this.LabelSensitText.TabIndex = 16;
            this.LabelSensitText.Text = "灵 敏 度:";
            // 
            // BatteryDetectDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "BatteryDetectDebug";
            this.Text = "BatteryDetectDebug";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelReceivedText;
        private System.Windows.Forms.Label LabelReceivedData;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label LabelSpeedText;
        private System.Windows.Forms.ComboBox BoxCom;
        private System.Windows.Forms.Label LabelCurrentSpeed;
        private System.Windows.Forms.Label LabelADValueText;
        private System.Windows.Forms.Label LabelADValue;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LabelReceivedCnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LabelADMinValueText;
        private System.Windows.Forms.Label LabelADMaxValueText;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LabelADMinValue;
        private System.Windows.Forms.Label LabelADMaxValue;
        private System.Windows.Forms.Label LabelADAveValueText;
        private System.Windows.Forms.Label LabelADAveValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelBackTimeValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPowerStatusText;
        private System.Windows.Forms.Label LableSensitValue;
        private System.Windows.Forms.Label LabelPowerStatusValue;
        private System.Windows.Forms.Label LabelSensitText;
        private System.Windows.Forms.TextBox EditSensit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox CheckPowerStatus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnSetParam;
        private System.Windows.Forms.TextBox EditBackTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Button BtnReadParam;
    }
}

