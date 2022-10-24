using System;
using System.Text;

namespace myLibrary
{
    public class Universal
    {

        #region General Variables

        public int stat = 0;

        /// <summary>
        /// 
        /// </summary>
        public string CanISend = "Yes";

        /// <summary>
        /// Is the COM port CLI or API
        /// </summary>
        public string portType;

        /// <summary>
        /// The ENTER key was pressed
        /// in the transmission textbox
        /// </summary>
        public int EnterWasPressed;

        /// <summary>
        /// Data sent thru the serial port
        /// </summary>
        public string dataOUT;

        /// <summary>
        /// Data read from serial port
        /// </summary>
        public string dataIN;

        /// <summary>
        /// Store incoming data from serialPort 
        /// </summary>
        public string Storage = "";

        /// <summary>
        /// Paylod of the packet
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public string Payload;

        /// <summary>
        /// The Control, Packet Type, Sequence Number, and Length fields are the Serial API Header
        /// | Embedded Manager API Guide - Page 13
        /// </summary>
        public string Header = "";

        /// <summary>
        /// The "7E" flag sequence
        /// | Embedded Manager API Guide - Page 13
        /// </summary>
        public string flag = "7E";

        /// <summary>
        /// length/number of bytes
        /// </summary>
        public static int length;

        /// <summary>
        /// Flag that checks if complete packet has come in or not.
        /// </summary>
        public int flagInt = 0;

        /// <summary>
        /// Packet type allows you to identify
        /// the structure contained in the payload.
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public string PacketType;

        /// <summary>
        /// Length of the packet payload in hex
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public string PayloadLength;

        /// <summary>
        /// Length of the packet payload in int
        /// </summary>
        public int PayloadLengthInt;

        /// <summary>
        /// This is the API Header + Payload.
        /// it's needed to calculate FCS
        /// </summary>
        public byte[] Response;

        /// <summary>
        /// This is the frame check sequence of the packet
        /// </summary>
        public string FCS;

        /// <summary>
        /// The packets sequence number
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public int SequenceNumberInt = 0;

        /// <summary>
        /// The packets sequence number
        /// to be used for Incoming packets
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public int SequenceNumberInt_Incoming = 0;

        /// <summary>
        /// The packets sequence number
        /// to be used for Outgoing packets
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public int SequenceNumberInt_Outgoing = 0;

        /// <summary>
        /// This should be displayed on the textbox
        /// </summary>
        public string displayMessage;

        /// <summary>
        /// Bite 0 indicates whether the packet is a data packet or an ack packet. 
        /// Request are data packets and response are ack packets.
        /// Bit 1 whether the packet should be acknowledged or not. 
        /// 0 is data and 1 is ack packet. 2 is no acknowledgement and 3 is acknowledgement.
        /// | Embedded Manager API Guide - Page 14
        /// </summary>
        public string Control = "02";

        /// <summary>
        /// Explains what packet was sent on the receiver textbox
        /// </summary>
        public string Sending = "";

        /// <summary>
        /// Mote MAC address. 8 bytes
        /// </summary>
        public string macAddress;

        /// <summary>
        /// The MAC addresses of our motes
        /// </summary>
        public string Mote_d018 = "00-17-0D-00-00-32-D0-18", Mote_d2d8 = "00-17-0D-00-00-32-D2-D8", Mote_d38a = "00-17-0D-00-00-32-D3-8A",
               Mote_e1ff = "00-17-0D-00-00-33-E1-FF", Mote_ba4e = "00-17-0D-00-00-5A-BA-4E", Mote_6762 = "00-17-0D-00-00-5A-67-62";

        /// <summary>
        /// Callback ID
        /// </summary>
        public string callbackId;


        public int portTypeInt;

        /// <summary>
        /// flag goes up when unrecognized flag is entered
        /// </summary>
        public bool commandError = false;





        public string Sensor_payload;

        #endregion

        public string SNGCJA5_PM1;
        public string SNGCJA5_PM2_5;
        public string SNGCJA5_PM10;

        /// <summary>
        /// Partical sensor Data 
        /// Partical sensor P counts 
        /// </summary>
        public string SNGCJA5_P_count_0_5;
        public string SNGCJA5_P_count_1;
        public string SNGCJA5_P_count_2_5;
        public string SNGCJA5_P_count_5;
        public string SNGCJA5_P_count_7_5;
        public string SNGCJA5_P_count_10;


        public string SNGCJA5_State;


        /// <summary>
        /// Airquality Sensor 
        /// </summary>
        public string AirQ_C02;
        public string AirQ_TVOC;

        /// <summary>
        /// MQ2 sensor Data
        /// </summary>
        public string Mq2_LPG;
        public string Mq2_C02;
        public string Mq2_smoke;


        public string temp_sensor;

        /// <summary>
        /// MQ7 sensor 
        /// </summary>
        public string Mq7_C02;
        public string Mq7_adc;

        /// <summary>
        /// oxygen sensor adc value 
        /// </summary>
        public string Oxygen_Adc;








        #region Packet parameters


        /// <summary>
        /// Response code. All commands will return RC_OK (0) if the command succeeds, and a nonzero RC if the command fails. 
        /// Command descriptions list currently defined nonzero RCs.
        /// </summary>
        public string rc;

        /// <summary>
        /// Version of the protocol
        /// | Embedded Manager API Guide - Page 15
        /// </summary>
        public string version;

        /// <summary>
        /// Reserved for compatibility; must be 0
        /// | Embedded Manager API Guide - Page 15
        /// </summary>
        public string mode;

        /// <summary>
        /// The client sequence number
        /// | Embedded Manager API Guide - Page 16
        /// </summary>
        public string cliSeqNo;

        /// <summary>
        /// The manager sequence number. Subsequent reliable messages 
        /// sent by the manager will use the next sequence number.
        /// | Embedded Manager API Guide - Page 16
        /// </summary>
        public string mgrSeqNo;

        /// <summary>
        /// Mote state. 1 byte
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string state;

