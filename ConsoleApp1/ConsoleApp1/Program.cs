using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 3;
            Console.WriteLine("Please Enter The Frist Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Writeline("================================================");
            //Console.WriteLine(a+b);
            //Console.WriteLine(a-b);
            //Console.WriteLine(a*b);
            //Console.WriteLine(a/b);
            //Console.WriteLine(a%b);

            //Console.WriteLine($"{a} + {b}" + " = " + (a + b));
            //Console.WriteLine($"{a} - {b}" + " = " + (a - b));
            //Console.WriteLine($"{a} * {b}" + " = " + (a * b));
            //Console.WriteLine($"{a} / {b}" + " = " + (a / b));
            //Console.WriteLine($"{a} % {b}" + " = " + (a % b));

            if (a >= 0 && b >= 0 && a >= b)
            {
                Console.WriteLine($"{a} + {b}" + " = " + (a + b));
                Console.WriteLine($"{a} - {b}" + " = " + (a - b));
                Console.WriteLine($"{a} * {b}" + " = " + (a * b));
                Console.WriteLine($"{a} / {b}" + " = " + (a / b));
                Console.WriteLine($"{a} % {b}" + " = " + (a % b));
            }
            else if (b > a)
            {
                Console.WriteLine("Divisable number should be higher the dividend number!!!");
            }
            else
            {
                Console.WriteLine("Error Found!!!");
            }
        }
    }
}