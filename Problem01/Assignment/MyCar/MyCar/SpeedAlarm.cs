namespace MyCar
{
    public class SpeedAlarm
    {
        private readonly Alarm _alarm;
        private int _oldSpeed = 0;

        public SpeedAlarm(Alarm alarm)
        {
            _alarm = alarm;
        }
        public void ProcessSpeed(int speed)
        {
            if ((_oldSpeed < 80) && (speed >= 80))
            {
                _alarm.RaiseAlarm();
            }
            _oldSpeed = speed;
        }
    }
}