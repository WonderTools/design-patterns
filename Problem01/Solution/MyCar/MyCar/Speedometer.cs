using System;
using System.Collections.Generic;

namespace MyCar
{
    public class Speedometer
    {
        private readonly SpeedAlarm _alarm;

        List<ISpeedObserver> _observers = new List<ISpeedObserver>();

        public void RegisterObserver(ISpeedObserver speedObserver)
        {
            _observers.Add(speedObserver);
        }

        public Speedometer(CarSpeedSimulator speedSimulator, SpeedAlarm alarm)
        {
            _alarm = alarm;
            speedSimulator.SpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(int speed)
        {
            Console.WriteLine("Current Speed :" + speed);
            foreach (var speedObserver in _observers)
            {
                speedObserver.OnSpeedChange(speed);
            }
        }
    }
}