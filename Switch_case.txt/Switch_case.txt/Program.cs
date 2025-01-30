using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 0:
                    {
                        Console.WriteLine("Shahida");
                        break;
                    }
                case 1:
                    { Console.WriteLine("Zannat");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Juhan");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Enter a Valid Number!!!!!!!!!!!");
                        break;
                    }

            }
        }
    }
}
