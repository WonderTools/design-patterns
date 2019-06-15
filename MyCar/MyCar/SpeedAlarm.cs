namespace WonderTools.MyCar
{
    public class SpeedAlarm : ISpeedObserver
    {
        private readonly Alarm _alarm;
        private int _oldSpeed = 0;

        public SpeedAlarm(Alarm alarm, Speedometer speedometer)
        {
            _alarm = alarm;
            speedometer.AddSpeedObserver(this);
        }

        public void OnSpeedChange(int speed)
        {
            if ((_oldSpeed < 80) && (speed >= 80))
            {
                _alarm.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }

    public class SeatBelt : ISpeedObserver
    {

        private readonly Alarm _alarm;
        private int _oldSpeed = 0;
        private bool _isLocked = false;

        public SeatBelt(Alarm alarm, Speedometer speedometer)
        {
            _alarm = alarm;
            speedometer.AddSpeedObserver(this);
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
                _alarm.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }
}