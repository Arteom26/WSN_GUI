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
            //chart1.Titles.Add("Mass-density (µg/m³) Air");
            //chart2.Titles.Add("Particle count (μm) ");

            //chart3.Titles.Add("CO2 (PPM)");

            //chart4.Titles.Add("AirQuality Sensors (PPM) ");

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
            /*
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
            */


        }


        #region TransmissionTextBox

        private void transmitterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Universal.EnterWasPressed == 1)
            {
                //transmitterTextBox.Text = transmitterTextBox.Text.Replace(Environment.NewLine, "");
                Universal.EnterWasPressed = 0;
            }

        }

        private void transmitterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (serialPort1.IsOpen)
                {
                    //Universal.dataOUT = transmitterTextBox.Text;

                

                    if (Universal.portType == "CLI")
                        serialPort1.WriteLine(Universal.dataOUT);
                    else
                        EnterKey();

                   // transmitterTextBox.Text = "";
                    Universal.EnterWasPressed = 1;
                }
            }
        }

        #endregion


        /* NOTE:    Fathi   Sunday 11/14/2021
         *The code below does not save CVS files. all of the code related to saving the data to excell file wore commented out. 
         *                              
         */



        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        { 
            if (serialPort1.BytesToRead > 0)
            {
                byte[] buffer = new byte[serialPort1.BytesToRead];
                int count = serialPort1.Read(buffer, 0, serialPort1.BytesToRead);
                Universal.Storage += Universal.ByteArrayToString(buffer);
                CheckForFullPacket();
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
            Universal.DecodePacket();

            Sensor_Payload += Universal.displayMessage;
            this.Invoke(new EventHandler(MangToPhone));

            if (Universal.PacketType == "03")
            {
                Universal.dataOUT = "hello";
                EnterKey();
            }

            Universal.flagInt = 0;
            Universal.dataIN = "";


            if (Sensor_Payload.Contains("data: ") && Sensor_Payload.Contains("Payload length: "))
            {
                //this.Invoke(new EventHandler(Sensor_data));
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
