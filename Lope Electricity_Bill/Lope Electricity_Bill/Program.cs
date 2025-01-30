using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lope_Electricity_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of users: ");
            int userCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < userCount; i++)
            {
                Console.Write("Enter the name of user: ");
                string name = Console.ReadLine();

                Console.Write("Enter the number of units consumed: ");
                int units = int.Parse(Console.ReadLine());

                double charges = CalculateCharges(units);

                Console.WriteLine($"User: {name}, Units Consumed: {units}, Charges: Tk. {charges:F2}");
                Console.WriteLine("===Unit price====");
            }
        }

        static double CalculateCharges(int units)
        {
            double charges = 0;

            if (units <= 100)
            {
                charges = units * 1.75;
            }
            else if (units <= 300)
            {
                charges = (100 * 1.75) + ((units - 100) * 2.25);
            }
            else
            {
                charges = (100 * 1.75) + (200 * 2.25) + ((units - 300) * 3.50);
            }

            if (charges < 100)
            {
                charges = 100;
            }

            if (charges > 1000)
            {
                charges += charges * 0.15;
            }

            return charges;
        }
    }
}
      
    

