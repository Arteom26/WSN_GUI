using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            chart1.Titles.Add("Mass-density (µg/m³) Air");
            chart2.Titles.Add("Particle count (μm) ");

            chart3.Titles.Add("CO2 (PPM)");

            chart4.Titles.Add("AirQuality Sensors (PPM) ");

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


                if (Universal.portTypeInt % 2 == 0) //Even
                {
                    Universal.portType = "API";
                    serialPort1.BaudRate = 115200;
                    serialPort1.DtrEnable = true;
                }
                else
                {
                    Universal.portType = "CLI";
                    serialPort1.BaudRate = 9600;
                    serialPort1.DtrEnable = false;
                }

                serialPort1.Open();


                connectButton.Text = "Close";
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

                toolStripStatusLabel1.Text = Universal.portType + " Port Connected";
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripProgressBar1.Value = 100;

                this.Invoke(new EventHandler(LiveUPDATE));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                toolStripStatusLabel1.Text = "ERROR";
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripProgressBar1.Value = 0;
            }

        }




        //private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    receiverTextBox.Text = "";
        //}

        //private void networkStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form2 _Reliability = new Form2(this);
        //    _Reliability.Show();

        //}


        private void MainPageForm_Load(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen) { 
            CBoxBaudRate.Text = "9600"; //Default Value
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

            chart1.Series[0].Points.AddY(0);
            chart1.Series[1].Points.AddY(0);
            chart1.Series[2].Points.AddY(0);


            chart2.Series[0].Points.AddY(0);
            chart2.Series[1].Points.AddY(0);
            chart2.Series[2].Points.AddY(0);
            chart2.Series[3].Points.AddY(0); 
            chart2.Series[4].Points.AddY(0);
            chart2.Series[5].Points.AddY(0);



            chart3.Series[0].Points.AddY(0);
            chart3.Series[1].Points.AddY(0);
            chart3.Series[2].Points.AddY(0);


            chart4.Series[0].Points.AddY(0);
            chart4.Series[1].Points.AddY(0);



        }



   



        #region TransmissionTextBox

        private void transmitterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Universal.EnterWasPressed == 1)
            {
                transmitterTextBox.Text = transmitterTextBox.Text.Replace(Environment.NewLine, "");
                Universal.EnterWasPressed = 0;
            }

        }

        private void transmitterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (serialPort1.IsOpen)
                {
                    Universal.dataOUT = transmitterTextBox.Text;

                

                    if (Universal.portType == "CLI")
                        serialPort1.WriteLine(Universal.dataOUT);
                    else
                        EnterKey();

                    transmitterTextBox.Text = "";
                    Universal.EnterWasPressed = 1;
                }
            }
        }

        #endregion






        #region ReceiverTextBox

        public void receiverTextBox_TextChanged_1(object sender, EventArgs e)
        {
            receiverTextBox.ScrollBars = ScrollBars.Vertical;
            receiverTextBox.SelectionStart = receiverTextBox.Text.Length;
            receiverTextBox.ScrollToCaret();
        }

        #endregion





        #region Miscellaneous

        //public void addToRecord(string time, string text, string filepath)
        //{
        //    try
        //    {
        //        using (StreamWriter file = new StreamWriter(filepath, true))
        //        {
        //            file.WriteLine("\t\t" + time + "\r\n" + text + "\r\n");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        #endregion


        /* NOTE:    Fathi   Sunday 11/14/2021
         *The code below does not save CVS files. all of the code related to saving the data to excell file wore commented out. 
         *                              
         */



        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Universal.portType == "CLI")
            {
                Universal.dataIN = serialPort1.ReadLine();
                if (Universal.dataIN.Contains("\r"))
                {
                    Universal.dataIN += "\n";
                }
                this.Invoke(new EventHandler(DisplayData));
            }
            else
            {
                if (serialPort1.BytesToRead > 0)
                {
                    byte[] buffer = new byte[serialPort1.BytesToRead];
                    int count = serialPort1.Read(buffer, 0, serialPort1.BytesToRead);
                    Universal.Storage += Universal.ByteArrayToString(buffer);
                    CheckForFullPacket();

                }
            }
        }


        private void CheckForFullPacket()
        {
            int count = Universal.Storage.Length / 2;

            for (int i = 0; i < count; i++)
            {
                if (Universal.flagInt == 2)
                    break;

                if (Universal.Storage.Substring(0, 2) == "7E")
                    Universal.flagInt++;

                Universal.dataIN += Universal.Storage.Substring(0, 2);
                Universal.Storage = Universal.Storage.Remove(0, 2);
            }
            if (Universal.flagInt == 2)
            {
               // addToRecord(CurrentTime, Universal.displayMessage, FilePath);

                try
                {
                    this.Invoke(new EventHandler(DisplayData));
                }
                catch
                {
                    Universal.dataIN = "";
                }

                Universal.Storage = "";
                Universal.flagInt = 0;
            }
        }

        string Sensor_Payload;
        // deciphering packets from the network manager
        private void DisplayData(object sender, EventArgs e)
        {
            if (Universal.portType == "CLI")
            {
                receiverTextBox.Text += Universal.dataIN;


            }
            else
            {
                Universal.DecodePacket();
                // Uncomment if you want to see the entire packet in hex
              //  receiverTextBox.Text += Universal.dataIN + "\r\n" + Universal.displayMessage;
                receiverTextBox.Text += Universal.displayMessage;
                Sensor_Payload += Universal.displayMessage;
                this.Invoke(new EventHandler(MangToPhone));

                if (Universal.PacketType == "03")
                {
                    Universal.dataOUT = "hello";
                    EnterKey();
                }

                Universal.flagInt = 0;
                Universal.dataIN = "";


                //if (Sensor_Payload.Contains("data:"))

                    //	data: 013B013B01620004000000000001904C0000812BE933C72AAE0856012C57A2376200000000000000000000000000000000000000000000
                    // Payload length: 55 bytes


                    if (Sensor_Payload.Contains("data: ") && Sensor_Payload.Contains("Payload length: "))
                    {
                      
                      
                        this.Invoke(new EventHandler(Sensor_data));
                       


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
                receiverTextBox.Text += Universal.Sending;
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





        public void Sensor_data(object sender, EventArgs e)
        {

           string CurentMote= "";
            string Mote1 = "00170D000070A9ED";
           string Mote2 = "00170D0000680696";


          

            receiverTextBox.Text = Universal.Sensor_payload;
            string data_load = Universal.Sensor_payload;

            CurentMote = Universal.macAddress;

            textBox1.Text = CurentMote;


            chart1.ChartAreas[0].AxisX.Title = "TIME ";
            chart1.ChartAreas[0].AxisY.Title = "Mass-density value (µg/m³)";


            chart2.ChartAreas[0].AxisX.Title = "TIME ";
            chart2.ChartAreas[0].AxisY.Title = "Number of Particals";


            chart3.ChartAreas[0].AxisX.Title = "TIME ";
            chart3.ChartAreas[0].AxisY.Title = "PPM";


            chart4.ChartAreas[0].AxisX.Title = "TIME ";
            chart4.ChartAreas[0].AxisY.Title = "PPM";


            //	data: 013B 013B 0162 00 04 00 00 00 00 00 01 90 4C 00 00 81 2B E9 33 C7 2A AE 08 56 01 2C 57 A2 37 62 00 000000000000000000000000000000000000000000
            // Payload length: 55 bytes

            // Sensor_Payload


            // SNGCJA5_PM1 = data_load.Substring(0,4);


         




            if (CurentMote == Mote1)
            {
                textBox1.Text = CurentMote;

                MoteCount++;



                 SNGCJA5_PM1_double = ((double)Int64.Parse(Universal.SNGCJA5_PM1, System.Globalization.NumberStyles.HexNumber)) / 1000.0;

                SNGCJA5_PM1_textBox.Text = SNGCJA5_PM1_double.ToString() + "µg/m³ \n";


                //   SNGCJA5_PM2_5 = data_load.Substring(4, 4);

                SNGCJA5_PM2_5_double = ((double)Int64.Parse(Universal.SNGCJA5_PM2_5, System.Globalization.NumberStyles.HexNumber)) / 1000.0;

                SNGCJA5_PM2_5_textBox.Text = SNGCJA5_PM2_5_double.ToString() + "µg/m³ \n";


               SNGCJA5_PM10_double = ((double)Int64.Parse(Universal.SNGCJA5_PM10, System.Globalization.NumberStyles.HexNumber)) / 1000.0;

                SNGCJA5_PM10_textBox.Text = SNGCJA5_PM10_double.ToString() + "µg/m³ \n";

                //Each One is 1 BYTE 

                //         Register 1 for particle count(0.3 - 0.5µm)| i2c_app_v.StoreBUFFER[3] = PCOUNT0_5;//B3
                //         Register 2 for particle count(0.5 - 1.0µm)| i2c_app_v.StoreBUFFER[4] = PCOUNT0_5;//B3
                //         Register 3 for particle count(1.0 - 2.5µm) | i2c_app_v.StoreBUFFER[5] = PCOUNT0_5;//B3
                //         Register 4 for particle count(2.5 - 5.0µm)| i2c_app_v.StoreBUFFER[6] = PCOUNT0_5;//B3
                //         Register 5 for particle count(5.0 - 7.5µm)| i2c_app_v.StoreBUFFER[7] = PCOUNT0_5;//B3
                //         Register 6 for particle count(7.5 - 10.0µm)| i2c_app_v.StoreBUFFER[8] = PCOUNT0_5;//B3
                //         Register for sensor status information | i2c_app_v.StoreBUFFER[3] = PCOUNT0_5;//B3



                // SNGCJA5_P_count_0_5 = data_load.Substring(12, 2);

                SNGCJA5_P_count_0_5_double = ((double)Int64.Parse(Universal.SNGCJA5_P_count_0_5, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_P_count_0_5_textbox.Text = SNGCJA5_P_count_0_5_double.ToString() + "#/cm³";

                SNGCJA5_P_count_1_double = ((double)Int64.Parse(Universal.SNGCJA5_P_count_1, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_P_count_1_textbox.Text = SNGCJA5_P_count_1_double.ToString() + "#/cm³";

                SNGCJA5_P_count_2_5_double = ((double)Int64.Parse(Universal.SNGCJA5_P_count_2_5, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_P_count_2_5_textbox.Text = SNGCJA5_P_count_2_5_double.ToString() + "#/cm³";

                SNGCJA5_P_count_5_double = ((double)Int64.Parse(Universal.SNGCJA5_P_count_5, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_P_count_5_textbox.Text = SNGCJA5_P_count_5_double.ToString() + "#/cm³";

                SNGCJA5_P_count_7_5_double = ((double)Int64.Parse(Universal.SNGCJA5_P_count_7_5, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_P_count_7_5_textbox.Text = SNGCJA5_P_count_7_5_double.ToString() + "#/cm³";


                SNGCJA5_P_count_10_double = ((double)Int64.Parse(Universal.SNGCJA5_P_count_10, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_P_count_10_textbox.Text = SNGCJA5_P_count_10_double.ToString() + "#/cm³";

                double SNGCJA5_State_double = ((double)Int64.Parse(Universal.SNGCJA5_State, System.Globalization.NumberStyles.HexNumber));

                SNGCJA5_State_textbox.Text = SNGCJA5_State_double.ToString();



                /////AirQuality Sensor 
                ///
                //013B013B016200060000000000 0190 4C 0020 07 1BC22D872573086B012C57A22B1E00000000000000000000000000000000000000000000



                // AirQ_C02 = data_load.Substring(26, 4);

                AirQ_C02_double = ((double)Int64.Parse(Universal.AirQ_C02, System.Globalization.NumberStyles.HexNumber)) / 400.0;

                AirQ_C02_textBox.Text = AirQ_C02_double.ToString() + " ppm \n";

               



                /// AirQ_TVOC = data_load.Substring(32, 4);

                AirQ_TVOC_double = ((double)Int64.Parse(Universal.AirQ_TVOC, System.Globalization.NumberStyles.HexNumber)) / 1000.0;

                AirQ_TVOC_textbox.Text = AirQ_TVOC_double.ToString() + " ppm \n";

             


                 Oxygen_Adc_double = ((double)Int64.Parse(Universal.Oxygen_Adc, System.Globalization.NumberStyles.HexNumber)) / 10000;


                OXG_persent = (25 / 23) * (int)Oxygen_Adc_double;


              //  Oxygen_Sensor_textbox.Text = OXG_persent.ToString() + " volt\n";


              

                //    temp_sensor = data_load.Substring(50, 4);

                 temp_Mote1_double = ((double)Int64.Parse(Universal.temp_sensor, System.Globalization.NumberStyles.HexNumber)) / 100.0;

                temp_Mote1_double = (Convert.ToDouble(temp_Mote1_double) / 100) * (9 / 5) + 32;

                Temperature_textBox.Text = temp_Mote1_double.ToString() + " C\n";




            }

            else if (CurentMote == Mote2)

            {

                textBox1.Text = CurentMote;

                MoteCount++;
         //   Mq7_C02 = data_load.Substring(54, 4);

                //double Mq7_C02_double = ((double)Int64.Parse(Universal.Mq7_C02, System.Globalization.NumberStyles.HexNumber)) / 100.000;

                //double MQ7_CO2_PPM = Math.Pow(Mq7_C02_double, -1.709);

                ///  MQ7_C02_textbox.Text = MQ7_CO2_PPM.ToString() + " ppm\n"; /// 


                double Mq7_adc_double = ((double)Int64.Parse(Universal.Mq7_adc, System.Globalization.NumberStyles.HexNumber))/10000 ;

            double Mq7_r0 = 25927.01;

            double mq7_Rs_gas = (5.0 - Mq7_adc_double) / Mq7_adc_double;

            double Mq7_ratio = mq7_Rs_gas / Mq7_r0;

            double Mq7_x = 1538.46 * Mq7_ratio;

             MQ7_PPM = Math.Pow(Mq7_x, (double)(-1.709));

           // Mq7_ADC_textBox.Text = MQ7_PPM.ToString() + " voltage\n";

            MQ7_C02_textbox.Text = MQ7_PPM.ToString() + " ppm\n"; /// 




            //  Mq2_LPG = data_load.Substring(38, 4);

            double Mq2_LPG_double = ((double)Int64.Parse(Universal.Mq2_LPG, System.Globalization.NumberStyles.HexNumber)) / 1000;
            double Mq2_C02_double = ((double)Int64.Parse(Universal.Mq2_C02, System.Globalization.NumberStyles.HexNumber)) / 1000;
            double Mq2_smoke_double = ((double)Int64.Parse(Universal.Mq2_smoke, System.Globalization.NumberStyles.HexNumber)) / 1000;


             LPG_value = MQGetGasPercentage((float)Mq2_LPG_double, GAS_LPG);
             MQ2_CO2 = MQGetGasPercentage((float)Mq2_C02_double, GAS_CO);
             MQ2_smoke = MQGetGasPercentage((float)(Mq2_smoke_double), GAS_SMOKE);


            LPG_textBox.Text = LPG_value.ToString() + "ppm \n";

            co_MQ2_textbox.Text = MQ2_CO2.ToString() + "ppm \n";

            smoke_MQ_2_textBox.Text = MQ2_smoke.ToString() + "ppm \n";


          


            }


       
            if (MoteCount == 2)
            {
                MoteCount = 0;

                chart1.Series[0].Points.AddY(SNGCJA5_PM1_double);
                chart1.Series[1].Points.AddY(SNGCJA5_PM2_5_double);
                chart1.Series[2].Points.AddY(SNGCJA5_PM10_double);
                //if (chart1.Series[2].Points.Count > 10)
                //    chart1.Series[2].Points.RemoveAt(0);


                chart2.Series[0].Points.AddY(SNGCJA5_P_count_0_5_double);
                chart2.Series[1].Points.AddY(SNGCJA5_P_count_1_double);
                chart2.Series[2].Points.AddY(SNGCJA5_P_count_2_5_double);
                chart2.Series[3].Points.AddY(SNGCJA5_P_count_5_double);
                chart2.Series[4].Points.AddY(SNGCJA5_P_count_7_5_double);

                chart2.Series[5].Points.AddY(SNGCJA5_P_count_10_double);



                chart3.Series[0].Points.AddY(AirQ_C02_double);
           

                chart4.Series[2].Points.AddY(AirQ_TVOC_double);
         


                //time++; // }

                chart3.Series[2].Points.AddY(MQ7_PPM);
           

                //ploting 

                chart3.Series[1].Points.AddY(MQ2_CO2);
             


                chart4.Series[0].Points.AddY(MQ2_smoke);
             


                chart4.Series[1].Points.AddY(LPG_value);




                if (chart1.Series[0].Points.Count > 100)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.Series[1].Points.RemoveAt(0);
                    chart1.Series[2].Points.RemoveAt(0);

                    chart2.Series[0].Points.RemoveAt(0);
                    chart2.Series[1].Points.RemoveAt(0);
                    chart2.Series[2].Points.RemoveAt(0);
                    chart2.Series[3].Points.RemoveAt(0);
                    chart2.Series[4].Points.RemoveAt(0);
                    chart2.Series[5].Points.RemoveAt(0);

                    chart3.Series[0].Points.RemoveAt(0);
                    chart3.Series[1].Points.RemoveAt(0);
                    chart3.Series[2].Points.RemoveAt(0);


                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.Series[1].Points.RemoveAt(0);
                    chart1.Series[2].Points.RemoveAt(0);


                }

          






                chart1.ChartAreas[0].RecalculateAxesScale();
                chart2.ChartAreas[0].RecalculateAxesScale();
                chart3.ChartAreas[0].RecalculateAxesScale();
                chart4.ChartAreas[0].RecalculateAxesScale();

                this.Invoke(new EventHandler(UpdateSensorData));
               
            }


            /*****************************  MQGetGasPercentage **********************************
            Input:   rs_ro_ratio - Rs divided by Ro
                     gas_id      - target gas type
            Output:  ppm of the target gas
            Remarks: This function passes different curves to the MQGetPercentage function which 
                     calculates the ppm (parts per million) of the target gas.
            ************************************************************************************/
            int MQGetGasPercentage(float rs_ro_ratio, int gas_id)
            {
                if (gas_id == GAS_LPG)
                {
                    //rs_ro_ratio = 7.5F;
                    return MQGetPercentage(rs_ro_ratio, LPGCurve);
                }
                else if (gas_id == GAS_CO)
                {
                    return MQGetPercentage(rs_ro_ratio, COCurve);
                }
                else if (gas_id == GAS_SMOKE)
                {
                    return MQGetPercentage(rs_ro_ratio, SmokeCurve);
                }

                return 0;
            }

            /*****************************  MQGetPercentage **********************************
            Input:   rs_ro_ratio - Rs divided by Ro
                     pcurve      - pointer to the curve of the target gas
            Output:  ppm of the target gas
            Remarks: By using the slope and a point of the line. The x(logarithmic value of ppm) 
                     of the line could be derived if y(rs_ro_ratio) is provided. As it is a 
                     logarithmic coordinate, power of 10 is used to convert the result to non-logarithmic 
                     value.
            ************************************************************************************/
            int MQGetPercentage(float rs_ro_ratio, float[] pcurve)
            {   //check the int Casting 

                //  return (int)Math.Pow(10, (((Math.Log(rs_ro_ratio) - pcurve[1]) / pcurve[2]) + pcurve[0]));

                // float[] LPGCurve = { 2.3f, 0.21f, -0.47f };



                try
                {
                    double x = Math.Pow(10, (((Math.Log(rs_ro_ratio) - pcurve[1]) / pcurve[2]) + pcurve[0]));
                    //return (int)Math.Pow(10, (((Math.Log(rs_ro_ratio) - pcurve[1]) / pcurve[2]) + pcurve[0]));
                    int x_value = Convert.ToInt32(x);
                    return x_value;
                }
                catch
                {
                    return 0;
                }



            }



        }


        #endregion




        #region Sensors     //computing/displaying  Sensor data 


        string Incoming_Data;
        public void Oxygen_Sensor(object sender, EventArgs e)
        {

            string Oxygen_data = Incoming_Data;
            // Oxygen =
            string current_string = "Oxygen= ";
            int string_lenght = current_string.Length;

            int Start_Indext = Oxygen_data.IndexOf(current_string) + string_lenght;
            int end_string = Oxygen_data.IndexOf(" E ") - Start_Indext;
            String Oxygen_value = Oxygen_data.Substring(Start_Indext, end_string);


            int OXG_int = Convert.ToInt32(Oxygen_value);

            int OXG_persent = (25 / 23) * OXG_int;

            Oxygen_Sensor_textbox.Text = OXG_persent.ToString() + "%";





            Incoming_Data = " ";
        }


        public void AirQuality_Sensor(object sender, EventArgs e)
        {

            string AirQuality_data = Incoming_Data;


            //Start
            //C02: 0190  TVOC: 0000
            //End


            string current_string = "C02: ";
            int string_lenght = current_string.Length;

            int Start_Indext = AirQuality_data.IndexOf(current_string) + string_lenght;
            String Co2_AirQuiality = AirQuality_data.Substring(Start_Indext, 5);



            current_string = "TVOC: ";
            string_lenght = current_string.Length;

            Start_Indext = AirQuality_data.IndexOf(current_string) + string_lenght;
            String TVOC_AirQuiality = AirQuality_data.Substring(Start_Indext, 5);





            decimal Co2 = ((decimal)Int64.Parse(Co2_AirQuiality, System.Globalization.NumberStyles.HexNumber) / 400) - 1;

            decimal TVOT = (decimal)Int64.Parse(TVOC_AirQuiality, System.Globalization.NumberStyles.HexNumber);

            // SPG30_CO2 = Convert.ToDouble(Co2);
            //SPG30_TVOT = Convert.ToDouble(TVOT);


            //Air_Q_Co2.Text = Co2.ToString() + "ppm \n";
            //Air_Q_TVOC.Text = TVOT.ToString() + "ppm \n";

            //if (SPG30_CO2 != 0)
            //{

            //list.Add(time, MQ2_CO2);


            //Air_Q_C02_list.Add(time, SPG30_CO2);
            //Air_Q_TVOC_list.Add(time, SPG30_TVOT);
            //zedGraphControl1.Invalidate();
            //CreateChart(zedGraphControl1);



            //}





            // Incoming_Data = " ";

        }

        public void MQ7_Sensor(object sender, EventArgs e)
        {

            string MQ7_data = Incoming_Data;
            // MQ7 =
            string current_string = "CO2: ";
            int string_lenght = current_string.Length;

            int Start_Indext = MQ7_data.IndexOf(current_string) + string_lenght;
            int end_string = MQ7_data.IndexOf(" p ") - Start_Indext;
            String CO2_MQ7_value = MQ7_data.Substring(Start_Indext, 5);



            double CO2_MQ7_int = Convert.ToInt32(CO2_MQ7_value) / 1000.000;
            double MQ7_CO2_PPM = Math.Pow(CO2_MQ7_int, -1.709);


            MQ7_C02_textbox.Text = MQ7_CO2_PPM.ToString();




            //   MQ7_C02_textbox.Text = "0";


            Incoming_Data = " ";
        }




        public void Sensor_display(object sender, EventArgs e)
        {


            try
            {

                string sensor_data = Incoming_Data;

                //LPG: 9811
                //CO: 9813
                //SMOKE: 9791

                /***************************** Smoke Sensor MQ - 2  *********************************/
                // Sensor temperature 
                String current_string = "LPG: ";
                int string_lenght = current_string.Length;

                int Start_Indext = sensor_data.IndexOf(current_string) + string_lenght;
                // int End_Indext = sensor_data.IndexOf("CO: ");
                // int lenght_difference = End_Indext - Start_Indext;
                String LPG_string = sensor_data.Substring(Start_Indext, 5);


                float LPG;

                //  if (Convert.ToDouble(LPG_string) == 0)
                //  {

                //      LPG = (float)(Convert.ToDouble(LPG_string));
                //  }
                // else {  


                LPG = (float)(Convert.ToDouble(LPG_string)) / 1000;



                //  Temperature_textBox.Text = LPG.ToString();





                /*****************************  Smoke Sensor MQ - 2  **************************/

                current_string = "CO: ";
                string_lenght = current_string.Length;

                Start_Indext = sensor_data.IndexOf(current_string) + string_lenght;
                // int End_Indext = sensor_data.IndexOf("Carbon");
                // int lenght_difference = End_Indext - Start_Indext;
                String Carbon_Monoxide_data = sensor_data.Substring(Start_Indext, 5);




                float Carbon_Monoxide_Value = (float)(Convert.ToDouble(Carbon_Monoxide_data)) / 1000;

                // Carbon_textbox.Text = Carbon_Monoxide_Value.ToString();




                /*****************************  Smoke Sensor MQ - 2  **********************************/
                current_string = "SMOKE: ";
                string_lenght = current_string.Length;

                Start_Indext = sensor_data.IndexOf(current_string) + string_lenght;
                // int End_Indext = sensor_data.IndexOf("Carbon");
                // int lenght_difference = End_Indext - Start_Indext;
                String Smoke_Sensor_MQ_2_data = sensor_data.Substring(Start_Indext, 5);




                double Smoke_Sensor_MQ_2_Value = Convert.ToDouble(Smoke_Sensor_MQ_2_data) / 1000;

                LPG_textBox.Text = Smoke_Sensor_MQ_2_Value.ToString();



                /*****************************  Temp  **********************************/
                current_string = "Temperature= ";
                string_lenght = current_string.Length;

                Start_Indext = sensor_data.IndexOf(current_string) + string_lenght;
                // int End_Indext = sensor_data.IndexOf("Carbon");
                // int lenght_difference = End_Indext - Start_Indext;
                String Temp = sensor_data.Substring(Start_Indext, 5);




                double temp_value = (Convert.ToDouble(Temp) / 100) * (9 / 5) + 32;



                Temperature_textBox.Text = temp_value.ToString();




                //  Incoming_Data = " ";




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
                int GAS_LPG = 0;               // (0)
                int GAS_CO = 1;                    // (1)
                int GAS_SMOKE = 2;                //  (2)

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

                //void setup()
                //{
                //    Serial.begin(9600);                               //UART setup, baudrate = 9600bps
                //    Serial.print("Calibrating...\n");
                //    Ro = MQCalibration(MQ_PIN);                       //Calibrating the sensor. Please make sure the sensor is in clean air 
                //                                                      //when you perform the calibration                    
                //    Serial.print("Calibration is done...\n");
                //    Serial.print("Ro=");
                //    Serial.print(Ro);
                //    Serial.print("kohm");
                //    Serial.print("\n");
                //}



                //if (Calib_Smpl_Counter == 0)
                //{
                //    tBoxDataIN.Text += "Calibrating...\n";
                //    tBoxDataIN.Text += "R0= \n";

                //    Ro = MQCalibration(MQ_PIN);

                //    tBoxDataIN.Text += Ro.ToString() + "  Kohm \n";

                //}
                //else {

                //   // tBoxDataIN.Text += "LPG:" + MQGetGasPercentage(MQRead(MQ_PIN) / Ro, GAS_LPG).ToString() + "ppm \n";

                //    co_MQ2_textbox.Text =  MQGetGasPercentage(MQRead(MQ_PIN) / Ro, GAS_CO).ToString() + "ppm \n";

                //   smoke_MQ_2_textBox.Text =  MQGetGasPercentage(MQRead(MQ_PIN) / Ro, GAS_SMOKE).ToString() + "ppm \n";



                //}



                //if (Carbon_Monoxide_Value > 1500)
                //{
                //    string LPG_ppm = (MQGetGasPercentage(LPG, GAS_LPG)/1000).ToString();
                //    LPG_textBox.Text = "ppm \n";


                //    co_MQ2_textbox.Text = MQGetGasPercentage(Carbon_Monoxide_Value/10000, GAS_CO).ToString() + "ppm \n";

                //    smoke_MQ_2_textBox.Text = MQGetGasPercentage((float)(Smoke_Sensor_MQ_2_Value)/1000, GAS_SMOKE).ToString() + "ppm \n";

                //}
                //else {


                int LPG_value = MQGetGasPercentage(LPG, GAS_LPG);
                int MQ2_CO2 = MQGetGasPercentage(Carbon_Monoxide_Value, GAS_CO);
                int MQ2_smoke = MQGetGasPercentage((float)(Smoke_Sensor_MQ_2_Value), GAS_SMOKE);


                LPG_textBox.Text = LPG_value.ToString() + "ppm \n";

                co_MQ2_textbox.Text = MQGetGasPercentage(Carbon_Monoxide_Value, GAS_CO).ToString() + "ppm \n";

                smoke_MQ_2_textBox.Text = MQGetGasPercentage((float)(Smoke_Sensor_MQ_2_Value), GAS_SMOKE).ToString() + "ppm \n";







                //  if (MQ2_CO2 != 0) { 

                //MQ2_CO2_list.Add(time, MQ2_CO2);
                //MQ2_LPG_list.Add(time, LPG_value);
                //MQ2_Smoke_list.Add(time, MQ2_smoke);

                //temp_list.Add(time, temp_value);

                // list2.Add(time, SPG30_CO2);
                //zedGraphControl1.Invalidate();
                //CreateChart(zedGraphControl1);


                //addToRecord(time.ToString(), MQ2_CO2.ToString(), LPG_value.ToString(), MQ2_smoke.ToString(), temp_value.ToString(), SPG30_TVOT.ToString(), SPG30_CO2.ToString(), "SensorINFO.txt");
                // addToRecord("2", "Fathi", "fathi.txt");





                //list2.Add(time, 123);
                //zedGraphControl2.Invalidate();
                //CreateChart(zedGraphControl2);

                //}



               // time++; // }




                /*****************************  MQGetGasPercentage **********************************
                Input:   rs_ro_ratio - Rs divided by Ro
                         gas_id      - target gas type
                Output:  ppm of the target gas
                Remarks: This function passes different curves to the MQGetPercentage function which 
                         calculates the ppm (parts per million) of the target gas.
                ************************************************************************************/
                int MQGetGasPercentage(float rs_ro_ratio, int gas_id)
                {
                    if (gas_id == GAS_LPG)
                    {
                        //rs_ro_ratio = 7.5F;
                        return MQGetPercentage(rs_ro_ratio, LPGCurve);
                    }
                    else if (gas_id == GAS_CO)
                    {
                        return MQGetPercentage(rs_ro_ratio, COCurve);
                    }
                    else if (gas_id == GAS_SMOKE)
                    {
                        return MQGetPercentage(rs_ro_ratio, SmokeCurve);
                    }

                    return 0;
                }

                /*****************************  MQGetPercentage **********************************
                Input:   rs_ro_ratio - Rs divided by Ro
                         pcurve      - pointer to the curve of the target gas
                Output:  ppm of the target gas
                Remarks: By using the slope and a point of the line. The x(logarithmic value of ppm) 
                         of the line could be derived if y(rs_ro_ratio) is provided. As it is a 
                         logarithmic coordinate, power of 10 is used to convert the result to non-logarithmic 
                         value.
                ************************************************************************************/
                int MQGetPercentage(float rs_ro_ratio, float[] pcurve)
                {   //check the int Casting 

                    //  return (int)Math.Pow(10, (((Math.Log(rs_ro_ratio) - pcurve[1]) / pcurve[2]) + pcurve[0]));

                    // float[] LPGCurve = { 2.3f, 0.21f, -0.47f };



                    try
                    {
                        double x = Math.Pow(10, (((Math.Log(rs_ro_ratio) - pcurve[1]) / pcurve[2]) + pcurve[0]));
                        //return (int)Math.Pow(10, (((Math.Log(rs_ro_ratio) - pcurve[1]) / pcurve[2]) + pcurve[0]));
                        int x_value = Convert.ToInt32(x);
                        return x_value;
                    }
                    catch
                    {
                        return 0;
                    }



                }


            }

            catch { }


        }




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

                    receiverTextBox.Text = sendingSerial_fmPHone.ToLower();

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

        #region Fathi_old serial functions 



        //private void button11_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnSendData_Click(object sender, EventArgs e)
        //{
        //    TxSendData();
        //}




        //private void Open_button_Click(object sender, EventArgs e)
        //{
        //    //addToRecord("1", "Fathi", "fathi.txt");
        //    //addToRecord("2", "Fathi", "fathi.txt");
        //    try
        //    {
        //        serialPort1.PortName = cBoxCOMPORT.Text;
        //        serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
        //        serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
        //        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
        //        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

        //        serialPort1.Open();
        //        progressBar1.Value = 100;
        //        // LiveCall();
        //       // this.Invoke(new EventHandler(LiveCall));
        //    }

        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void close_button_Click(object sender, EventArgs e)
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        serialPort1.Close();
        //        progressBar1.Value = 0;
        //    }
        //}



        //private void cBoxCOMPORT_DropDown(object sender, EventArgs e)
        //{
        //    string[] ports = SerialPort.GetPortNames();
        //    //cBoxCOMPORT.Items.Clear();
        //    cBoxCOMPORT.Items.AddRange(ports);
        //}





        //private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        serialPort1.Close();
        //        progressBar1.Value = 0;
        //    }
        //}



        //public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    //dataIN = serialPort1.ReadExisting();

        //    List<int> dataBuffer = new List<int>();

        //    while (serialPort1.BytesToRead > 0)
        //    {
        //        try
        //        {
        //            dataBuffer.Add(serialPort1.ReadByte());
        //        }
        //        catch (Exception error)
        //        {
        //            MessageBox.Show(error.Message);
        //        }
        //    }

        //    dataINLength = dataBuffer.Count();
        //    dataInDec = new int[dataINLength];
        //    dataInDec = dataBuffer.ToArray();

        //    this.Invoke(new EventHandler(ShowData));

        //}

        //#region RX Data Format
        //private string RxDataFormat(int[] dataInput)
        //{
        //    string strOut = "";



        //    foreach (int element in dataInput)
        //    {
        //        strOut += Convert.ToChar(element);
        //    }

        //    return strOut;
        //}
        //#endregion


        //private void ShowData(object sender, EventArgs e)
        //{
        //    //int dataINLength = dataIN.Length;

        //    dataIN = RxDataFormat(dataInDec);

        //    tBoxDataIN.Text += dataIN;
        //   // Incoming_Data += dataIN;

        //    // tBoxDataIN.Text += dataIN;
        //}

        //private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        serialPort1.PortName = cBoxCOMPORT.Text;
        //        serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
        //        serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
        //        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
        //        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

        //        serialPort1.Open();
        //        progressBar1.Value = 100;
        //    }

        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void TxDataFormat()
        //{
        //  string  toolStripComboBox_TxDataFormat = "Char";
        //    if (toolStripComboBox_TxDataFormat == "Char")
        //    {
        //        //Send the data in the textbox via serial port
        //        serialPort1.Write(tBoxDataOut.Text);

        //        //Calculate the length of the data sent and then show it
        //        int dataOUTLength = tBoxDataOut.TextLength;
        //      //  lblDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
        //    }
        //    else
        //    {
        //        //Declare Local Variable
        //        string dataOutBuffer;
        //        int countComma = 0;
        //        string[] dataPrepareToSend;
        //        byte[] dataToSend;

        //        try
        //        {
        //            //Move the data package in the textbox into a variable
        //            dataOutBuffer = tBoxDataOut.Text;

        //            //Count how much comma (,) punctuation in the data package
        //            foreach (char c in dataOutBuffer) { if (c == ',') { countComma++; } }

        //            //Create one-dimensional array (string data type) with the length based on the countComma
        //            dataPrepareToSend = new string[countComma];

        //            //Parsing the data in dataOutBuffer and save it into an array dataPrepareToSend based on comma punctuation
        //            countComma = 0; //Reset Value to 0
        //            foreach (char c in dataOutBuffer)
        //            {
        //                if (c != ',')
        //                {
        //                    //Append the data to array of dataPrepareToSend
        //                    dataPrepareToSend[countComma] += c;
        //                }
        //                else
        //                {
        //                    //If a comma finds in the data package, then increase the countComma variable. CountComma is using to determine the index of dataPrepareToSend array
        //                    countComma++;
        //                    //Stop foreach process if numbers of countComma equal to the size of dataPrepareToSend
        //                    if (countComma == dataPrepareToSend.GetLength(0)) { break; }
        //                }
        //            }

        //            //Create one-dimensional array (byte data type) with the length based on the size of dataPrepareToSend
        //            dataToSend = new byte[dataPrepareToSend.Length];

        //            if (toolStripComboBox_TxDataFormat == "Hex")
        //            {
        //                //Convert data in string array (dataPrepareToSend) into byte array(dataToSend)
        //                for (int a = 0; a < dataPrepareToSend.Length; a++)
        //                {
        //                    dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 16);
        //                    //Convert string to an 8-bit unsigned integer with the specified base number
        //                    //Value 16 mean Hexa
        //                }
        //            }
        //            else if (toolStripComboBox_TxDataFormat == "Binary")
        //            {
        //                //Convert data in string array (dataPrepareToSend) into byte array(dataToSend)
        //                for (int a = 0; a < dataPrepareToSend.Length; a++)
        //                {
        //                    dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 2);
        //                    //Convert string to an 8-bit unsigned integer with the specified base number
        //                    //Value 2 mean Binary
        //                }
        //            }
        //            else if (toolStripComboBox_TxDataFormat == "Decimal")
        //            {
        //                //Convert data in string array (dataPrepareToSend) into byte array(dataToSend)
        //                for (int a = 0; a < dataPrepareToSend.Length; a++)
        //                {
        //                    dataToSend[a] = Convert.ToByte(dataPrepareToSend[a], 10);
        //                    //Convert string to an 8-bit unsigned integer with the specified base number
        //                    //Value 10 mean Decimal
        //                }
        //            }

        //            //Send a specified number of bytes to the serial port
        //            serialPort1.Write(dataToSend, 0, dataToSend.Length);

        //            //Calculate the length of data sent and then show it
        //           // lblDataOutLength.Text = string.Format("{0:00}", dataToSend.Length);
        //        }
        //        catch (Exception error)
        //        {
        //            MessageBox.Show(error.Message);
        //        }
        //    }
        //}

        //private void TxSendData()
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        //dataOUT = tBoxDataOut.Text;
        //        if (sendWith == "None")
        //        {
        //            //serialPort1.Write(dataOUT);
        //            TxDataFormat();
        //        }
        //        else if (sendWith == @"Both (\r\n)")
        //        {
        //            //serialPort1.Write(dataOUT + "\r\n");
        //            TxDataFormat();
        //            serialPort1.Write("\r\n");
        //        }
        //        else if (sendWith == @"New Line (\n)")
        //        {
        //            //serialPort1.Write(dataOUT + "\n");
        //            TxDataFormat();
        //            serialPort1.Write("\n");
        //        }
        //        else if (sendWith == @"Carriage Return (\r)")
        //        {
        //            //serialPort1.Write(dataOUT + "\r");
        //            TxDataFormat();
        //            serialPort1.Write("\r");
        //        }
        //    }
        //    //if (clearToolStripMenuItem.Checked)
        //    //{
        //    //    if (tBoxDataOut.Text != "")
        //    //    {
        //    //        tBoxDataOut.Text = "";
        //    //    } }

        //}

        //private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        //{
        //    tBoxDataIN.ScrollBars = ScrollBars.Vertical;
        //    tBoxDataIN.SelectionStart = tBoxDataIN.Text.Length;
        //    tBoxDataIN.ScrollToCaret();
        //}




        #endregion

        private void btnSendData_Click(object sender, EventArgs e)
        {

        }
    }
}
