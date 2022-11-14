
namespace SMIP_Network
{
    partial class MotesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonWhitelist = new System.Windows.Forms.RadioButton();
            this.radioButtonBlacklist = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxPlotList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateNameButton = new System.Windows.Forms.Button();
            this.moteMacAddrLabel = new System.Windows.Forms.Label();
            this.groupBoxLising = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxMotes = new System.Windows.Forms.ListBox();
            this.listBoxBlackWhiteListed = new System.Windows.Forms.ListBox();
            this.labelListing = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autoScaleButton = new System.Windows.Forms.Button();
            this.comboBoxAutoScale = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.manualScaleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBoxLising.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(2407, 1543);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Data Vs. Time";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Controls.Add(this.radioButtonWhitelist);
            this.groupBox4.Controls.Add(this.radioButtonBlacklist);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxNewName);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.CBoxPlotList);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.updateNameButton);
            this.groupBox4.Controls.Add(this.moteMacAddrLabel);
            this.groupBox4.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(2426, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(833, 662);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plot Setup";
            // 
            // radioButtonWhitelist
            // 
            this.radioButtonWhitelist.AutoSize = true;
            this.radioButtonWhitelist.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWhitelist.Location = new System.Drawing.Point(61, 562);
            this.radioButtonWhitelist.Name = "radioButtonWhitelist";
            this.radioButtonWhitelist.Size = new System.Drawing.Size(307, 69);
            this.radioButtonWhitelist.TabIndex = 82;
            this.radioButtonWhitelist.Text = "WhiteList";
            this.radioButtonWhitelist.UseVisualStyleBackColor = true;
            this.radioButtonWhitelist.CheckedChanged += new System.EventHandler(this.radioButtonWhitelist_CheckedChanged);
            // 
            // radioButtonBlacklist
            // 
            this.radioButtonBlacklist.AutoSize = true;
            this.radioButtonBlacklist.Checked = true;
            this.radioButtonBlacklist.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlacklist.Location = new System.Drawing.Point(457, 562);
            this.radioButtonBlacklist.Name = "radioButtonBlacklist";
            this.radioButtonBlacklist.Size = new System.Drawing.Size(295, 69);
            this.radioButtonBlacklist.TabIndex = 81;
            this.radioButtonBlacklist.TabStop = true;
            this.radioButtonBlacklist.Text = "BlackList";
            this.radioButtonBlacklist.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(652, 65);
            this.label3.TabIndex = 80;
            this.label3.Text = "WhiteListing/BlackListing";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(327, 231);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(466, 62);
            this.textBoxNewName.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 65);
            this.label2.TabIndex = 78;
            this.label2.Text = "New Name: ";
            // 
            // CBoxPlotList
            // 
            this.CBoxPlotList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxPlotList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxPlotList.FormattingEnabled = true;
            this.CBoxPlotList.Location = new System.Drawing.Point(202, 153);
            this.CBoxPlotList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CBoxPlotList.Name = "CBoxPlotList";
            this.CBoxPlotList.Size = new System.Drawing.Size(591, 63);
            this.CBoxPlotList.Sorted = true;
            this.CBoxPlotList.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 65);
            this.label1.TabIndex = 76;
            this.label1.Text = "Plot: ";
            // 
            // updateNameButton
            // 
            this.updateNameButton.BackColor = System.Drawing.Color.DarkRed;
            this.updateNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNameButton.ForeColor = System.Drawing.Color.Transparent;
            this.updateNameButton.Location = new System.Drawing.Point(104, 321);
            this.updateNameButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.updateNameButton.Name = "updateNameButton";
            this.updateNameButton.Size = new System.Drawing.Size(614, 125);
            this.updateNameButton.TabIndex = 75;
            this.updateNameButton.Text = "Update Name";
            this.updateNameButton.UseVisualStyleBackColor = false;
            this.updateNameButton.Click += new System.EventHandler(this.updateNameButton_Click);
            // 
            // moteMacAddrLabel
            // 
            this.moteMacAddrLabel.AutoSize = true;
            this.moteMacAddrLabel.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moteMacAddrLabel.Location = new System.Drawing.Point(191, 75);
            this.moteMacAddrLabel.Name = "moteMacAddrLabel";
            this.moteMacAddrLabel.Size = new System.Drawing.Size(465, 65);
            this.moteMacAddrLabel.TabIndex = 75;
            this.moteMacAddrLabel.Text = "Edit Series Name";
            // 
            // groupBoxLising
            // 
            this.groupBoxLising.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxLising.Controls.Add(this.labelListing);
            this.groupBoxLising.Controls.Add(this.listBoxBlackWhiteListed);
            this.groupBoxLising.Controls.Add(this.listBoxMotes);
            this.groupBoxLising.Controls.Add(this.removeButton);
            this.groupBoxLising.Controls.Add(this.addButton);
            this.groupBoxLising.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLising.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxLising.Location = new System.Drawing.Point(2426, 679);
            this.groupBoxLising.Name = "groupBoxLising";
            this.groupBoxLising.Size = new System.Drawing.Size(833, 616);
            this.groupBoxLising.TabIndex = 83;
            this.groupBoxLising.TabStop = false;
            this.groupBoxLising.Text = "Blacklisting Options";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkRed;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(26, 236);
            this.addButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(376, 125);
            this.addButton.TabIndex = 83;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DarkRed;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.Transparent;
            this.removeButton.Location = new System.Drawing.Point(444, 236);
            this.removeButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(376, 125);
            this.removeButton.TabIndex = 84;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.manualScaleButton);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxAutoScale);
            this.groupBox2.Controls.Add(this.autoScaleButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(2426, 1301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 733);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scaling Options";
            // 
            // listBoxMotes
            // 
            this.listBoxMotes.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMotes.FormattingEnabled = true;
            this.listBoxMotes.ItemHeight = 68;
            this.listBoxMotes.Location = new System.Drawing.Point(26, 87);
            this.listBoxMotes.Name = "listBoxMotes";
            this.listBoxMotes.Size = new System.Drawing.Size(801, 140);
            this.listBoxMotes.TabIndex = 85;
            // 
            // listBoxBlackWhiteListed
            // 
            this.listBoxBlackWhiteListed.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBlackWhiteListed.FormattingEnabled = true;
            this.listBoxBlackWhiteListed.ItemHeight = 68;
            this.listBoxBlackWhiteListed.Items.AddRange(new object[] {
            ""});
            this.listBoxBlackWhiteListed.Location = new System.Drawing.Point(26, 446);
            this.listBoxBlackWhiteListed.Name = "listBoxBlackWhiteListed";
            this.listBoxBlackWhiteListed.Size = new System.Drawing.Size(801, 140);
            this.listBoxBlackWhiteListed.TabIndex = 86;
            // 
            // labelListing
            // 
            this.labelListing.AutoSize = true;
            this.labelListing.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListing.Location = new System.Drawing.Point(50, 367);
            this.labelListing.Name = "labelListing";
            this.labelListing.Size = new System.Drawing.Size(703, 65);
            this.labelListing.TabIndex = 83;
            this.labelListing.Text = "Currently Blacklisted Motes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 65);
            this.label5.TabIndex = 87;
            this.label5.Text = "Auto Scaling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 65);
            this.label4.TabIndex = 88;
            this.label4.Text = "Manual Scaling";
            // 
            // autoScaleButton
            // 
            this.autoScaleButton.BackColor = System.Drawing.Color.DarkRed;
            this.autoScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoScaleButton.ForeColor = System.Drawing.Color.Transparent;
            this.autoScaleButton.Location = new System.Drawing.Point(517, 172);
            this.autoScaleButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.autoScaleButton.Name = "autoScaleButton";
            this.autoScaleButton.Size = new System.Drawing.Size(297, 125);
            this.autoScaleButton.TabIndex = 87;
            this.autoScaleButton.Text = "Scale";
            this.autoScaleButton.UseVisualStyleBackColor = false;
            // 
            // comboBoxAutoScale
            // 
            this.comboBoxAutoScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutoScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAutoScale.FormattingEnabled = true;
            this.comboBoxAutoScale.Items.AddRange(new object[] {
            "Full Scale",
            "Last 30 seconds",
            "Last day",
            "Last hour",
            "Last minute"});
            this.comboBoxAutoScale.Location = new System.Drawing.Point(26, 199);
            this.comboBoxAutoScale.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.comboBoxAutoScale.Name = "comboBoxAutoScale";
            this.comboBoxAutoScale.Size = new System.Drawing.Size(461, 63);
            this.comboBoxAutoScale.Sorted = true;
            this.comboBoxAutoScale.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 65);
            this.label6.TabIndex = 89;
            this.label6.Text = "From: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 65);
            this.label7.TabIndex = 90;
            this.label7.Text = "To: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(619, 62);
            this.textBox1.TabIndex = 83;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(201, 508);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(619, 62);
            this.textBox2.TabIndex = 91;
            // 
            // manualScaleButton
            // 
            this.manualScaleButton.BackColor = System.Drawing.Color.DarkRed;
            this.manualScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualScaleButton.ForeColor = System.Drawing.Color.Transparent;
            this.manualScaleButton.Location = new System.Drawing.Point(265, 599);
            this.manualScaleButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.manualScaleButton.Name = "manualScaleButton";
            this.manualScaleButton.Size = new System.Drawing.Size(297, 125);
            this.manualScaleButton.TabIndex = 92;
            this.manualScaleButton.Text = "Scale";
            this.manualScaleButton.UseVisualStyleBackColor = false;
            // 
            // MotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(3262, 1725);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLising);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chart1);
            this.Name = "MotesForm";
            this.Text = "MotesForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxLising.ResumeLayout(false);
            this.groupBoxLising.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button updateNameButton;
        private System.Windows.Forms.Label moteMacAddrLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonWhitelist;
        private System.Windows.Forms.RadioButton radioButtonBlacklist;
        public System.Windows.Forms.ComboBox CBoxPlotList;
        private System.Windows.Forms.GroupBox groupBoxLising;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelListing;
        private System.Windows.Forms.ListBox listBoxBlackWhiteListed;
        public System.Windows.Forms.ListBox listBoxMotes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxAutoScale;
        private System.Windows.Forms.Button autoScaleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button manualScaleButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}