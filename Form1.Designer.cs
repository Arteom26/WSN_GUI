
namespace SMIP_Network
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelmainPage = new System.Windows.Forms.Panel();
            this.Help_btn = new FontAwesome.Sharp.IconButton();
            this.Setting_buttun = new FontAwesome.Sharp.IconButton();
            this.Configar_Btn = new FontAwesome.Sharp.IconButton();
            this.Statistics_Btn = new FontAwesome.Sharp.IconButton();
            this.Mote_BTN = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HuskLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.MaximBtn = new FontAwesome.Sharp.IconButton();
            this.MinBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelmainPage.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HuskLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmainPage
            // 
            this.panelmainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.panelmainPage.Controls.Add(this.Help_btn);
            this.panelmainPage.Controls.Add(this.Setting_buttun);
            this.panelmainPage.Controls.Add(this.Configar_Btn);
            this.panelmainPage.Controls.Add(this.Statistics_Btn);
            this.panelmainPage.Controls.Add(this.Mote_BTN);
            this.panelmainPage.Controls.Add(this.Home);
            this.panelmainPage.Controls.Add(this.panelLogo);
            this.panelmainPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmainPage.Location = new System.Drawing.Point(0, 0);
            this.panelmainPage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panelmainPage.Name = "panelmainPage";
            this.panelmainPage.Size = new System.Drawing.Size(488, 1887);
            this.panelmainPage.TabIndex = 0;
            // 
            // Help_btn
            // 
            this.Help_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help_btn.FlatAppearance.BorderSize = 0;
            this.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Help_btn.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.Help_btn.IconColor = System.Drawing.Color.White;
            this.Help_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Help_btn.IconSize = 30;
            this.Help_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_btn.Location = new System.Drawing.Point(0, 1070);
            this.Help_btn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Padding = new System.Windows.Forms.Padding(32, 0, 63, 0);
            this.Help_btn.Size = new System.Drawing.Size(488, 157);
            this.Help_btn.TabIndex = 6;
            this.Help_btn.Text = "Help";
            this.Help_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Help_btn.UseVisualStyleBackColor = true;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // Setting_buttun
            // 
            this.Setting_buttun.Dock = System.Windows.Forms.DockStyle.Top;
            this.Setting_buttun.FlatAppearance.BorderSize = 0;
            this.Setting_buttun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_buttun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_buttun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Setting_buttun.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.Setting_buttun.IconColor = System.Drawing.Color.White;
            this.Setting_buttun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Setting_buttun.IconSize = 30;
            this.Setting_buttun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting_buttun.Location = new System.Drawing.Point(0, 913);
            this.Setting_buttun.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Setting_buttun.Name = "Setting_buttun";
            this.Setting_buttun.Padding = new System.Windows.Forms.Padding(32, 0, 63, 0);
            this.Setting_buttun.Size = new System.Drawing.Size(488, 157);
            this.Setting_buttun.TabIndex = 5;
            this.Setting_buttun.Text = "Settings";
            this.Setting_buttun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting_buttun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Setting_buttun.UseVisualStyleBackColor = true;
            this.Setting_buttun.Click += new System.EventHandler(this.Setting_buttun_Click);
            // 
            // Configar_Btn
            // 
            this.Configar_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Configar_Btn.FlatAppearance.BorderSize = 0;
            this.Configar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Configar_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configar_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Configar_Btn.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.Configar_Btn.IconColor = System.Drawing.Color.White;
            this.Configar_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Configar_Btn.IconSize = 30;
            this.Configar_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configar_Btn.Location = new System.Drawing.Point(0, 756);
            this.Configar_Btn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Configar_Btn.Name = "Configar_Btn";
            this.Configar_Btn.Padding = new System.Windows.Forms.Padding(32, 0, 63, 0);
            this.Configar_Btn.Size = new System.Drawing.Size(488, 157);
            this.Configar_Btn.TabIndex = 4;
            this.Configar_Btn.Text = "Wireless Monitor";
            this.Configar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Configar_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Configar_Btn.UseVisualStyleBackColor = true;
            this.Configar_Btn.Click += new System.EventHandler(this.Configar_Btn_Click);
            // 
            // Statistics_Btn
            // 
            this.Statistics_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_Btn.FlatAppearance.BorderSize = 0;
            this.Statistics_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Statistics_Btn.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.Statistics_Btn.IconColor = System.Drawing.Color.White;
            this.Statistics_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Statistics_Btn.IconSize = 30;
            this.Statistics_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics_Btn.Location = new System.Drawing.Point(0, 599);
            this.Statistics_Btn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Statistics_Btn.Name = "Statistics_Btn";
            this.Statistics_Btn.Padding = new System.Windows.Forms.Padding(32, 0, 63, 0);
            this.Statistics_Btn.Size = new System.Drawing.Size(488, 157);
            this.Statistics_Btn.TabIndex = 3;
            this.Statistics_Btn.Text = "Wireless Setup";
            this.Statistics_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Statistics_Btn.UseVisualStyleBackColor = true;
            this.Statistics_Btn.Click += new System.EventHandler(this.Statistics_Btn_Click);
            // 
            // Mote_BTN
            // 
            this.Mote_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mote_BTN.FlatAppearance.BorderSize = 0;
            this.Mote_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mote_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mote_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mote_BTN.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.Mote_BTN.IconColor = System.Drawing.Color.White;
            this.Mote_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mote_BTN.IconSize = 30;
            this.Mote_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mote_BTN.Location = new System.Drawing.Point(0, 442);
            this.Mote_BTN.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Mote_BTN.Name = "Mote_BTN";
            this.Mote_BTN.Padding = new System.Windows.Forms.Padding(32, 0, 63, 0);
            this.Mote_BTN.Size = new System.Drawing.Size(488, 157);
            this.Mote_BTN.TabIndex = 2;
            this.Mote_BTN.Text = "Bluetooth Data";
            this.Mote_BTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mote_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Mote_BTN.UseVisualStyleBackColor = true;
            this.Mote_BTN.Click += new System.EventHandler(this.Mote_BTN_Click);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.White;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 30;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 285);
            this.Home.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(32, 0, 63, 0);
            this.Home.Size = new System.Drawing.Size(488, 157);
            this.Home.TabIndex = 1;
            this.Home.Text = "Setup";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.HuskLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(488, 285);
            this.panelLogo.TabIndex = 0;
            // 
            // HuskLogo
            // 
            this.HuskLogo.Image = global::SMIP_Network.Properties.Resources._1200px_St__Cloud_State_Huskies_logo_svg;
            this.HuskLogo.Location = new System.Drawing.Point(0, 9);
            this.HuskLogo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.HuskLogo.Name = "HuskLogo";
            this.HuskLogo.Size = new System.Drawing.Size(477, 268);
            this.HuskLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HuskLogo.TabIndex = 0;
            this.HuskLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.panelTop.Controls.Add(this.MaximBtn);
            this.panelTop.Controls.Add(this.MinBtn);
            this.panelTop.Controls.Add(this.CloseBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(488, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(3356, 176);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // MaximBtn
            // 
            this.MaximBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaximBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaximBtn.FlatAppearance.BorderSize = 0;
            this.MaximBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MaximBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximBtn.IconColor = System.Drawing.Color.White;
            this.MaximBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximBtn.IconSize = 35;
            this.MaximBtn.Location = new System.Drawing.Point(3002, 26);
            this.MaximBtn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximBtn.Name = "MaximBtn";
            this.MaximBtn.Size = new System.Drawing.Size(148, 126);
            this.MaximBtn.TabIndex = 2;
            this.MaximBtn.Text = "□";
            this.MaximBtn.UseVisualStyleBackColor = false;
            this.MaximBtn.Click += new System.EventHandler(this.MaximBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MinBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinBtn.IconColor = System.Drawing.Color.White;
            this.MinBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinBtn.IconSize = 35;
            this.MinBtn.Location = new System.Drawing.Point(2833, 26);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(148, 126);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 35;
            this.CloseBtn.Location = new System.Drawing.Point(3169, 26);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(148, 126);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.panelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelshadow.Location = new System.Drawing.Point(488, 176);
            this.panelshadow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(3356, 41);
            this.panelshadow.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(488, 217);
            this.panelMain.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(3356, 1670);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1887);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelmainPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "SMARTMESH IP SENSOR NETWORK";
            this.panelmainPage.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HuskLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmainPage;
        private FontAwesome.Sharp.IconButton Help_btn;
        private FontAwesome.Sharp.IconButton Setting_buttun;
        private FontAwesome.Sharp.IconButton Configar_Btn;
        private FontAwesome.Sharp.IconButton Statistics_Btn;
        private FontAwesome.Sharp.IconButton Mote_BTN;
        private FontAwesome.Sharp.IconButton Home;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox HuskLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconButton MaximBtn;
        private FontAwesome.Sharp.IconButton MinBtn;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

