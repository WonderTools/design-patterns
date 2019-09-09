using System;

namespace MyCar
{
    public class SpeedAlarm : ISpeedObserver
    {
        private readonly Alarm _alarm;
        private int _oldSpeed = 0;

        public SpeedAlarm(Alarm alarm)
        {
            _alarm = alarm;
        }
        private void ProcessSpeed(int speed)
        {
            if ((_oldSpeed < 80) && (speed >= 80))
            {
                _alarm.RaiseAlarm();
            }
            _oldSpeed = speed;
        }

        public void OnSpeedChange(int speed)
        {
            ProcessSpeed(speed);
        }
    }

    public class SeatBelt : ISpeedObserver
    {
        private readonly Alarm _alarm;
        private bool _isLocked = false;
        private int _oldSpeed = 0;

        public SeatBelt(Alarm alarm)
        {
            _alarm = alarm;
        }

        public void Lock()
        {
            _isLocked = true;
            Console.WriteLine("Seat Belt Locked");
        }

        public void UnLock()
        {
            _isLocked = false;
            Console.WriteLine("Seat Belt Unlocked");
        }

        public void OnSpeedChange(int speed)
        {
            if((_oldSpeed < 20) && (speed >= 20) && (_isLocked == false)) _alarm.RaiseAlarm();
            _oldSpeed = speed;
        }
    }
}