        /// <summary>
        /// The number of motes within range of this mote, 
        /// both currently and potentially connected. 1 byte
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string numNbrs;

        /// <summary>
        /// The number of neighboring motes that have 
        /// good (>50) quality paths with this mote. 1 byte
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string numGoodNbrs;

        /// <summary>
        /// bandwidth requested by mote, milliseconds per packet. 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string requestedBw;

        /// <summary>
        /// Total bandwidth required by the mote and its children 
        /// (includes requestedBw), milliseconds per packet. 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string totalNeededBw;

        /// <summary>
        /// Currently assigned bandwidth, milliseconds per packet. 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string assignedBw;

        /// <summary>
        /// Number of packets received by the manager from the mote. 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string packetsReceived;

        /// <summary>
        /// Number of packets sent by the mote, but lost at the manager. 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string packetsLost;

        /// <summary>
        /// The average time (ms) taken for packets generated at the mote to reah the manager. 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string avgLatency;

        /// <summary>
        /// Time after last mote state modiciation (s). 4 bytes
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string stateTime;

        /// <summary>
        /// Number of times this device has joined. This saturates at 255 joins. 1 byte
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string numJoins;

        /// <summary>
        /// Calculated number of hops from the manager times 10. 4 bytes.
        /// | Embedded Manager API Guide - Page 33
        /// </summary>
        public string hopDepth;

        /// <summary>
        /// Mote ID
        /// | Embedded Manager API Guide - Page 30
        /// </summary>
        public string moteId;

        /// <summary>
        /// Is this the manager access point
        /// | Embedded Manager API Guide - Page 30
        /// </summary>
        public string isAP;

        /// <summary>
        /// True if looking  for next mote; false if 
        /// looking for this MAC address
        /// | Embedded Manager API Guide - Page 30
        /// </summary>
        public string next;

        /// <summary>
        /// Time (s) that the response was generated (as uptime). 4 bytes
        /// | Embedded Manager API Guide - Page 48
        /// </summary>
        public string uptime;

        /// <summary>
        /// Time that the response was generated. 12 bytes.
        /// | Embedded Manager API Guide - Page 48
        /// </summary>
        public string utc;

        /// <summary>
        /// Absolute slot number. 5 bytes
        /// | Embedded Manager API Guide - Page 48
        /// </summary>
        public string asn;

        /// <summary>
        /// Offset inside ASN, in microseconds, 2 byte
        /// | Embedded Manager API Guide - Page 48
        /// </summary>
        public string asnOffset;

        /// <summary>
        /// Number of motes in the "operational" state
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string numMotes;

        /// <summary>
        /// ASN size is the timeslot duration (s)
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string asnSize;

        /// <summary>
        /// Advertisement State
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string advertisementState;

        /// <summary>
        /// Indicates the current downstream frame length, that 
        /// is, whether or not the multiplier is applied
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string downFrameState;

        /// <summary>
        /// Network reliability as a percentage
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string netReliability;

        /// <summary>
        /// Path stability as a percentage
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string netPathStability;

        /// <summary>
        /// Average latency, ms
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string netLatency;

        /// <summary>
        /// Current network state
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string netState;

        /// <summary>
        /// IPV6 address of the system
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string ipv6Address;

        /// <summary>
        /// Number of lost packets
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string numLostPackets;

        /// <summary>
        /// Number of received packets
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string numArrivedPackets;

        /// <summary>
        /// Maximum number of hops in the network
        /// | Embedded Manager API Guide - Page 39
        /// </summary>
        public string maxNumbHops;

        /// <summary>
        /// Notification type. 1 byte
        /// | Embedded Manager API Guide - Page 74
        /// </summary>
        public string notifType;

        /// <summary>
        /// Event ID. 4 bytes
        /// | Embedded Manager API Guide - Page 77
        /// </summary>
        public string eventId;

        /// <summary>
        /// Event type. 1 byte
        /// | Embedded Manager API Guide - Page 77
        /// </summary>
        public string eventType;

        /// <summary>
        /// Round trip delay in miliseconds. 4 byte
        /// </summary>
        public string delay;

        /// <summary>
        /// Voltage reported by mote (mV). 2 byte
        /// </summary>
        public string voltage;

        /// <summary>
        /// Temperature reported by mote, in C. 1 byte
        /// </summary>
        public string temperature;

        /// <summary>
        /// Time that the packet was generated at the mote. 12 bytes
        /// </summary>
        public string timestamp;

        /// <summary>
        /// Soure port. 2 bytes
        /// </summary>
        public string srcPort;

        /// <summary>
        /// Destination port. 2 bytes
        /// </summary>
        public string dstPort;

        /// <summary>
        /// health report type identifier. 1 byte
        /// </summary>
        public string id;

        /// <summary>
        /// Source mote MAC address. 8 bytes
        /// </summary>
        public string source;

        /// <summary>
        /// Destination mote MAC address. 8 bytes
        /// </summary>
        public string dest;

        /// <summary>
        /// Path direction
        /// </summary>
        public string direction;

        /// <summary>
        /// Type of object to reset. 0 = system. 2 = mote.
        /// | Embedded Manager API Guide - Page 53
        /// </summary>
        public int type;

        /// <summary>
        /// Priority of the packet. 0 = Low. 1 = Medium. 2 = High.
        /// | Embedded Manager API Guide - Page 107
        /// </summary>
        public int priority;

        /// <summary>
        /// Number of links between motes for upstream frame
        /// | Embedded Manager API Guide - Page 44
        /// </summary>
        public string numLinks;
        
        /// <summary>
        /// Stability measurement for used path, RSSI for unused path
        /// | Embedded Manager API Guide - Page 44
        /// </summary>
        public string quality;
        
        /// <summary>
        /// Path from source mote to destination mote RSSI
        /// | Embedded Manager API Guide - Page 44
        /// </summary>
        public string rssiSrcDest;
        
        /// <summary>
        /// Path from destination mote to source mote RSSI
        /// | Embedded Manager API Guide - Page 44
        /// </summary>
        public string rssiDestSrc;

        #endregion



