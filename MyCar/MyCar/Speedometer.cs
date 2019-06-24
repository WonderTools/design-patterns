using System;
using System.Collections.Generic;

namespace WonderTools.MyCar
{
    public interface ISpeedSource
    {
        void AddSpeedObserver(ISpeedObserver speedObserver);
    }

    public class Speedometer : ISpeedSource
    {
        List<ISpeedObserver> _speedObservers = new List<ISpeedObserver>();

        public Speedometer(CarSpeedSimulator speedSimulator)
        {
            speedSimulator.SpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(int speed)
        {
            Console.WriteLine("Current Speed :" + speed);
            foreach (var speedObserver in _speedObservers)
            {
                speedObserver.OnSpeedChange(speed);
            }

        }

        public void AddSpeedObserver(ISpeedObserver speedObserver)
        {
            _speedObservers.Add(speedObserver);
        }
    }
}