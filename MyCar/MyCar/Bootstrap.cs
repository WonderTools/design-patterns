using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using WonderTools.VendorContract;

namespace WonderTools.MyCar
{
    class Bootstrap
    {
        static void Main(string[] args)
        {
            var configuration = GetConfiguration();

            var carType = configuration.GetSection("carType").Value;
            Console.WriteLine("The car type is :"+ carType);

            var mode = configuration.GetSection("mode").Value;
            Console.WriteLine("The mode is :" + mode);
            var car = BuildCar(carType, mode);

            var remote = new Remote(car);
            remote.HandleUserInput();
        }

        

        private static Car BuildCar(string carType, string mode)
        {
            var simulator = new CarSpeedSimulator();
            var speedometer = new Speedometer(simulator);

            IAlarm alarm = AlarmFactory.CreateAlarm(carType);
            alarm = new VerifyingAlarmProxy(alarm, mode);

            var speedAlarm = new SpeedAlarm();

            var seatBelt = new SeatBelt();

            Car car = new Car(alarm, seatBelt, simulator, speedometer, speedAlarm);
            return car;
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            return configuration;
        }
    }
}