        #region Functions

        /// <summary>
        /// Converts from byte array to hex
        /// </summary>
        /// <param name="incomingData">
        /// the byte array you want to convert into hex</param>
        /// <returns></returns>
        public string ByteArrayToString(byte[] incomingData)
        {
            StringBuilder hex = new StringBuilder(incomingData.Length * 2);
            foreach (byte b in incomingData)
                hex.AppendFormat("{0:X2}", b);
            return hex.ToString();
        }

        /// <summary>
        /// Converts from hex to byte array
        /// </summary>
        /// <param name="outgoingData">
        /// the hex you want to convert into a byte array</param>
        /// <returns></returns>
        public byte[] HexToBytes(string outgoingData)
        {
            byte[] result = new byte[outgoingData.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(outgoingData.Substring(2 * i, 2), 16);
            }
            return result;
        }

        /// <summary>
        /// Extracts x bytes from the payload
        /// </summary>
        /// <param name="numOfBytes">
        /// Number of bytes to extract</param>
        /// <returns></returns>
        public string Extract(int numOfBytes)
        {
            string AfterExtraction;
            AfterExtraction = Payload.Substring(0, 2 * numOfBytes);
            Payload = Payload.Remove(0, 2 * numOfBytes);
            return AfterExtraction;
        }


        /// <summary>
        /// 0 => Decode.
        /// 1 => Prep.
        /// </summary>
        /// <param name="Choice">
        /// 0 => Decode.
        /// 1 => Prep</param>
        public void ByteStuffing(int Choice)
        {
            //Decode
            if (Choice == 0)
            {
                Header = dataIN;
                Header = Header.Remove(0, 2);
                length = Header.Length;
                Header = Header.Remove(length - 2, 2);

                if (Header.Contains("7D5D"))
                {
                    Header = Header.Replace("7D5D", "7D");
                }
                else if (Header.Contains("7D5E"))
                {
                    Header = Header.Replace("7D5E", "7E");
                }

                dataIN = flag + Header + flag;
            }
            //Prep
            else if (Choice == 1)
            {
                Header = dataOUT;
                Header = Header.Remove(0, 2);
                length = Header.Length;
                Header = Header.Remove(length - 2, 2);

                if (Header.Contains("7D"))
                {
                    Header = Header.Replace("7D", "7D5D");
                }
                else if (Header.Contains("7E"))
                {
                    Header = Header.Replace("7E", "7D5E");
                }
                dataOUT = flag + Header + flag;
            }
        }



        #endregion



        #region Frame Check Sequence Calculator

        public static class Crc16
        {
            const ushort polynomial = 0x8408;

            static readonly ushort[] table = new ushort[256];

            public static string ComputeChecksum(byte[] bytes)
            {
                ushort crc = 0xffff;
                for (int i = 0; i < bytes.Length; ++i)
                {
                    byte index = (byte)(crc ^ bytes[i]);
                    crc = (ushort)((crc >> 8) ^ table[index]);
                }
                crc = (ushort)~crc;
                string fcs = crc.ToString("X2");
                string Two, One;

                if (fcs.Length == 4)
                {
                    Two = fcs.Substring(0, 2);
                    One = fcs.Substring(2, 2);
                    fcs = One + Two;
                }
                else if (fcs.Length == 3)
                {
                    Two = fcs.Substring(0, 1);

                    One = fcs.Substring(1, 2);
                    fcs = One + "0" + Two;
                }

                return fcs;
            }

            static Crc16()
            {
                ushort value = 0;
                ushort temp = 0;
                for (ushort i = 0; i < table.Length; ++i)
                {
                    value = 0;
                    temp = i;
                    for (byte j = 0; j < 8; ++j)
                    {
                        if (((value ^ temp) & 0x0001) != 0)
                        {
                            value = (ushort)((value >> 1) ^ polynomial);
                        }
                        else
                        {
                            value >>= 1;
                        }
                        temp >>= 1;
                    }
                    table[i] = value;
                }
            }
        }



        #endregion


