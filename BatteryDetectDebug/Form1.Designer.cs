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
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelRefADC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelTemp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelFire1 = new System.Windows.Forms.Label();
            this.CheckBoxOpenFire = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelReceivedCnt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelSpeedVavle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelTempFire = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelTempFireStable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelSpeedBackTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelFire2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoxReadList = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnRead = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditSetData = new System.Windows.Forms.TextBox();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BoxSetList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.LabelSpeedText.Click += new System.EventHandler(this.LabelSpeedText_Click);
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
            this.BoxCom.SelectedIndexChanged += new System.EventHandler(this.BoxCom_SelectedIndexChanged);
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
            this.LabelADValueText.Location = new System.Drawing.Point(3, 234);
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
            this.LabelADValue.Location = new System.Drawing.Point(3, 258);
            this.LabelADValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelADValue.Name = "LabelADValue";
            this.LabelADValue.Size = new System.Drawing.Size(39, 19);
            this.LabelADValue.TabIndex = 8;
            this.LabelADValue.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "当前版本:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.Location = new System.Drawing.Point(113, 11);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(39, 19);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "AD参考值:";
            // 
            // LabelRefADC
            // 
            this.LabelRefADC.AutoSize = true;
            this.LabelRefADC.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelRefADC.Location = new System.Drawing.Point(113, 45);
            this.LabelRefADC.Name = "LabelRefADC";
            this.LabelRefADC.Size = new System.Drawing.Size(39, 19);
            this.LabelRefADC.TabIndex = 13;
            this.LabelRefADC.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "当前温度:";
            // 
            // LabelTemp
            // 
            this.LabelTemp.AutoSize = true;
            this.LabelTemp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTemp.Location = new System.Drawing.Point(114, 76);
            this.LabelTemp.Name = "LabelTemp";
            this.LabelTemp.Size = new System.Drawing.Size(39, 19);
            this.LabelTemp.TabIndex = 15;
            this.LabelTemp.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "点火状态:";
            // 
            // LabelFire1
            // 
            this.LabelFire1.AutoSize = true;
            this.LabelFire1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelFire1.Location = new System.Drawing.Point(114, 107);
            this.LabelFire1.Name = "LabelFire1";
            this.LabelFire1.Size = new System.Drawing.Size(39, 19);
            this.LabelFire1.TabIndex = 19;
            this.LabelFire1.Text = "---";
            // 
            // CheckBoxOpenFire
            // 
            this.CheckBoxOpenFire.AutoSize = true;
            this.CheckBoxOpenFire.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBoxOpenFire.Location = new System.Drawing.Point(10, 19);
            this.CheckBoxOpenFire.Name = "CheckBoxOpenFire";
            this.CheckBoxOpenFire.Size = new System.Drawing.Size(66, 23);
            this.CheckBoxOpenFire.TabIndex = 27;
            this.CheckBoxOpenFire.Text = "开火";
            this.CheckBoxOpenFire.UseVisualStyleBackColor = true;
            this.CheckBoxOpenFire.CheckedChanged += new System.EventHandler(this.CheckBoxOpenFire_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(10, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(142, 23);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "禁止温度开火";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            this.flowLayoutPanel1.Controls.Add(this.LabelADValueText);
            this.flowLayoutPanel1.Controls.Add(this.LabelADValue);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 304);
            this.flowLayoutPanel1.TabIndex = 29;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LabelSpeedVavle);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LabelTempFire);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LabelTempFireStable);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LabelSpeedBackTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LabelFire2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LabelRefADC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelTemp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LabelFire1);
            this.panel1.Location = new System.Drawing.Point(504, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 304);
            this.panel1.TabIndex = 30;
            // 
            // LabelSpeedVavle
            // 
            this.LabelSpeedVavle.AutoSize = true;
            this.LabelSpeedVavle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSpeedVavle.Location = new System.Drawing.Point(114, 183);
            this.LabelSpeedVavle.Name = "LabelSpeedVavle";
            this.LabelSpeedVavle.Size = new System.Drawing.Size(39, 19);
            this.LabelSpeedVavle.TabIndex = 29;
            this.LabelSpeedVavle.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(13, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "跳 档 值:";
            // 
            // LabelTempFire
            // 
            this.LabelTempFire.AutoSize = true;
            this.LabelTempFire.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTempFire.Location = new System.Drawing.Point(114, 150);
            this.LabelTempFire.Name = "LabelTempFire";
            this.LabelTempFire.Size = new System.Drawing.Size(39, 19);
            this.LabelTempFire.TabIndex = 27;
            this.LabelTempFire.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(12, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "开火温度:";
            // 
            // LabelTempFireStable
            // 
            this.LabelTempFireStable.AutoSize = true;
            this.LabelTempFireStable.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTempFireStable.Location = new System.Drawing.Point(180, 250);
            this.LabelTempFireStable.Name = "LabelTempFireStable";
            this.LabelTempFireStable.Size = new System.Drawing.Size(39, 19);
            this.LabelTempFireStable.TabIndex = 25;
            this.LabelTempFireStable.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(13, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "开火温度稳定时间:";
            // 
            // LabelSpeedBackTime
            // 
            this.LabelSpeedBackTime.AutoSize = true;
            this.LabelSpeedBackTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSpeedBackTime.Location = new System.Drawing.Point(152, 218);
            this.LabelSpeedBackTime.Name = "LabelSpeedBackTime";
            this.LabelSpeedBackTime.Size = new System.Drawing.Size(39, 19);
            this.LabelSpeedBackTime.TabIndex = 23;
            this.LabelSpeedBackTime.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "档位回退时间:";
            // 
            // LabelFire2
            // 
            this.LabelFire2.AutoSize = true;
            this.LabelFire2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelFire2.Location = new System.Drawing.Point(114, 126);
            this.LabelFire2.Name = "LabelFire2";
            this.LabelFire2.Size = new System.Drawing.Size(39, 19);
            this.LabelFire2.TabIndex = 21;
            this.LabelFire2.Text = "---";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.CheckBoxOpenFire);
            this.panel2.Location = new System.Drawing.Point(2, 317);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 126);
            this.panel2.TabIndex = 31;
            // 
            // BoxReadList
            // 
            this.BoxReadList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BoxReadList.FormattingEnabled = true;
            this.BoxReadList.Items.AddRange(new object[] {
            "温度",
            "点火状态",
            "AD参考值",
            "版本号",
            "档位回退时间",
            "开火温度稳定时间",
            "开火温度",
            "跳档值"});
            this.BoxReadList.Location = new System.Drawing.Point(7, 31);
            this.BoxReadList.Name = "BoxReadList";
            this.BoxReadList.Size = new System.Drawing.Size(165, 27);
            this.BoxReadList.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnRead);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.BoxReadList);
            this.panel3.Location = new System.Drawing.Point(152, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 126);
            this.panel3.TabIndex = 32;
            // 
            // BtnRead
            // 
            this.BtnRead.AutoSize = true;
            this.BtnRead.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRead.Location = new System.Drawing.Point(50, 75);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 29);
            this.BtnRead.TabIndex = 31;
            this.BtnRead.Text = "读取";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "读取项：";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.EditSetData);
            this.panel4.Controls.Add(this.BtnSet);
            this.panel4.Controls.Add(this.BoxSetList);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(359, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 126);
            this.panel4.TabIndex = 33;
            // 
            // EditSetData
            // 
            this.EditSetData.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EditSetData.Location = new System.Drawing.Point(6, 71);
            this.EditSetData.Name = "EditSetData";
            this.EditSetData.Size = new System.Drawing.Size(100, 29);
            this.EditSetData.TabIndex = 3;
            this.EditSetData.Text = "30";
            // 
            // BtnSet
            // 
            this.BtnSet.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSet.Location = new System.Drawing.Point(112, 69);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(75, 32);
            this.BtnSet.TabIndex = 2;
            this.BtnSet.Text = "设置";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BoxSetList
            // 
            this.BoxSetList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BoxSetList.FormattingEnabled = true;
            this.BoxSetList.Items.AddRange(new object[] {
            "开火温度",
            "跳档值",
            "档位回退时间",
            "开火温度稳定时间"});
            this.BoxSetList.Location = new System.Drawing.Point(8, 28);
            this.BoxSetList.Name = "BoxSetList";
            this.BoxSetList.Size = new System.Drawing.Size(165, 27);
            this.BoxSetList.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "设置项：";
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
            // BatteryDetectDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BatteryDetectDebug";
            this.Text = "BatteryDetectDebug";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelRefADC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelFire1;
        private System.Windows.Forms.CheckBox CheckBoxOpenFire;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelFire2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LabelReceivedCnt;
        private System.Windows.Forms.ComboBox BoxReadList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox EditSetData;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.ComboBox BoxSetList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelSpeedVavle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelTempFire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelTempFireStable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelSpeedBackTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}

