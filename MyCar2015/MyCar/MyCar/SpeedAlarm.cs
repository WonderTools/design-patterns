using VendorContract;

namespace MyCar
{
    public class SpeedAlarm : ISpeedObserver
    {
        private IAlarm _alarm;
        private int _oldSpeed = 0;

        public void SetAlarm(IAlarm alarm)
        {
            _alarm = alarm;
        }

        public void SetSpeedSource(ISpeedSource speedSource)
        {
            speedSource.AddSpeedObserver(this);
        }

        public void OnSpeedChange(int speed)
        {
            if ((_oldSpeed < 80) && (speed >= 80))
            {
                _alarm?.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }
}