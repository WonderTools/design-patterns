using WonderTools.VendorContract;

namespace WonderTools.MyCar
{
    public class SeatBelt : ISpeedObserver
    {

        private IAlarm _alarm;
        private int _oldSpeed = 0;
        private bool _isLocked = false;

        public void SetSpeedSource(ISpeedSource speedSource)
        {
            speedSource.AddSpeedObserver(this);
        }

        public void SetAlarm(IAlarm alarm)
        {
            _alarm = alarm;
        }

        public void Lock()
        {
            _isLocked = true;
        }

        public void UnLock()
        {
            _isLocked = false;
        }

        public void OnSpeedChange(int speed)
        {
            if ((_oldSpeed < 20) && (speed >= 20))
            {
                _alarm?.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }
}