        public void DecodePacket()
        {
            ByteStuffing(0);
            PacketType = dataIN.Substring(4, 2);
            PayloadLength = dataIN.Substring(8, 2);
            PayloadLengthInt = 2 * Convert.ToInt32(PayloadLength, 16);
            Payload = dataIN.Substring(10, PayloadLengthInt);
            Response = HexToBytes(dataIN.Substring(2, 8) + Payload);
            FCS = Crc16.ComputeChecksum(Response);

            //if (FCS == dataIN.Substring(10 + PayloadLengthInt, 4) && (SequenceNumberInt_Incoming.ToString("X2") != dataIN.Substring(6, 2) 
            //   || dataIN.Substring(4, 2) == "14"))
            if (FCS == dataIN.Substring(10 + PayloadLengthInt, 4))
            //if (FCS == dataIN.Substring(10 + PayloadLengthInt, 4) && (SequenceNumberInt_Incoming.ToString("X2") != dataIN.Substring(6, 2) ||
            //    dataIN.Substring(4, 2) == "01" || dataIN.Substring(4, 2) == "02" || dataIN.Substring(4, 2) == "03"))
            {
                if (dataIN.Substring(4, 2) != "01" || dataIN.Substring(4, 2) != "02" || dataIN.Substring(4, 2) != "03")
                    SequenceNumberInt_Incoming = Convert.ToInt32(dataIN.Substring(6, 2), 16);
                

                //SequenceNumberInt++;
                SendingFlag = 0;

                // MgrHello Packet
                if (PacketType == "03")
                {
                    version = Extract(1);
                    mode = Extract(1);
                    displayMessage = ">MgrHello Payload (Page 15) Received: " + "\r\n\t" + "version: " + version
                                     + "\r\n\t" + "mode: " + mode + "\r\n";
                }
                
                // HelloResponse Packet
                else if (PacketType == "02")
                {
                    rc = Extract(1);
                    version = Extract(1);
                    mgrSeqNo = Extract(1);
                    cliSeqNo = Extract(1);
                    mode = Extract(1);

                    displayMessage = ">HelloResponse Payload (Page 16) Received: "
                    + "\r\n\t" + "Response Code: " + rc
                    + "\r\n\t" + "Version: " + version + "\r\n\t" + "Manager Sequence Number: " + mgrSeqNo
                    + "\r\n\t" + "Client sequence number: " + cliSeqNo + "\r\n\t" + "Mode: " + mode + "\r\n";
                }
                
                // getMoteInfo Packet
                else if (PacketType == "3E")
                {
                    rc = Extract(1);

                    if (rc == "00")
                    {
                        macAddress = Extract(8);
                        state = Extract(1);
                        numNbrs = Extract(1);
                        numGoodNbrs = Extract(1);
                        requestedBw = Extract(4);
                        totalNeededBw = Extract(4);
                        assignedBw = Extract(4);
                        packetsReceived = Extract(4);
                        packetsLost = Extract(4);
                        avgLatency = Extract(4);
                        stateTime = Extract(4);
                        numJoins = Extract(1);
                        hopDepth = Extract(1);

                        displayMessage = ">getMoteInfo Payload (Page 33): "
                        + "\r\n\t" + "Response code: " + rc
                        + "\r\n\t" + "MAC Address: " + macAddress
                        + "\r\n\t" + "Mote state: " + Convert.ToInt32(state, 16)
                        + "\r\n\t" + "numNbrs: " + Convert.ToInt32(numNbrs, 16)
                        + "\r\n\t" + "numGoodNbrs: " + Convert.ToInt32(numGoodNbrs, 16)
                        + "\r\n\t" + "requestedBw: " + Convert.ToInt32(requestedBw, 16)
                        + "\r\n\t" + "totalNeededBw: " + Convert.ToInt32(totalNeededBw, 16)
                        + "\r\n\t" + "assignedBw: " + Convert.ToInt32(assignedBw, 16)
                        + "\r\n\t" + "packetsReceived: " + Convert.ToInt32(packetsReceived, 16)
                        + "\r\n\t" + "packetsLost: " + Convert.ToInt32(packetsLost, 16)
                        + "\r\n\t" + "avgLatency: " + Convert.ToInt32(avgLatency, 16)
                        + "\r\n\t" + "stateTime: " + Convert.ToInt32(stateTime, 16)
                        + "\r\n\t" + "numJoins: " + Convert.ToInt32(numJoins, 16)
                        + "\r\n\t" + "hopDepth: " + Convert.ToInt32(hopDepth, 16) + "\r\n\r\n";
                    }
                    else
                    {
                        displayMessage = ">getMoteInfo Payload (Page 33): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "No such mote " + "\r\n\r\n";
                    }
                }
                
                // getMoteConfig Packet 
                else if (PacketType == "2F")
                {
                    rc = Extract(1);

                    if (rc == "00")
                    {
                        macAddress = Extract(8);
                        moteId = Extract(2);
                        isAP = Extract(1);
                        state = Extract(1);
                        mode = Extract(1);

                        if (state == "00")
                            state = "lost";
                        else if (state == "01")
                            state = "negotiating";
                        else if (state == "04")
                            state = "operational";


                        displayMessage = ">getMoteConfig Payload (Page 30): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "moteId: " + moteId
                        + "\r\n\t" + "state: " + state + "\r\n\r\n";
                    }
                    else if (rc == "12")
                    {
                        displayMessage = ">getMoteConfig Payload (Page 30): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "The specified mote doesn't exist " + "\r\n\r\n";
                    }
                    else if (rc == "0B")
                    {
                        displayMessage = ">getMoteConfig Payload (Page 30): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Last mote in the list has been reached" + "\r\n\r\n";
                    }
                }
                
                // pingMote Packet
                else if (PacketType == "2A")
                {
                    rc = Extract(1);

                    if (rc == "00")
                    {
                        callbackId = Extract(4);
                        displayMessage = ">pingMote Payload (Page 49): "
                        + "\r\n\t" + "rc: " + rc
                        + "\r\n\t" + "callbackId: " + Convert.ToInt32(callbackId, 16) + "\r\n\r\n";
                    }
                    else if (rc == "12")
                    {
                        displayMessage = ">pingMote Payload (Page 49):"
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Specified mote not found" + "\r\n\r\n";
                    }
                    else if (rc == "11")
                    {
                        displayMessage = ">pingMote Payload (Page 49):"
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Mote is not in operational state" + "\r\n\r\n";
                    }
                    else if (rc == "0C")
                    {
                        displayMessage = ">pingMote Payload (Page 49):"
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "User commands queue is full" + "\r\n\r\n";
                    }
                    else if (rc == "0D")
                    {
                        displayMessage = ">pingMote Payload (Page 49):"
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Previous echo request command is still pending for specified mote" + "\r\n\r\n";
                    }
                }

                // getTime Packet
                else if (PacketType == "17")
                {
                    rc = Extract(1);
                    uptime = Extract(4);
                    utc = Extract(12);
                    asn = Extract(5);
                    asnOffset = Extract(2);

                    displayMessage = ">getTime Payload (Page 48): "
                    + "\r\n\t" + "rc: " + rc
                    + "\r\n\t" + "uptime: " + Convert.ToInt32(uptime, 16)
                    + "\r\n\t" + "UTC: " + utc
                    + "\r\n\t" + "ASN: " + asn
                    + "\r\n\t" + "asnOffset: " + asnOffset + "\r\n\r\n";
                    //DateTime.Parse(Convert.ToString(utc))
                }

                // getNetworkInfo Packet
                else if (PacketType == "40")
                {
                    rc = Extract(1);
                    numMotes = Extract(2);
                    asnSize = Extract(2);
                    advertisementState = Extract(1);
                    downFrameState = Extract(1);
                    netReliability = Extract(1);
                    netPathStability = Extract(1);
                    netLatency = Extract(4);
                    netState = Extract(1);
                    ipv6Address = Extract(16);
                    numLostPackets = Extract(4);
                    numArrivedPackets = Extract(8);
                    maxNumbHops = Extract(1);


                    displayMessage = ">getNetworkInfo Payload (Page 39): "
                    + "\r\n\t" + "Response code: " + rc
                    + "\r\n\t" + "numMotes: " + Convert.ToInt32(numMotes, 16)
                    + "\r\n\t" + "asnSize: " + Convert.ToInt32(asnSize, 16)
                    + "\r\n\t" + "advertisementState: " + advertisementState
                    + "\r\n\t" + "downFrameState: " + downFrameState
                    + "\r\n\t" + "netReliability: " + Convert.ToInt32(netReliability, 16)
                    + "\r\n\t" + "netPathStability: " + Convert.ToInt32(netPathStability, 16)
                    + "\r\n\t" + "netLatency: " + Convert.ToInt32(netLatency, 16)
                    + "\r\n\t" + "netState: " + netState
                    + "\r\n\t" + "ipv6Address: " + ipv6Address
                    + "\r\n\t" + "numLostPackets: " + Convert.ToInt32(numLostPackets, 16)
                    + "\r\n\t" + "numArrivedPackets: " + Convert.ToInt32(numArrivedPackets, 16)
                    + "\r\n\t" + "maxNumbHops: " + Convert.ToInt32(maxNumbHops, 16) + "\r\n\r\n";
                }

                // subscribe Packet
                else if (PacketType == "16")
                {
                    rc = Payload.Substring(0, 2);
                    displayMessage = ">subcribe Payload (Page 72): "
                    + "\r\n\t" + "rc: " + rc + "\r\n\r\n";
                }

                // Notification packet
                else if (PacketType == "14")
                {
                    notifType = Extract(1);

                    if (notifType == "01")
                        notifType = "Event Notification";
                    else if (notifType == "02")
                        notifType = "Log Notification";
                    else if (notifType == "04")
                        notifType = "Data Notification";
                    else if (notifType == "05")
                        notifType = "IP Data Notification";
                    else if (notifType == "06")
                        notifType = "Health Report Notification";


                    if (notifType == "Event Notification")
                    {
                        eventId = Extract(4);
                        eventType = Extract(1);


                        #region eventType

                        if (Convert.ToInt32(eventType, 16) == 0)
                        {
                            eventType = "moteReset";
                            macAddress = Extract(8);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macAddress: " + macAddress + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 1)
                        {
                            eventType = "networkReset";

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 2)
                        {
                            eventType = "commandFinished";
                            callbackId = Extract(4);
                            rc = Extract(1);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "callbackId: " + callbackId + "\r\n\t"
                            + "rc: " + rc + "\r\n\r\n";

                        }
                        else if (Convert.ToInt32(eventType, 16) == 3)
                        {
                            eventType = "moteJoin";
                            macAddress = Extract(8);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macAddress: " + macAddress + "\r\n\r\n";

                        }
                        else if (Convert.ToInt32(eventType, 16) == 4)
                        {
                            eventType = "moteOperational";
                            macAddress = Extract(8);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macAddress: " + macAddress + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 5)
                        {
                            eventType = "moteLost";
                            macAddress = Extract(8);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macaddress: " + macAddress + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 6)
                        {
                            eventType = "networkTime";

                            uptime = Extract(4);
                            utc = Extract(12);
                            asn = Extract(5);
                            asnOffset = Extract(2);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macaddress: " + macAddress + "\r\n"
                            + "\r\n\t" + "uptime: " + Convert.ToInt32(uptime, 16)
                            + "\r\n\t" + "UTC: " + utc
                            + "\r\n\t" + "ASN: " + asn
                            + "\r\n\t" + "asnOffset: " + asnOffset + "\r\n\r\n";

                        }
                        else if (Convert.ToInt32(eventType, 16) == 7)
                        {
                            eventType = "pingResponse";
                            callbackId = Extract(4);
                            macAddress = Extract(8);
                            delay = Extract(4);
                            voltage = Extract(2);
                            temperature = Extract(1);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType
                            + "\r\n\t" + "callbackId: " + callbackId
                            + "\r\n\t" + "macaddress: " + macAddress
                            + "\r\n\t" + "delay: " + Convert.ToInt32(delay, 16)
                            + "\r\n\t" + "voltage: " + Convert.ToInt32(voltage, 16) + " mV"
                            + "\r\n\t" + "temp: " + Convert.ToInt32(temperature, 16) + " °C" + "\r\n\r\n";

                        }
                        else if (Convert.ToInt32(eventType, 16) == 9)
                        {
                            eventType = "reserved";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 10)
                        {
                            eventType = "pathCreate";

                            source = Extract(8);
                            dest = Extract(8);
                            direction = Extract(1);

                            if (direction == "00")
                                direction = "No path";
                            else if (direction == "01")
                                direction = "Path is not used";
                            else if (direction == "02")
                                direction = "Upstream path";
                            else if (direction == "03")
                                direction = "Downstream path";

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macaddress of source: " + source + "\r\n"
                            + "\r\n\t" + "macaddress of source: " + dest
                            + "\r\n\t" + "direction: " + direction + "\r\n\r\n";

                        }
                        else if (Convert.ToInt32(eventType, 16) == 11)
                        {
                            eventType = "pathDelete";

                            source = Extract(8);
                            dest = Extract(8);
                            direction = Extract(1);

                            if (direction == "00")
                                direction = "No path";
                            else if (direction == "01")
                                direction = "Path is not used";
                            else if (direction == "02")
                                direction = "Upstream path";
                            else if (direction == "03")
                                direction = "Downstream path";

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macaddress of source: " + source + "\r\n"
                            + "\r\n\t" + "macaddress of source: " + dest
                            + "\r\n\t" + "direction: " + direction + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 12)
                        {
                            eventType = "packetSent";

                            callbackId = Extract(4);
                            rc = Extract(1);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "callbackId: " + callbackId + "\r\n\t"
                            + "rc: " + rc + "\r\n\r\n";

                        }
                        else if (Convert.ToInt32(eventType, 16) == 13)
                        {
                            eventType = "moteCreate";

                            moteId = Extract(2);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macaddress: " + macAddress + "\r\n\t"
                            + "moteId: " + moteId + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 14)
                        {
                            eventType = "moteDelete";

                            moteId = Extract(2);

                            displayMessage = "*" + notifType
                            + "\r\n\t" + eventType + "\r\n\t"
                            + "macaddress: " + macAddress + "\r\n\t"
                            + "moteId: " + moteId + "\r\n\r\n";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 15)
                        {
                            eventType = "joinFailed";
                        }
                        else if (Convert.ToInt32(eventType, 16) == 16)
                        {
                            eventType = "moteReset";
                        }


                        #endregion


                    }
                    else if (notifType == "Log Notification")
                    {
                        macAddress = Extract(8);

                        displayMessage = "*" + notifType
                        + "\r\n\t" + macAddress + "\r\n"
                        + dataIN + "\r\n";

                    }
                    else if (notifType == "Data Notification")
                    {

                        timestamp = Extract(12);
                        macAddress = Extract(8);
                        srcPort = Extract(2);
                        dstPort = Extract(2);

                        int size = Payload.Length / 2;


                        displayMessage = "*" + notifType + "\r\n\t"
                                             + "Time the packet was generated: " + timestamp + "\r\n\t"
                                             + "MAC address: " + macAddress + "\r\n\t"
                                             + "Source Port: " + srcPort + "\r\n\t"
                                             + "Destination Port: " + dstPort + "\r\n\t"
                                             + "data: " + Payload + "\r\n"
                                             + "\t\tPayload length: " + size + " bytes" + "\r\n\r\n";


                        SNGCJA5_PM1 = Extract(2);

                        //added by fathi on sunday  
                        Sensor_payload = Payload;





                        SNGCJA5_PM2_5 = Extract(2);
                        SNGCJA5_PM10 = Extract(2);

                        SNGCJA5_P_count_0_5 = Extract(1);
                        SNGCJA5_P_count_1 = Extract(1);
                        SNGCJA5_P_count_2_5 = Extract(1);
                        SNGCJA5_P_count_5 = Extract(1);
                        SNGCJA5_P_count_7_5 = Extract(1);
                        SNGCJA5_P_count_10 = Extract(1);

                        SNGCJA5_State = Extract(1);


                        AirQ_C02 = Extract(2);
                        string CRC1 = Extract(1);
                        AirQ_TVOC = Extract(2);
                        CRC1 = Extract(1);

                        Mq2_LPG = Extract(2);
                        Mq2_C02 = Extract(2);
                        Mq2_smoke = Extract(2);


                        temp_sensor = Extract(2);

                        Mq7_C02 = Extract(2);
                        Mq7_adc = Extract(2);

                        Oxygen_Adc = Extract(2);



                    }
                    else if (notifType == "IP Data Notification")
                    {
                        displayMessage = "*" + notifType + "\r\n" + dataIN + "\r\n"; ;
                    }
                    else if (notifType == "Health Report Notification")
                    {
                        macAddress = Extract(8);
                        id = Extract(1);

                        #region id

                        if (id == "80")
                        {
                            id = "Device Health Report";
                        }
                        else if (id == "81")
                        {
                            id = "Neighbors' Health Report";
                        }
                        else if (id == "82")
                        {
                            id = "Discovered Neighbors Health Report";
                        }
                        else if (id == "91")
                        {
                            id = "Extended Health Report";
                        }

                        #endregion


                        displayMessage = "*" + notifType
                        + "\r\n\t" + macAddress + "\r\n\t"
                        + "\r\n\t" + id + "\r\n\t"
                        + dataIN + "\r\n";

                    }


                }

                // reset Packet
                else if (PacketType == "15")
                {
                    rc = Extract(1);
                    macAddress = Extract(8);

                    if (rc == "00")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "Response code: " + rc
                        + "\r\n\t" + "MAC Address: " + macAddress
                        + "\r\n\t" + "Command succesfully completed " + "\r\n\r\n";
                    }
                    else if (rc == "01")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Invalid reset type value " + "\r\n\r\n";
                    }
                    else if (rc == "0E")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "User commands queue is full" + "\r\n\r\n";
                    }
                    else if (rc == "11")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Mote is not in operational state " + "\r\n\r\n";
                    }
                    else if (rc == "12")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Mote with specified MAC address is not found " + "\r\n\r\n";
                    }


                }

