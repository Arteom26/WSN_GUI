
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.moteInfoButton = new System.Windows.Forms.Button();
            this.moteMacAddrLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxMoteList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(13, 11);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(2407, 1543);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title10.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.Name = "Data Vs. Time";
            this.chart1.Titles.Add(title10);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.CBoxMoteList);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.moteInfoButton);
            this.groupBox4.Controls.Add(this.moteMacAddrLabel);
            this.groupBox4.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(2426, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(833, 890);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plot Setup";
            // 
            // moteInfoButton
            // 
            this.moteInfoButton.BackColor = System.Drawing.Color.DarkRed;
            this.moteInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moteInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moteInfoButton.ForeColor = System.Drawing.Color.Transparent;
            this.moteInfoButton.Location = new System.Drawing.Point(104, 321);
            this.moteInfoButton.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.moteInfoButton.Name = "moteInfoButton";
            this.moteInfoButton.Size = new System.Drawing.Size(614, 125);
            this.moteInfoButton.TabIndex = 75;
            this.moteInfoButton.Text = "Update Name";
            this.moteInfoButton.UseVisualStyleBackColor = false;
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
            // CBoxMoteList
            // 
            this.CBoxMoteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMoteList.FormattingEnabled = true;
            this.CBoxMoteList.Location = new System.Drawing.Point(202, 153);
            this.CBoxMoteList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CBoxMoteList.Name = "CBoxMoteList";
            this.CBoxMoteList.Size = new System.Drawing.Size(591, 63);
            this.CBoxMoteList.Sorted = true;
            this.CBoxMoteList.TabIndex = 77;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(327, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 62);
            this.textBox1.TabIndex = 79;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(457, 562);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(295, 69);
            this.radioButton1.TabIndex = 81;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BlackList";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(61, 562);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(307, 69);
            this.radioButton2.TabIndex = 82;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "WhiteList";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // MotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3262, 1725);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chart1);
            this.Name = "MotesForm";
            this.Text = "MotesForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button moteInfoButton;
        private System.Windows.Forms.Label moteMacAddrLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxMoteList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}