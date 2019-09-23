using System;
using Freecol;
using MdfManufacturers;
using WonderTools.VendorContract;

namespace MyCarBootstrap
{
    public static class AlarmFactory
    {
        public static IAlarm CreateAlarm(string type)
        {
            if(type == "hiEnd") return new FreecolAlarmAdapter(new LowFrequencyAlarm());
            if (type == "normal") return new Alarm();
            throw new Exception("Unknown type");
        }
    }
}