                // sendIP Packet
                else if (PacketType == "3B")
                {
                    rc = Extract(1);
                    callbackId = Extract(4);

                    if (rc == "00")
                    {
                        displayMessage = ">sendIP Payload (Page 57): "
                        + "\r\n\t" + "Response code: " + rc
                        + "\r\n\t" + "callbackID: " + callbackId
                        + "\r\n\t" + "Command succesfully completed " + "\r\n\r\n";
                    }
                    else if (rc == "02")
                    {
                        displayMessage = ">sendIP Payload (Page 57): "
                        + "\r\n\t" + "Response code: " + rc
                        + "\r\n\t" + "callbackID: " + callbackId
                        + "\r\n\t" + "Payload size exceeds maximum allowed value or the 6LoWPAN packet is invalid " + "\r\n\r\n";
                    }
                    else if (rc == "0E")
                    {
                        displayMessage = ">sendIP Payload (Page 57): "
                        + "\r\n\t" + "Response code: " + rc
                        + "\r\n\t" + "callbackID: " + callbackId
                        + "\r\n\t" + "User commands queue is full or could not allocate memory buffer for payload " + "\r\n\r\n";
                    }
                    else if (rc == "11")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Mote is not in operational state " + "\r\n\r\n";
                    }
                    else if (rc == "12")
                    {
                        displayMessage = ">reset Payload (Page 53): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "Specified mote is not found " + "\r\n\r\n";
                    }


                }

