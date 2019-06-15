using System;

namespace MyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press the option");
            Console.WriteLine("i/I for increase car speed");
            Console.WriteLine("d/D for decrease car speed");
            Console.WriteLine("e/E for decrease car speed");


            var simulator = new CarSpeedSimulator();
            var alarm = new Alarm();
            var speedAlarm = new SpeedAlarm(alarm);
            var speedometer = new Speedometer(simulator, speedAlarm);
            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                var keyChar = key.KeyChar;
                if ((keyChar == 'i') || (keyChar == 'I'))
                {
                    simulator.Increase();
                }
                else if ((keyChar == 'd') || (keyChar == 'D'))
                {
                    simulator.Decrease();
                }
                else if ((keyChar == 'e') || (keyChar == 'E')) break;
            }
        }
    }
}
