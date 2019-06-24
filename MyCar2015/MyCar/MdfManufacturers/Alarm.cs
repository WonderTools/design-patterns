using System;
using VendorContract;

namespace MdfManufacturers
{
    public class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.Beep(500, 500);
        }
    }
}