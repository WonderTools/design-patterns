using System;
using WonderTools.VendorContract;

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