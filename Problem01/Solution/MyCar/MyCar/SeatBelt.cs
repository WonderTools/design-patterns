using System;

namespace MyCar
{
    public class SeatBelt : ISpeedObserver
    {
        private readonly Alarm _alarm;
        private bool _isLocked = false;
        private int _oldSpeed = 0;

        public SeatBelt(Alarm alarm, Speedometer speedometer)
        {
            _alarm = alarm;
            speedometer.RegisterObserver(this);
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