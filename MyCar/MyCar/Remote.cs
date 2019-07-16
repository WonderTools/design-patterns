using System;
using System.Net.Mime;

namespace WonderTools.MyCar
{
    public class Remote
    {
        private readonly ICommandFactory _commandFactory;

        public Remote(ICommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        public void HandleUserInput()
        {
            Console.WriteLine("Please press the option");
            Console.WriteLine("i/I for increase speed");
            Console.WriteLine("d/D for decrease speed");
            Console.WriteLine("u/U for unlock");
            Console.WriteLine("l/L for lock");
            Console.WriteLine("e/E for exit the application");

            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                var keyChar = key.KeyChar;
                var optionString = keyChar.ToString().ToLower();

                if (optionString == "i") _commandFactory.GetICommand().Execute();
                else if (optionString == "d") _commandFactory.GetDCommand().Execute();
                else if (optionString == "l") _commandFactory.GetLCommand().Execute();
                else if (optionString == "u") _commandFactory.GetUCommand().Execute();
                else if (optionString == "e") _commandFactory.GetECommand().Execute();
                else Console.WriteLine("unknown option");
            }
        }
    }
}