using System;
using WonderTools.VendorContract;

namespace WonderTools.MyCar
{
    public class VerifyingAlarmProxy : IAlarm
    {
        private readonly IAlarm _alarm;
        private readonly string _mode;

        public VerifyingAlarmProxy(IAlarm alarm, string mode)
        {
            _alarm = alarm;
            _mode = mode;
        }

        public void RaiseAlarm()
        {
            if (_mode == "testing" || _mode == "verification")
            {
                Log();
            }

            if (_mode != "testing")
            {
                _alarm.RaiseAlarm();
            }

        }

        private void Log()
        {
            Console.WriteLine("Alarm Raised");
        }
    }
}