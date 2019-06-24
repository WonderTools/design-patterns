using Freecol;
using MdfManufacturers;
using VendorContract;

namespace MyCar
{
    public static class AlarmFactory
    {
        public static IAlarm CreateAlarm(string carType)
        {
            if (carType == "normal") return new Alarm();

            return new FeecolAlarmAdapter(new LowFrequencyAlarm());
        }
    }
}