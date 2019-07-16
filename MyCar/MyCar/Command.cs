using System;

namespace WonderTools.MyCar
{
    public class Command
    {
        private readonly Action _action;

        public Command(Action action)
        {
            _action = action;
        }

        public void Execute()
        {
            _action.Invoke();
        }
    }
}