using System;

namespace MyCar
{
    public class Speedometer
    {
        private readonly SpeedAlarm _alarm;

        public Speedometer(CarSpeedSimulator speedSimulator, SpeedAlarm alarm)
        {
            _alarm = alarm;
            speedSimulator.SpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(int speed)
        {
            Console.WriteLine("Current Speed :" + speed);
            _alarm.ProcessSpeed(speed);
        }
    }
}