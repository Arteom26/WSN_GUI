using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMIP_Network
{
    public partial class MotesForm : Form
    {
        public MotesForm()
        {
            InitializeComponent();
            chart1.Series.Remove(chart1.Series[0]);
            chart1.Titles.Add("Data vs. Time");
           
            chart1.ChartAreas[0].AxisX.Title = "Number of Points";
            chart1.ChartAreas[0].AxisY.Title = "Value";
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;

            //chart1.Series.Add("00000000");
            //chart1.Series["00000000"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            //chart1.Series["00000000"].Points.AddXY(0, 0);
            //chart1.Series["00000000"].Points.AddXY(1, 3);
        }
    }
}
