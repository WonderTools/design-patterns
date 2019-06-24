using Freecol;
using MdfManufacturers;
using WonderTools.VendorContract;

namespace WonderTools.MyCar
{
    public static class AlarmFactory
    {
        public static IAlarm CreateAlarm(string carType)
        {
            if(carType == "normal") return new Alarm();
            
            return new FeecolAlarmAdapter(new LowFrequencyAlarm());
        }
    }
}