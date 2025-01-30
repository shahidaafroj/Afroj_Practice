using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int Value = 1;
            for (int i =1; i <=a; i++) 
            {
                Value = Value * i;
            }
            Console.WriteLine(Value);
        }
    }
}
