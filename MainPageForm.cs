using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using myLibrary;
using Newtonsoft.Json;

namespace SMIP_Network
{
    public partial class MainPageForm : Form
    {
        Form1 objForm1;
        string sendWith;
        string dataIN;
        int dataINLength;
        int[] dataInDec;


        string sensorDisplay = "";
        


        Universal Universal = new Universal();
        DateTime time = new DateTime();

        string CurrentTime = DateTime.Now.ToString("MM/dd/yyyy") + " - " + DateTime.Now.ToString("h:mm:ss tt");


        #region setting up Database 

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            // AuthSecret = "kmXvR4OR4MMqzWZPG9qpvJJIzkIWcaUW9vNhmChR",
            BasePath = "https://smartmesh-ip-sensornetwork-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        #endregion



        public MainPageForm(Form1 obj)
        {
            InitializeComponent();
            objForm1 = obj;
            string[] ports = SerialPort.GetPortNames();
            comPortComboBox.Items.AddRange(ports);
            //chart1.Titles.Add("Mass-density (µg/m³) Air");
            //chart2.Titles.Add("Particle count (μm) ");

            //chart3.Titles.Add("CO2 (PPM)");

            //chart4.Titles.Add("AirQuality Sensors (PPM) ");

        }

        public static byte[] StringToByteArray(string hex)
        {
            byte[] temp = new byte[hex.Length / 2];
            for(int i = 0,h = 0; h < hex.Length; i++, h += 2)
            {
                temp[i] = (byte)Int32.Parse(hex.Substring(h,2),System.Globalization.NumberStyles.HexNumber);
            }
            return temp;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)


            {
                closeButtonAutomaticClick();

                connectButton.BackColor = Color.ForestGreen;


            }
              
            else

            {
                connectButtonAutomaticClick();
                connectButton.BackColor = Color.Red;

            }
               

        }

        public void closeButtonAutomaticClick()
        {
            serialPort1.Close();
            connectButton.Text = "Connect";
            toolStripStatusLabel1.Text = "Disconnected";
            toolStripStatusLabel1.ForeColor = Color.Empty;
            toolStripProgressBar1.Value = 0;
        }



        public void connectButtonAutomaticClick()
        {
            try
            {
                serialPort1.PortName = comPortComboBox.Text;
                Universal.portType = serialPort1.PortName.Replace("COM", "");
                Universal.portTypeInt = Convert.ToInt32(Universal.portType);

                Universal.portType = "API";
                serialPort1.BaudRate = 115200;
                serialPort1.DtrEnable = false;

                serialPort1.Open();


                connectButton.Text = "Close";
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

                toolStripStatusLabel1.Text = Universal.portType + " Port Connected";
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripProgressBar1.Value = 100;

                //this.Invoke(new EventHandler(LiveUPDATE));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                toolStripStatusLabel1.Text = "ERROR";
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripProgressBar1.Value = 0;
            }

        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen) { 
            //CBoxBaudRate.Text = "115"; //Default Value
            string[] portLists = SerialPort.GetPortNames();
           // cBoxCOMPORT.Items.AddRange(portLists);

            }


            try
            {

                client = new FireSharp.FirebaseClient(fcon);

            }

