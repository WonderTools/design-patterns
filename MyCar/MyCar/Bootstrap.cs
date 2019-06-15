using System;

namespace WonderTools.MyCar
{
    class Bootstrap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press the option");
            Console.WriteLine("i/I for increase car speed");
            Console.WriteLine("d/D for decrease car speed");
            Console.WriteLine("u/U for unlock car");
            Console.WriteLine("l/L for lock car");
            Console.WriteLine("e/E for exit the application");

            var simulator = new CarSpeedSimulator();
            var speedometer = new Speedometer(simulator);

            var alarm = new Alarm();
            var speedAlarm = new SpeedAlarm(alarm, speedometer);
            var seatBelt = new SeatBelt(alarm, speedometer);

            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                var keyChar = key.KeyChar;
                var optionString = keyChar.ToString().ToLower();

                if (optionString == "i") simulator.Increase();
                else if (optionString == "d") simulator.Decrease();
                else if (optionString == "l") seatBelt.Lock();
                else if (optionString == "u") seatBelt.UnLock();
                else if (optionString == "e") break;
                else Console.WriteLine("unknown option");
            }
        }
    }
}
