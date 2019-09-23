using System;

namespace WonderTools.MyCar
{
    public class CarSpeedSimulator
    {
        private int _speed;
        public Action<int> SpeedChanged;

        public int Speed
        {
            get => _speed;
            set
            {
                if (_speed != value)
                {
                    _speed = value;
                    SpeedChanged?.Invoke(_speed);
                }
            }
        }

        public void Increase()
        {
            if (Speed >= 220) return;
            Speed = Speed + 10;
        }

        public void Decrease()
        {
            if (Speed <= 0) return;
            Speed = Speed - 10;
        }
    }
}