using System;

namespace WonderTools.MyCar
{
    public class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.Beep(500, 500);
        }
    }
}