using System;
using System.Configuration;
using VendorContract;

namespace MyCar
{
    class Bootstrap
    {
        static void Main(string[] args)
        {
            var carType = ConfigurationManager.AppSettings["carType"];
            var mode = ConfigurationManager.AppSettings["mode"];

            Console.WriteLine(carType);
            Console.WriteLine(mode);



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
    }
}