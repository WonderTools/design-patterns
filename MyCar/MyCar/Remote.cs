using System;

namespace WonderTools.MyCar
{
    public class Remote
    {
        private readonly Car _car;

        public Remote(Car car)
        {
            _car = car;
        }

        public void HandleUserInput()
        {
            Console.WriteLine("Please press the option");
            Console.WriteLine("i/I for increase car speed");
            Console.WriteLine("d/D for decrease car speed");
            Console.WriteLine("u/U for unlock car");
            Console.WriteLine("l/L for lock car");
            Console.WriteLine("e/E for exit the application");

            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                var keyChar = key.KeyChar;
                var optionString = keyChar.ToString().ToLower();

                if (optionString == "i") _car.IncreaseSpeed();
                else if (optionString == "d") _car.DecreaseSpeed();
                else if (optionString == "l") _car.Lock();
                else if (optionString == "u") _car.Unlock();
                else if (optionString == "e") break;
                else Console.WriteLine("unknown option");
            }
        }
    }
}