
namespace SMIP_Network
{
    partial class MainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.charLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CBoxMoteList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.moteInfoButton = new System.Windows.Forms.Button();
            this.avgLatencyLabel = new System.Windows.Forms.Label();
            this.packetsLostLabel = new System.Windows.Forms.Label();
            this.packetsRecievedLabel = new System.Windows.Forms.Label();
            this.moteMacAddrLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxPrivKey = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.motesConnLabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.netidLabel = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txPowerLabel = new System.Windows.Forms.Label();
            this.IPV6Label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM12";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.comPortComboBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.CBoxBaudRate);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(627, 655);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(269, 48);
            this.comPortComboBox.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(305, 45);
            this.comPortComboBox.TabIndex = 0;
            this.comPortComboBox.Text = "COM5";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.DarkRed;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.Transparent;
            this.connectButton.Location = new System.Drawing.Point(25, 458);
            this.connectButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(557, 162);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(263, 367);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(305, 45);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(269, 279);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(305, 45);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(269, 211);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(305, 45);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(269, 134);
            this.CBoxBaudRate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(305, 45);
            this.CBoxBaudRate.TabIndex = 1;
            this.CBoxBaudRate.Text = "115200";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1811, 2502);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1054, 43);
            this.progressBar1.TabIndex = 55;
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(317, 68);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(113, 59);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(174, 45);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(259, 48);
            this.toolStripStatusLabel1.Text = "No Connection";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 2545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 38, 0);
            this.statusStrip1.Size = new System.Drawing.Size(3322, 63);
            this.statusStrip1.TabIndex = 59;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(22, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(3322, 65);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 59);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(348, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(475, 122);
            this.button1.TabIndex = 64;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.charLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(662, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Size = new System.Drawing.Size(874, 635);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manager Setup";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(348, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(466, 62);
            this.textBox2.TabIndex = 71;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(348, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 62);
            this.textBox1.TabIndex = 70;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLabel.Location = new System.Drawing.Point(339, 236);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(257, 42);
            this.charLabel.TabIndex = 69;
            this.charLabel.Text = "32 Characters Left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 65);
            this.label8.TabIndex = 68;
            this.label8.Text = "Join Key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 65);
            this.label7.TabIndex = 67;
            this.label7.Text = "Network ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CBoxMoteList);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(16, 754);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 683);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mote Controls";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(51, 455);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(614, 162);
            this.button3.TabIndex = 74;
            this.button3.Text = "Clear List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 65);
            this.label9.TabIndex = 72;
            this.label9.Text = "Mote List: ";
            // 
            // CBoxMoteList
            // 
            this.CBoxMoteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMoteList.FormattingEnabled = true;
            this.CBoxMoteList.Location = new System.Drawing.Point(332, 97);
            this.CBoxMoteList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CBoxMoteList.Name = "CBoxMoteList";
            this.CBoxMoteList.Size = new System.Drawing.Size(390, 63);
            this.CBoxMoteList.Sorted = true;
            this.CBoxMoteList.TabIndex = 73;
            this.CBoxMoteList.SelectedIndexChanged += new System.EventHandler(this.CBoxMoteList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(51, 259);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(614, 162);
            this.button2.TabIndex = 72;
            this.button2.Text = "Get Mote List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Controls.Add(this.moteInfoButton);
            this.groupBox4.Controls.Add(this.avgLatencyLabel);
            this.groupBox4.Controls.Add(this.packetsLostLabel);
            this.groupBox4.Controls.Add(this.packetsRecievedLabel);
            this.groupBox4.Controls.Add(this.moteMacAddrLabel);
            this.groupBox4.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(760, 754);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1115, 683);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mote Details";
            // 
            // moteInfoButton
            // 
            this.moteInfoButton.BackColor = System.Drawing.Color.DarkRed;
            this.moteInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moteInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moteInfoButton.ForeColor = System.Drawing.Color.Transparent;
            this.moteInfoButton.Location = new System.Drawing.Point(44, 501);
            this.moteInfoButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.moteInfoButton.Name = "moteInfoButton";
            this.moteInfoButton.Size = new System.Drawing.Size(614, 125);
            this.moteInfoButton.TabIndex = 75;
            this.moteInfoButton.Text = "Get Mote Info";
            this.moteInfoButton.UseVisualStyleBackColor = false;
            this.moteInfoButton.Click += new System.EventHandler(this.moteInfoButton_Click);
            // 
            // avgLatencyLabel
            // 
            this.avgLatencyLabel.AutoSize = true;
            this.avgLatencyLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLatencyLabel.Location = new System.Drawing.Point(32, 433);
            this.avgLatencyLabel.Name = "avgLatencyLabel";
            this.avgLatencyLabel.Size = new System.Drawing.Size(367, 65);
            this.avgLatencyLabel.TabIndex = 78;
            this.avgLatencyLabel.Text = "Avg Latency: ";
            // 
            // packetsLostLabel
            // 
            this.packetsLostLabel.AutoSize = true;
            this.packetsLostLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetsLostLabel.Location = new System.Drawing.Point(32, 339);
            this.packetsLostLabel.Name = "packetsLostLabel";
            this.packetsLostLabel.Size = new System.Drawing.Size(381, 65);
            this.packetsLostLabel.TabIndex = 77;
            this.packetsLostLabel.Text = "Packets Lost: ";
            // 
            // packetsRecievedLabel
            // 
            this.packetsRecievedLabel.AutoSize = true;
            this.packetsRecievedLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetsRecievedLabel.Location = new System.Drawing.Point(32, 239);
            this.packetsRecievedLabel.Name = "packetsRecievedLabel";
            this.packetsRecievedLabel.Size = new System.Drawing.Size(509, 65);
            this.packetsRecievedLabel.TabIndex = 76;
            this.packetsRecievedLabel.Text = "Packets Recieved: ";
            // 
            // moteMacAddrLabel
            // 
            this.moteMacAddrLabel.AutoSize = true;
            this.moteMacAddrLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moteMacAddrLabel.Location = new System.Drawing.Point(32, 137);
            this.moteMacAddrLabel.Name = "moteMacAddrLabel";
            this.moteMacAddrLabel.Size = new System.Drawing.Size(402, 65);
            this.moteMacAddrLabel.TabIndex = 75;
            this.moteMacAddrLabel.Text = "MAC Address: ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(1887, 754);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1431, 680);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Single Mote Setup";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(497, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(926, 62);
            this.textBox3.TabIndex = 72;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Graph 1",
            "Graph 2",
            "Graph 3",
            "Graph 4",
            "Graph 5",
            "Graph 6"});
            this.comboBox1.Location = new System.Drawing.Point(497, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(926, 63);
            this.comboBox1.TabIndex = 74;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(497, 273);
            this.button4.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(614, 162);
            this.button4.TabIndex = 72;
            this.button4.Text = "Update Graphs";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(32, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(431, 65);
            this.label18.TabIndex = 73;
            this.label18.Text = "Name of Series:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(465, 65);
            this.label17.TabIndex = 72;
            this.label17.Text = "Graph to Plot On:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox6.Controls.Add(this.textBoxURL);
            this.groupBox6.Controls.Add(this.textBoxPrivKey);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(1548, 105);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1770, 635);
            this.groupBox6.TabIndex = 75;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Blockchain Setup";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURL.Location = new System.Drawing.Point(358, 80);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(1334, 62);
            this.textBoxURL.TabIndex = 74;
            // 
            // textBoxPrivKey
            // 
            this.textBoxPrivKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrivKey.Location = new System.Drawing.Point(358, 191);
            this.textBoxPrivKey.Name = "textBoxPrivKey";
            this.textBoxPrivKey.Size = new System.Drawing.Size(1334, 62);
            this.textBoxPrivKey.TabIndex = 72;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(358, 276);
            this.button5.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(614, 162);
            this.button5.TabIndex = 72;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 202);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(331, 65);
            this.label19.TabIndex = 73;
            this.label19.Text = "Private Key:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(203, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 65);
            this.label20.TabIndex = 72;
            this.label20.Text = "URL:";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox7.Controls.Add(this.motesConnLabel);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.netidLabel);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Controls.Add(this.txPowerLabel);
            this.groupBox7.Controls.Add(this.IPV6Label);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(16, 1469);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(3306, 578);
            this.groupBox7.TabIndex = 76;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Network Manager Details";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // motesConnLabel
            // 
            this.motesConnLabel.AutoSize = true;
            this.motesConnLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motesConnLabel.Location = new System.Drawing.Point(1374, 316);
            this.motesConnLabel.Name = "motesConnLabel";
            this.motesConnLabel.Size = new System.Drawing.Size(483, 65);
            this.motesConnLabel.TabIndex = 82;
            this.motesConnLabel.Text = "Motes Connected:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkRed;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(54, 316);
            this.button7.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(614, 162);
            this.button7.TabIndex = 76;
            this.button7.Text = "Check Connection";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // netidLabel
            // 
            this.netidLabel.AutoSize = true;
            this.netidLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netidLabel.Location = new System.Drawing.Point(1555, 128);
            this.netidLabel.Name = "netidLabel";
            this.netidLabel.Size = new System.Drawing.Size(319, 65);
            this.netidLabel.TabIndex = 81;
            this.netidLabel.Text = "Network ID:";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkRed;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(54, 128);
            this.button8.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(614, 162);
            this.button8.TabIndex = 75;
            this.button8.Text = "Reset Stats";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txPowerLabel
            // 
            this.txPowerLabel.AutoSize = true;
            this.txPowerLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPowerLabel.Location = new System.Drawing.Point(1583, 228);
            this.txPowerLabel.Name = "txPowerLabel";
            this.txPowerLabel.Size = new System.Drawing.Size(289, 65);
            this.txPowerLabel.TabIndex = 80;
            this.txPowerLabel.Text = "TX Power:";
            // 
            // IPV6Label
            // 
            this.IPV6Label.AutoSize = true;
            this.IPV6Label.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPV6Label.Location = new System.Drawing.Point(1704, 416);
            this.IPV6Label.Name = "IPV6Label";
            this.IPV6Label.Size = new System.Drawing.Size(164, 65);
            this.IPV6Label.TabIndex = 79;
            this.IPV6Label.Text = "IPV6:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(747, 128);
            this.button6.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(614, 350);
            this.button6.TabIndex = 75;
            this.button6.Text = "Get Current Network Manager Settings\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2793, 1594);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBoxMoteList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label avgLatencyLabel;
        private System.Windows.Forms.Label packetsLostLabel;
        private System.Windows.Forms.Label packetsRecievedLabel;
        private System.Windows.Forms.Label moteMacAddrLabel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxPrivKey;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label netidLabel;
        private System.Windows.Forms.Label txPowerLabel;
        private System.Windows.Forms.Label IPV6Label;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label motesConnLabel;
        private System.Windows.Forms.Button moteInfoButton;
    }
}