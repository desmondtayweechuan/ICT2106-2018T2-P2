using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models.SmartDevice.SmartLight
{
    public class MySmartLight : SmartDevice
    {
        
        //Additional Attributes
        public int brightness { get; set; }
        public int colorTemperture { get; set; }

        //Empty Constructor
        public MySmartLight() { }

        //Constructor
        public MySmartLight(int DeviceID, int HouseholdID, String DeviceName, String Location,
        String Brand, String Model, String Type, String State, double UsageKwH, int favourite,
        DateTime timestamp, int brightness, int colorTemperture)
        : base(DeviceID, HouseholdID, DeviceName, Location, Brand, Model, Type, State, UsageKwH, favourite, timestamp)
        {
            this.brightness = 0;
            this.colorTemperture = 3000;
        }

    }
}
