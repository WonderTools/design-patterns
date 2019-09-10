namespace MyCar
{
    public class SpeedAlarm : ISpeedObserver
    {
        private readonly Alarm _alarm;
        private int _oldSpeed = 0;

        public SpeedAlarm(Alarm alarm, Speedometer speedometer)
        {
            _alarm = alarm;
            speedometer.RegisterObserver(this);
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
}