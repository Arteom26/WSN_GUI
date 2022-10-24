using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMIP_Network
{
    class ManagetToPhone
    {

        public string Manager_To_Phone { get; set; }
    }




    public class PMS
    {
        //partical sensors 

        public string PMS_PM1 { get; set; }
        public string PMS_PM2_5 { get; set; }
        public string PMS_PM10 { get; set; }
    }

    public class PMS_Count
    {
        public string PMS_PCount0_5 { get; set; }
        public string PMS_PCount1 { get; set; }
        public string PMS_PCount2_5 { get; set; }
        public string PMS_PCount5 { get; set; }
        public string PMS_PCount7_5 { get; set; }
        public string PMS_PCount10 { get; set; }
    }


    public class Mq2
    {
        public string Mq2_Co2 { get; set; }
        public string Mq2_Smoke { get; set; }
        public string Mq2_LPG { get; set; }
    }

    public class Mq7
    {
        public string Mq7_Co2 { get; set; }
    }

    public class Airquality
    {
        public string Airquality_Co2 { get; set; }
        public string Airquality_TVOC { get; set; }
    }

    public class Oxygen
    {
        public string Oxygen_level { get; set; }
    }

    public class Mote_temp
    {
        public string Mote1_temp { get; set; }

    }
}
