using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Biddut_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Name Of The User:");
            String name = Console.ReadLine();

            Console.Write("Enter The Number Of Units Consumed:");
            int units = int.Parse(Console.ReadLine());

            //step-By-step calculation based on the slab rates
            double cost = 0;

            if (units <= 100)
            {
                cost = units * 1.75;
            }
            else if (units <= 300)
            {
                cost = (100 * 1.75) + ((units - 100) * 2.25);
            }
            else
            {
                cost = (100 * 1.25) + (200 * 2.25) + ((units - 300) * 3.50);
            }
            //Check if total cost is more than TK. 1000
            if (cost > 1000)
            {
                double excessAmount = cost - 1000;
                double surcharge = excessAmount * 0.15;
                cost += surcharge;
            }
            //Ensure a minimum charge of TK.100
            if(cost < 100)
            {
                cost = 100;
            }
            //Display the result
            Console.WriteLine($"\nuser:{name}");
            Console.WriteLine($"Units consumed:{units}");
            Console.WriteLine($"Total Charge:TK.{cost:F2}\n");
        }
    }
}
