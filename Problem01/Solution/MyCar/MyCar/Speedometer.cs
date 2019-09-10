using System;
using System.Collections.Generic;

namespace MyCar
{
    public class Speedometer
    {
        List<ISpeedObserver> _observers = new List<ISpeedObserver>();

        public void RegisterObserver(ISpeedObserver speedObserver)
        {
            _observers.Add(speedObserver);
        }

        public Speedometer(CarSpeedSimulator speedSimulator)
        {
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