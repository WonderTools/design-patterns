using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorContract;

namespace MdfManufacturers
{
    public class Class1
    {
    }

    public class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.Beep(500, 500);
        }
    }
}
