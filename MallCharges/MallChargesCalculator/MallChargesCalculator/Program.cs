using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallChargesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the id of the property to rent");
                var propertyIdAsString = Console.ReadLine();
                Int32.TryParse(propertyIdAsString, out var id);
                ChargesCalculatingFacade facade = new ChargesCalculatingFacade();
                facade.DisplayRentingCharges(id);
                Console.WriteLine("Do you want to continue? [y/n]");
            } while (Console.ReadKey().KeyChar != 'n');
        }
    }
}
