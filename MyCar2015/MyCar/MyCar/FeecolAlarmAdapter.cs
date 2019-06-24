using Freecol;
using VendorContract;

namespace MyCar
{
    public class FeecolAlarmAdapter : IAlarm
    {
        private readonly LowFrequencyAlarm _lowFrequencyAlarm;

        public FeecolAlarmAdapter(LowFrequencyAlarm lowFrequencyAlarm)
        {
            _lowFrequencyAlarm = lowFrequencyAlarm;
        }

        public void RaiseAlarm()
        {
            _lowFrequencyAlarm.Beep();
        }
    }
}