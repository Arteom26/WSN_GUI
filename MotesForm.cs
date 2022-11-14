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
        public bool isAutoScaling = true;// By default autoscale
        public MotesForm()
        {
            InitializeComponent();
            chart1.Series.Remove(chart1.Series[0]);
            chart1.Titles.Add("Data vs. Time");
           
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Value";
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            listBoxBlackWhiteListed.Items.Clear();
            comboBoxAutoScale.SelectedIndex = 0;
        }

        // Update the name of a graphed series
        private void updateNameButton_Click(object sender, EventArgs e)
        {
            string series = CBoxPlotList.Text;
            string label = textBoxNewName.Text;
            chart1.Series[series].LegendText = label;// Update the legend label
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (radioButtonBlacklist.Checked)// Blacklist mode
            {
                if (listBoxMotes.SelectedIndex == -1)// Error checking
                    return;

                string mac = listBoxMotes.Items[listBoxMotes.SelectedIndex].ToString();
                if (listBoxBlackWhiteListed.Items.Contains(mac) == true)// Was already blacklisted
                    return;

                listBoxBlackWhiteListed.Items.Add(mac);

                // Run the actual blacklisting procedure
                chart1.Series[mac].Enabled = false;
            }
            else// Whitelisting mode
            {
                if (listBoxMotes.SelectedIndex == -1)// Error checking
                    return;

                string mac = listBoxMotes.Items[listBoxMotes.SelectedIndex].ToString();
                if (listBoxBlackWhiteListed.Items.Contains(mac) == true)// Was already blacklisted
                    return;

                listBoxBlackWhiteListed.Items.Add(mac);

                // Run the actual whitelisting procedure
                chart1.Series[mac].Enabled = true;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (radioButtonBlacklist.Checked)// Blacklist mode
            {
                if (listBoxMotes.SelectedIndex == -1)// Error checking
                    return;

                string mac = listBoxMotes.Items[listBoxMotes.SelectedIndex].ToString();
                if (listBoxBlackWhiteListed.Items.Contains(mac) == false)// Was never blacklisted
                    return;

                listBoxBlackWhiteListed.Items.Remove(mac);

                // Run the actual blacklisting procedure
                chart1.Series[mac].Enabled = true;
            }
            else// Whitelisting mode
            {
                if (listBoxMotes.SelectedIndex == -1)// Error checking
                    return;

                string mac = listBoxMotes.Items[listBoxMotes.SelectedIndex].ToString();
                if (listBoxBlackWhiteListed.Items.Contains(mac) == false)// Was already blacklisted
                    return;

                listBoxBlackWhiteListed.Items.Remove(mac);

                // Run the actual blacklisting procedure
                chart1.Series[mac].Enabled = false;
            }
        }

        private void radioButtonWhitelist_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlacklist.Checked)
            {
                groupBoxLising.Text = "Blacklisting Options";
                labelListing.Text = "Curretly Blacklisted Motes";
                listBoxBlackWhiteListed.Items.Clear();// Clear all items

                // Enable all curves by default
                for(int i = 0;i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = true;
                }
            } 
            else if (radioButtonWhitelist.Checked)
            {
                groupBoxLising.Text = "Whitelisting Options";
                labelListing.Text = "Curretly Whitelisted Motes";
                listBoxBlackWhiteListed.Items.Clear();// Clear all items

                // Disable all curves by default
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                }
            }
        }
    }
}
