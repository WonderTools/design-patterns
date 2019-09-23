using Freecol;
using WonderTools.VendorContract;

namespace MyCarBootstrap
{
    public class FreecolAlarmAdapter : IAlarm
    {
        private readonly LowFrequencyAlarm _alarm;

        public FreecolAlarmAdapter(LowFrequencyAlarm alarm)
        {
            _alarm = alarm;
        }
        public void RaiseAlarm()
        {
            _alarm.Beep();
        }
    }
}