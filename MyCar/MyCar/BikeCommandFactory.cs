using System;

namespace WonderTools.MyCar
{
    public class BikeCommandFactory : ICommandFactory
    {
        private readonly Bike _bike;

        public BikeCommandFactory(Bike bike)
        {
            _bike = bike;
        }

        public Command GetICommand()
        {
            return new Command(()=> _bike.SpeedUp());
        }

        public Command GetDCommand()
        {
            return new Command(() => _bike.SpeedDown());
        }

        public Command GetLCommand()
        {
            return new Command(() => { Console.WriteLine("Unsupported operation");});
        }

        public Command GetUCommand()
        {
            return new Command(() => { Console.WriteLine("Unsupported operation"); });
        }

        public Command GetECommand()
        {
            return new Command(() => Environment.Exit(0));
        }
    }
}