                // getMoteConfigById Packet 
                else if (PacketType == "41")
                {
                    rc = Extract(1);

                    if (rc == "00")
                    {
                        macAddress = Extract(8);
                        moteId = Extract(2);
                        isAP = Extract(1);
                        state = Extract(1);

                        if (state == "00")
                            state = "lost";
                        else if (state == "01")
                            state = "negotiating";
                        else if (state == "04")
                            state = "operational";


                        displayMessage = ">getMoteConfigById Payload (Page 32): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "macAddress: " + macAddress
                        + "\r\n\t" + "moteId: " + moteId
                        + "\r\n\t" + "state: " + state + "\r\n\r\n";
                    }
                    else if (rc == "12")
                    {
                        displayMessage = ">getMoteConfigById Payload (Page 32): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "moteId: " + moteId
                        + "\r\n\t" + "No such mote " + "\r\n\r\n";
                    }
                   
                }

                // getPathInfo Packet
                else if (PacketType == "30")
                {
                    rc = Extract(1);

                    if (rc == "00")
                    {
                        source = Extract(8);
                        dest = Extract(8);
                        direction = Extract(1);
                        numLinks = Extract(1);
                        quality = Extract(1);
                        rssiSrcDest = Extract(1);
                        rssiDestSrc = Extract(1);

                        displayMessage = "getPathInfo Payload (Page 44): "
                        + "\r\n\t" + "rc: " + Convert.ToInt32(rc, 16)
                        + "\r\n\t" + "source: " + source
                        + "\r\n\t" + "dest: " + dest
                        + "\r\n\t" + "direction: " + direction
                        + "\r\n\t" + "numLinks: " + numLinks
                        + "\r\n\t" + "quality: " + Convert.ToInt32(quality, 16)
                        + "\r\n\t" + "rssiSrcDest: " + rssiSrcDest
                        + "\r\n\t" + "rssiDestSrc: " + rssiDestSrc + "\r\n\r\n";
                    }
                    else
                    {
                        displayMessage = "getPathInfo Payload (Page 44): "
                        + "\r\n\t" + "source: " + Mote_6762.Replace("-", "")
                        + "\r\n\t" + "dest: " + macAddress
                        + "\r\n\t" + "A path between the specified motes doesn't exist " + "\r\n\r\n";
                    }

                }

            }



        }

        public int SendingFlag = 0;

        public void PrepPacket()
        {
            commandError = false;

            // Client Hello message
            if (dataOUT == "hello")
            {
                SequenceNumberInt = 0;
                cliSeqNo = "00";
                version = "04";
                mode = "00";

                Payload = version + cliSeqNo + mode;
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "01";
                Control = "00";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Control = "02";
                //Sending = "\r\n>Sending Hello Packet" + "\r\n\r\n";
                Sending = "\r\n>>Client Hello message" + "\r\n\r\n";
            }

            else if (dataOUT.Contains("getMoteInfo"))
            {
                if (dataOUT.Contains("d018") || dataOUT.Contains("D018"))
                    macAddress = Mote_d018;
                else if (dataOUT.Contains("ba4e") || dataOUT.Contains("BA4E"))
                    macAddress = Mote_ba4e;
                else if (dataOUT.Contains("d2d8") || dataOUT.Contains("D2D8"))
                    macAddress = Mote_d2d8;
                else if (dataOUT.Contains("d38a") || dataOUT.Contains("D38A"))
                    macAddress = Mote_d38a;
                else if (dataOUT.Contains("e1ff") || dataOUT.Contains("E1FF"))
                    macAddress = Mote_e1ff;
                else
                    macAddress = Mote_6762;

                if (stat == 1)
                {
                    macAddress = dataOUT.Replace("getMoteInfo ", "");
                    stat = 0;
                }

                macAddress = macAddress.Replace("-", "");
                Payload = macAddress;
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "3E";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Get mote (" + macAddress + ") statistics" + "\r\n\r\n";
            }

            else if (dataOUT.Contains("getMoteConfig"))
            {
                if (dataOUT.Contains("d018") || dataOUT.Contains("D018"))
                    macAddress = Mote_d018;
                else if (dataOUT.Contains("ba4e") || dataOUT.Contains("BA4E"))
                    macAddress = Mote_ba4e;
                else if (dataOUT.Contains("d2d8") || dataOUT.Contains("D2D8"))
                    macAddress = Mote_d2d8;
                else if (dataOUT.Contains("d38a") || dataOUT.Contains("D38A"))
                    macAddress = Mote_d38a;
                else if (dataOUT.Contains("e1ff") || dataOUT.Contains("E1FF"))
                    macAddress = Mote_e1ff;
                else
                    macAddress = Mote_6762;

                if (dataOUT.Contains("false"))
                    next = "00";
                else
                    next = "01";

                macAddress = macAddress.Replace("-", "");
                Payload = macAddress + next;
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "2F";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Retrieve mote (" + macAddress + ") configuration parameters\r\n\r\n";
            }

            else if (dataOUT.Contains("pingMote"))
            {
                if (dataOUT.Contains("d018"))
                    macAddress = Mote_d018;
                else if (dataOUT.Contains("ba4e"))
                    macAddress = Mote_ba4e;
                else if (dataOUT.Contains("d2d8"))
                    macAddress = Mote_d2d8;
                else if (dataOUT.Contains("d38a"))
                    macAddress = Mote_d38a;
                else if (dataOUT.Contains("e1ff"))
                    macAddress = Mote_e1ff;
                else
                    macAddress = Mote_6762;

                if (dataOUT.Contains("true"))
                    next = "01";
                else
                    next = "00";

                macAddress = macAddress.Replace("-", "");
                Payload = macAddress;
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "2A";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Send a ping to mote (" + macAddress + ")\r\n\r\n";
            }

            else if (dataOUT.Contains("getTime"))
            {
                Payload = "";
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "17";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Return the current manager UTC time and absolute slot number (ASN)\r\n\r\n";
            }

            else if (dataOUT.Contains("getNetworkInfo"))
            {
                Payload = "";
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "40";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Get network statistics\r\n\r\n";
            }

            else if (dataOUT.Contains("sub"))
            {
                if (dataOUT.Contains("e"))
                {
                    Payload = "00-00-00-02" + "FF-FF-FF-FF";
                    notifType = "event notification";
                }
                else if (dataOUT.Contains("l"))
                {
                    Payload = "00-00-00-04" + "FF-FF-FF-FF";
                    notifType = "log notification";
                }
                else if (dataOUT.Contains("d"))
                {
                    Payload = "00-00-00-10" + "FF-FF-FF-FF";
                    notifType = "data payload notification";
                }
                else if (dataOUT.Contains("i"))
                {
                    Payload = "00-00-00-20" + "FF-FF-FF-FF";
                    notifType = "IP data notification";
                }
                else if (dataOUT.Contains("h"))
                {
                    Payload = "00-00-00-40" + "FF-FF-FF-FF";
                    notifType = "health report notification";
                }
                else
                {
                    Payload = "FF-FF-FF-FF" + "FF-FF-FF-FF";
                    notifType = "event, log, data, IP data, and health report notification";
                }

                Payload = Payload.Replace("-", "");
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "16";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Subscribe to " + notifType + "\r\n\r\n";
            }

            else if (dataOUT.Contains("reset"))
            {
                if (dataOUT.Contains("d018") || dataOUT.Contains("D018"))
                    macAddress = Mote_d018;
                else if (dataOUT.Contains("ba4e") || dataOUT.Contains("BA4E"))
                    macAddress = Mote_ba4e;
                else if (dataOUT.Contains("d2d8") || dataOUT.Contains("D2D8"))
                    macAddress = Mote_d2d8;
                else if (dataOUT.Contains("d38a") || dataOUT.Contains("D38A"))
                    macAddress = Mote_d38a;
                else if (dataOUT.Contains("e1ff") || dataOUT.Contains("E1FF"))
                    macAddress = Mote_e1ff;
                else
                    macAddress = Mote_6762;


                if (dataOUT.Contains("system"))
                    type = 0;
                else if (dataOUT.Contains("mote"))
                    type = 2;


                macAddress = macAddress.Replace("-", "");
                Payload = type.ToString("X2") + macAddress;
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "15";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                if (type == 0)
                    Sending = "\r\n>resetting the manager\r\n\r\n";
                else
                    Sending = "\r\n>resetting mote (" + macAddress + ")" + "\r\n\r\n";
            }

            else if (dataOUT.Contains("sendIP"))
            {
                macAddress = "FF-FF-FF-FF-FF-FF-FF-FF";
                priority = 0;
                macAddress = macAddress.Replace("-", "");
                Payload = macAddress + priority.ToString("X2") + "00" + "FF" + "AABBCCDDEEFF";
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "3B";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Sending IP data to a mote\r\n\r\n";
            }

            else if (dataOUT.Contains("getId"))
            {
                moteId = dataOUT.Replace("getId", "");
                moteId = moteId.Replace(" ", "");
                Payload = "00" + (Convert.ToInt32(moteId, 16)).ToString("X2");
                PayloadLengthInt = Payload.Length / 2;
                PacketType = "41";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Retrieve mote configuration parameter by mote ID\r\n\r\n";
            }

            else if (dataOUT.Contains("getPathInfo"))
            {
                if (dataOUT.Contains("d018") || dataOUT.Contains("D018"))
                    macAddress = Mote_d018;
                else if (dataOUT.Contains("ba4e") || dataOUT.Contains("BA4E"))
                    macAddress = Mote_ba4e;
                else if (dataOUT.Contains("d2d8") || dataOUT.Contains("D2D8"))
                    macAddress = Mote_d2d8;
                else if (dataOUT.Contains("d38a") || dataOUT.Contains("D38A"))
                    macAddress = Mote_d38a;
                else if (dataOUT.Contains("e1ff") || dataOUT.Contains("E1FF"))
                    macAddress = Mote_e1ff;
                else
                    macAddress = Mote_d018;

                if (stat == 1)
                {
                    macAddress = dataOUT.Replace("getPathInfo ", "");
                    stat = 0;
                }

                macAddress = macAddress.Replace("-", "");
                Payload = Mote_6762 + macAddress;
                Payload = Payload.Replace("-", "");

                PayloadLengthInt = Payload.Length / 2;
                PacketType = "30";
                dataOUT = Control + PacketType + SequenceNumberInt.ToString("X2") + PayloadLengthInt.ToString("X2") + Payload;
                Sending = "\r\n>Get information about communications between network manager and  mote (" + macAddress + ")\r\n\r\n";
            }

            else if (dataOUT == "help")
            {
                commandError = true;
                Sending = "\r\n>Commands: \r\n\t" +
                    "hello" + "\r\n\t" +
                    "getMoteInfo [last 4 digits of mac Number]" + "\r\n\t" +
                    "getMoteConfig [last 4 digits of mac Number]" + "\r\n\t" +
                    "getPathInfo [last 4 digits of mac Number]" + "\r\n\t" +
                    "pingMote [last 4 digits of mac Number]" + "\r\n\t" +
                    "getTime" + "\r\n\t" +
                    "getNetworkInfo" + "\r\n\t" +
                    "sub [e/l/d/i/h]" + "\r\n\t" +
                    "reset [mote[last 4 digits of mac Number]/system]" + "\r\n\t" +
                    "getId [mote ID]" + "\r\n\t" +
                    "\r\n\r\n";
                SequenceNumberInt--;
            }

            else
            {
                commandError = true;
                Sending = "\r\n>error: command not recognized\r\n\r\n";
                SequenceNumberInt--;
            }
                


            if (commandError == false)
            {
                Response = HexToBytes(dataOUT);
                FCS = Crc16.ComputeChecksum(Response);
                dataOUT = flag + dataOUT + FCS + flag;
                ByteStuffing(1);
                Response = HexToBytes(dataOUT);
                length = dataOUT.Length / 2;
                SequenceNumberInt_Outgoing = SequenceNumberInt;
                SequenceNumberInt = (SequenceNumberInt + 1) % 256;
                SendingFlag = 1;
            }
            
        }



       

    }
}
