using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int largest = a;
            if (b > largest)
            {
                largest = b;
            }
            if (c > largest) ;
            {
                largest = c;
            }
            int smallest = a;
            if (b < smallest)
            {
                smallest = b;
            }
            if (c < smallest)
            {
                smallest = c;
            }

            Console.WriteLine("The Largest Number is:" + largest);
            Console.WriteLine("The Smallest Number is:" + smallest);
        }
    }
}
