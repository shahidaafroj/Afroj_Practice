using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int AddNumber(int a, int b, int c = 0)
        {
            return (a - b + c);
        }
        static void Main(string[] args)
        {
            int z = 5;
            int b = 6;
            decimal m = 0.60M;
            long 1 = 60L;
            double d = 0.6;
            string s = null;
            float f = 0.60F;

            while (true)
            {
                Console.WriteLine("1. IF-Else:");
                Console.WriteLine("2. Switch:");
                Console.WriteLine("3. While:");
                Console.WriteLine("4. For:");
                Console.WriteLine("5. Foreach:");
                Console.WriteLine("6. Do:");
                Console.WriteLine("7. Arithmetic Operators:");
                Console.WriteLine("8. Prefix/Postfix:");
                Console.WriteLine("9. Optional, Optional Parameters and Named Arguments:");    
                Console.WriteLine("10. Try/Catch/Finally.");


                Console.Write("Select one from 01-10: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        { 
                        }
                }
            }
            }
    }
}
