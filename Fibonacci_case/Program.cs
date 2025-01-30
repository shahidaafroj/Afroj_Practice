using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_case
{
    internal class Program
    {
       
          static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");
            int mynum = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            int c = 4;
            int a = 7;
            for (int i = 0; i < mynum; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
             }
        }
    }
}
