using System;

namespace WonderTools.MyCar
{
    public class CarCommandFactory : ICommandFactory
    {
        private readonly Car _car;

        public CarCommandFactory(Car car)
        {
            _car = car;
        }
        public Command GetICommand()
        {
            return new Command(() => _car.IncreaseSpeed());
        }

        public Command GetDCommand()
        {
            return new Command(() => _car.DecreaseSpeed());
        }

        public Command GetLCommand()
        {
            return new Command(() => _car.Lock());
        }

        public Command GetUCommand()
        {
            return new Command(() => _car.Unlock());
        }

        public Command GetECommand()
        {
            return new Command(()=> Environment.Exit(0));
        }
    }
}