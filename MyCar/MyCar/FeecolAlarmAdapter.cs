using Freecol;
using WonderTools.VendorContract;

namespace WonderTools.MyCar
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