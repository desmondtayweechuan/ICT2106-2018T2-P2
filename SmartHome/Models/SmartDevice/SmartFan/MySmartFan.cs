using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models.SmartDevice.SmartFan
{
    public class MySmartFan : SmartDevice
    {
        //Additional Attributes
        public int fanSpeed { get; set; }

        //Empty Constructor
        public MySmartFan() { }

        //Constructor
        public MySmartFan(int DeviceID, int HouseholdID, String DeviceName, String Location,
        String Brand, String Model, String Type, String State, double UsageKwH, int favourite,
        DateTime timestamp, int fanSpeed)
        : base(DeviceID, HouseholdID, DeviceName, Location, Brand, Model, Type, State, UsageKwH, favourite, timestamp)
        {
            this.fanSpeed = 0;
        }

    }
}