            catch
            {

                MessageBox.Show("there was problem in the internet.");

            }
        }
        /* NOTE:    Fathi   Sunday 11/14/2021
         *The code below does not save CVS files. all of the code related to saving the data to excel file wore commented out. 
         *                              
         */



        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        { 
            // State machine to read data
            if (serialPort1.BytesToRead > 0)
            {
                char[] buffer = new char[1];
                int count = serialPort1.Read(buffer, 0, 1);

                switch (buffer[0])
                {
                    case 'A':// Network ID was set
                        MessageBox.Show("Network ID was Set!");
                        break;

                    case 'B':// Join Key was set
                        MessageBox.Show("Join Key was Set!");
                        break;

                    case 'C':// Mote list was recieved
                        byte[] curr_mac_addr = new byte[8];
                        serialPort1.Read(buffer, 0, 1);
                        while (buffer[0] == 'D')// Will send 'E' once complete
                        {
                            serialPort1.Read(curr_mac_addr, 0, 8);// Read the mac_addr
                            string temp = Universal.ByteArrayToString(curr_mac_addr);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                CBoxMoteList.Items.Clear();// Remove previous values
                                CBoxMoteList.Items.Add(temp);// Add the mac address
                            }));
                            serialPort1.Read(buffer, 0, 1);
                        }
                        break;

                    case 'F':// Mote Information was recived
                        byte[] information = new byte[8];
                        while (serialPort1.BytesToRead < 8) ;
                        serialPort1.Read(information, 0, 8);// Get the mac address
                        string MacAddr = BitConverter.ToString(information).Replace("-", "");
                        MacAddr = Regex.Replace(MacAddr, ".{2}", "$0:");// Format the string;
                        MacAddr = MacAddr.Remove(MacAddr.Length - 1);
                        this.Invoke(new MethodInvoker(delegate
                        {
                            moteMacAddrLabel.Text = "Mac Address: " + MacAddr;
                        }));
                        byte[] info = new byte[4];
                        while (serialPort1.BytesToRead < 4) ;
                        serialPort1.Read(info, 0, 4);// Get packets
                        this.Invoke(new MethodInvoker(delegate
                        {
                            (info[0], info[1], info[2], info[3]) = (info[3], info[2], info[1], info[0]);
                            packetsRecievedLabel.Text = "Packets Recieved: " + BitConverter.ToUInt32(info, 0).ToString();
                        }));
                        

                        while (serialPort1.BytesToRead < 4) ;
                        serialPort1.Read(info, 0, 4);// Get lost packets
                        (info[0], info[1], info[2], info[3]) = (info[3], info[2], info[1], info[0]);
                        packetsLostLabel.Text = "Packets Lost: " + BitConverter.ToUInt32(info, 0).ToString();

                        while (serialPort1.BytesToRead < 4) ;
                        serialPort1.Read(info, 0, 4);// Get latency
                        (info[0], info[1], info[2], info[3]) = (info[3], info[2], info[1], info[0]);
                        avgLatencyLabel.Text = "Avg Latency: " + BitConverter.ToUInt32(info, 0).ToString();
                        break;

                    case 'G':// URL was set
                        break;

                    case 'H':// Private Key was set
                        break;

                    case 'I':// Mote data was recieved
                        byte[] mac_addr = new byte[8];
                        byte[] data = new byte[8];// Data is currently 8 bytes long
                        while (serialPort1.BytesToRead < 8) ;// Wait for data to come in
                        serialPort1.Read(mac_addr, 0, 8);// Get the mac address
                        string hex = BitConverter.ToString(mac_addr).Replace("-", "");// Get hex string
                        while (serialPort1.BytesToRead < 8) ;
                        serialPort1.Read(data, 0, 8);// Get the data stored
                        string dat = BitConverter.ToString(data).Replace("-", "");
                        if (objForm1.bluetoothData.chart1.Series.IndexOf(hex) != -1)
                        {// Series Exists => add to graph
                            this.Invoke(new MethodInvoker(delegate
                            {
                                objForm1.bluetoothData.chart1.Series[hex].Points.AddXY(DateTime.Now.ToOADate()
                                    ,long.Parse(dat, System.Globalization.NumberStyles.HexNumber));
                                //objForm1.bluetoothData.chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                            }));
                        }
                        else// Series Does Not Exist => create a new one
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                objForm1.bluetoothData.chart1.Series.Add(hex);
                                objForm1.bluetoothData.chart1.Series[hex].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                                objForm1.bluetoothData.chart1.Series[hex].Points.AddXY(DateTime.Now.ToOADate()
                                   , long.Parse(dat, System.Globalization.NumberStyles.HexNumber));
                                //objForm1.bluetoothData.chart1.Series[hex].Points.AddY(long.Parse(dat, System.Globalization.NumberStyles.HexNumber));
                                objForm1.bluetoothData.chart1.Series[hex].XValueType = ChartValueType.Time;
                                objForm1.bluetoothData.CBoxPlotList.Items.Add(hex);
                                objForm1.bluetoothData.listBoxMotes.Items.Add(hex);
                                //objForm1.bluetoothData.chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                            }));
                        }
                        break;

                    case 'J':// Get network manager config
                        try
                        {
                            byte[] Data = new byte[16];
                            serialPort1.Read(Data, 0, 2);
                            (Data[0], Data[1]) = (Data[1], Data[0]);
                            UInt16 netID = BitConverter.ToUInt16(Data, 0);
                            netidLabel.Text = "Network ID: " + netID.ToString();
                            serialPort1.Read(Data, 0, 1);// Get the TX power
                            txPowerLabel.Text = "TX Power: " + Data[0].ToString();
                            serialPort1.Read(Data, 0, 2);// Get number of motes connected
                            (Data[0], Data[1]) = (Data[1], Data[0]);
                            motesConnLabel.Text = "Motes Connected: " + BitConverter.ToUInt16(Data, 0);
                            serialPort1.Read(Data, 0, 16);// Get the IPV6 address
                            string IPV6 = BitConverter.ToString(Data).Replace("-", "");
                            IPV6 = Regex.Replace(IPV6, ".{4}", "$0:");// Format the string;
                            IPV6 = IPV6.Remove(IPV6.Length-1);
                            IPV6Label.Text = "IPV6: " + IPV6;
                            MessageBox.Show("Updated");
                        }
                        catch
                        {
                            MessageBox.Show("Error!");
                        }
                        break;

                    case 'K':// Is network manager connected
                        byte[] buf = new byte[1];
                        serialPort1.Read(buf, 0, 1);
                        if (buf[0] == '0')
                            MessageBox.Show("Not Connected");
                        else
                            MessageBox.Show("Connected");
                        break;

                    case 'L':// Network manager was reset
                        MessageBox.Show("System Reset!");
                        break;

                    case 'M':// Reset stats command
                        MessageBox.Show("Reset Statistics!");
                        break;

                    case 'X':
                        MessageBox.Show("Error! Invalid Command!");
                        break;
                       
                    default:
                        //MessageBox.Show("Invalid Command Recieved!!");
                        break;
                }
            }
        }

        // Preparing outgoing packets 
        public void EnterKey()
        {
            Universal.PrepPacket();
            if (Universal.commandError == false)
            {
                serialPort1.Write(Universal.Response, 0, Universal.length);
                //receiverTextBox.Text += Universal.dataOUT + Universal.Sending;
                //receiverTextBox.Text += Universal.Sending;
               // addToRecord(CurrentTime, Universal.Sending, FilePath);
            }
        }
        #region Sensor_data

        int GAS_LPG = 0;               
        int GAS_CO = 1;                    
        int GAS_SMOKE = 2;               


        double LPG_value;
        double MQ2_CO2;
        double MQ2_smoke;

        double MQ7_PPM;

        double SNGCJA5_PM1_double;
        double SNGCJA5_PM2_5_double;
        double SNGCJA5_PM10_double;

        double SNGCJA5_P_count_0_5_double;
        double SNGCJA5_P_count_1_double;
        double SNGCJA5_P_count_2_5_double;
        double SNGCJA5_P_count_5_double;
        double SNGCJA5_P_count_7_5_double;
        double SNGCJA5_P_count_10_double;

        double AirQ_C02_double;
        double AirQ_TVOC_double;
        double Oxygen_Adc_double;
        double temp_Mote1_double;
        int MoteCount = 0;

        int OXG_persent;

        /************************Hardware Related Macros************************************/
        int MQ_PIN = 0;                          //define which analog input channel you are going to use
        int RL_VALUE = 5;                     //(10)     //define the load resistance on the board, in kilo ohms
        float RO_CLEAN_AIR_FACTOR = 9.83f;            //RO_CLEAR_AIR_FACTOR=(Sensor resistance in clean air)/RO,
                                                      //which is derived from the chart in datasheet

        /***********************Software Related Macros************************************/
        int CALIBARAION_SAMPLE_TIMES = 50;        // (50)    //define how many samples you are going to take in the calibration phase
        int CALIBRATION_SAMPLE_INTERVAL = 500;           //(500)   //define the time interal(in milisecond) between each samples in the
                                                         //cablibration phase
        int READ_SAMPLE_INTERVAL = 50;     //(50)    //define how many samples you are going to take in normal operation
        int READ_SAMPLE_TIMES = 5;            //(5)     //define the time interal(in milisecond) between each samples in 
                                              //normal operation

        /**********************Application Related Macros**********************************/

        /*****************************Globals***********************************************/
        float[] LPGCurve = { 2.3f, 0.21f, -0.47f };   //two points are taken from the curve. 
                                                      //with these two points, a line is formed which is "approximately equivalent"
                                                      //to the original curve. 
                                                      //data format:{ x, y, slope}; point1: (lg200, 0.21), point2: (lg10000, -0.59) 
        float[] COCurve = { 2.3f, 0.72f, -0.34f };    //two points are taken from the curve. 
                                                      //with these two points, a line is formed which is "approximately equivalent" 
                                                      //to the original curve.
                                                      //data format:{ x, y, slope}; point1: (lg200, 0.72), point2: (lg10000,  0.15) 
        float[] SmokeCurve = { 2.3f, 0.53f, -0.44f };    //two points are taken from the curve. 
                                                         //with these two points, a line is formed which is "approximately equivalent" 
                                                         //to the original curve.
                                                         //data format:{ x, y, slope}; point1: (lg200, 0.53), point2: (lg10000,  -0.22)                                                     
        float Ro = 10;                 //Ro is initialized to 10 kilo ohms



        #endregion




        #region  Database // Sending and recieving sensor data from the Database 



        String Going_Out;

        async void MangToPhone(object sender, EventArgs e)
        {

            Going_Out = Universal.displayMessage;

            //Temp std = new Temp()
            //{
            //    Temp_Value = nameTbox.Text,


            //};

            //var setter = client.Push("Temp", std);
             await Task.Delay(1000);

            ManagetToPhone std = new ManagetToPhone()
            {
                Manager_To_Phone = Going_Out ,


            };


              var setter = await client.UpdateAsync("PHtoMote/Manager_To_Phone", std);



           
        }


        async void UpdateSensorData(object sender, EventArgs e)
        {


            await Task.Delay(1000);

            //ManagetToPhone std = new ManagetToPhone()
            //{
            //    Manager_To_Phone = Going_Out,


            //};


            PMS pms_sensor = new PMS() {
                PMS_PM1 = SNGCJA5_PM1_double.ToString(),
                PMS_PM2_5 = SNGCJA5_PM2_5_double.ToString(),
                PMS_PM10 = SNGCJA5_PM10_double.ToString()
            };

            PMS_Count pmscount = new PMS_Count()
            {

                PMS_PCount0_5 = SNGCJA5_P_count_0_5_double.ToString(),
                PMS_PCount1 = SNGCJA5_P_count_1_double.ToString(),
                PMS_PCount2_5 = SNGCJA5_P_count_2_5_double.ToString(),
                PMS_PCount5 = SNGCJA5_P_count_5_double.ToString(),
                PMS_PCount7_5 = SNGCJA5_P_count_7_5_double.ToString(),
                PMS_PCount10 = SNGCJA5_P_count_7_5_double.ToString()

            };


            Mq2 Mq2_sensor = new Mq2()
            {

                Mq2_Co2 = MQ2_CO2.ToString(),
                Mq2_LPG = LPG_value.ToString(),
                Mq2_Smoke = MQ2_smoke.ToString()

            };


            Mq7 Mq7_sensor = new Mq7()
            {
                 Mq7_Co2 = MQ7_PPM.ToString()

            };



            Airquality Airquality_sensor = new Airquality()
            {

                 Airquality_Co2 = AirQ_C02_double.ToString(),
                  Airquality_TVOC = AirQ_TVOC_double.ToString()

            };

            Oxygen oxygen_sensor = new Oxygen()

            {

                Oxygen_level = OXG_persent.ToString()

            };




            var PMS_ = await client.UpdateAsync("PMS/PMS_PM1", pms_sensor);

            var pmscounts = await client.UpdateAsync("PMS_Count/PMS_PCount0_5", pmscount);


            var mq2sensor = await client.UpdateAsync("Mq2/Mq2_Co2", Mq2_sensor);

            var mq7sensor = await client.UpdateAsync("Mq7/Mq7_Co2", Mq7_sensor);

            var airqualitysensor = await client.UpdateAsync("Airquality/Airquality_Co2", Airquality_sensor);

            var oxygensenor = await client.UpdateAsync("Oxygen/Oxygen_level", oxygen_sensor);
        }



        async void LiveUPDATE(object sender, EventArgs e)
        {

            while (true)
            {
                await Task.Delay(1000);
                FirebaseResponse res = await client.GetAsync(@"PHtoMote/Phone_To_Manager");
                Dictionary<string, String> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                SendingToManager(data);

            }

        }

        string oldValues = "";
        void SendingToManager(Dictionary<string, string> record)
        {
            try
            {

              

                string sendingSerial_fmPHone = record.ElementAt(0).Value;

                if (sendingSerial_fmPHone != oldValues)
                {

                    //receiverTextBox.Text = sendingSerial_fmPHone.ToLower();

                    Universal.dataOUT = sendingSerial_fmPHone.ToLower();

                    EnterKey();
            
                }
                oldValues = sendingSerial_fmPHone;
            }

            catch
            {

                MessageBox.Show("Sending wrong data from the Phone");

            };




        }









        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int len = 32 - textBox2.Text.Length;
            charLabel.Text = len.ToString() + " Charcters Left";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                short net = short.Parse(textBox1.Text);// Get the network ID
                byte[] netid = BitConverter.GetBytes(net);
                (netid[1], netid[0]) = (netid[0], netid[1]);// Convert to big endian
                if (textBox2.Text.Length > 32)
                    throw (new Exception("Invalid Join Key"));

                byte[] jkey = new byte[16];// Setup byte array for serial port sending
                if(textBox2.Text.Length % 2 == 0)// Fix error for odd length of strings
                    jkey = StringToByteArray(textBox2.Text);
                else
                    jkey = StringToByteArray(textBox2.Text + "0");

                Array.Resize<byte>(ref jkey, 16);

                serialPort1.Write("A");// Send the network ID
                serialPort1.Write(netid, 0, 2);
                Thread.Sleep(50);
                serialPort1.Write("B");// Send the join key
                serialPort1.Write(jkey, 0, 16);
                //serialPort1.Write("F");// Reset the system
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Valid Values!!\nError: " + ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("C");// Get the mote list and process in the handler
            }
            catch
            {
                MessageBox.Show("Error! Serial Port not Open");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CBoxMoteList.Items.Clear();// Clear all the items in the list
        }

        private void CBoxMoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] mac_addr = new byte[8];
                if (CBoxMoteList.Text.Length != 16)
                    throw new Exception("Invalid Mac Address");
                mac_addr = StringToByteArray(CBoxMoteList.Text);

                serialPort1.Write("I");// Get Mote Infomation
                serialPort1.Write(mac_addr, 0, mac_addr.Length);
            }
            catch
            {
                MessageBox.Show("Error! Invalid Values!");
            }
            
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("E");// Is the network manager connected
            }
            catch
            {
                MessageBox.Show("Open Serial Port!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("G");// Get network manager stats
            }
            catch
            {
                MessageBox.Show("Open Serial Port!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("H");// Reset manager stats
        }

        private void moteInfoButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("I");// Get mote information
            UInt64 mac = UInt64.Parse(CBoxMoteList.Text, System.Globalization.NumberStyles.HexNumber);
            byte[] macAddr = BitConverter.GetBytes(mac);
            (macAddr[0], macAddr[1], macAddr[2], macAddr[3], macAddr[4], macAddr[5], macAddr[6], macAddr[7]) = 
                (macAddr[7], macAddr[6], macAddr[5], macAddr[4], macAddr[3], macAddr[2], macAddr[1], macAddr[0]);
            serialPort1.Write(macAddr, 0, 8);
        }
    }
}
