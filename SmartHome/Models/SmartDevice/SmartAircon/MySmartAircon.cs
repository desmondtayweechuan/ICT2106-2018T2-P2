using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models.SmartDevice.SmartAircon
{
    public class MySmartAircon : SmartDevice
    {

        //Additional Attributes
        public int temperature { get; set; }
        public string mode { get; set; }
        public string windspeed { get; set; }
        public string swing { get; set; }

        //Empty Constructor
        public MySmartAircon() { }


        //Constructor
        public MySmartAircon(int DeviceID, int HouseholdID, String DeviceName, String Location,
        String Brand, String Model, String Type, String State, double UsageKwH, int favourite, 
        DateTime timestamp, int temperature, string mode, string windspeed, string swing)
        :base(DeviceID, HouseholdID, DeviceName, Location, Brand, Model, Type, State, UsageKwH, favourite, timestamp)
        {
            this.temperature = 12;
            this.mode = "a";
            this.windspeed = "a";
            this.swing = "a";
        }

    }
}
