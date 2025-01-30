using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even.Txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please Enter a Number:");
            // int a = Convert.ToInt32(Console.ReadLine());
            // if (a % 2 != 0) 
            // {
            //    Console.WriteLine("ODD");
            //}
            //else
            //{
            //    Console.WriteLine("EVEN");
           // }


            Console.WriteLine("Please Enter a Number:");
             int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ODD Number" + "\t" + "Even Number");
            for (int i = 1; i<=; i++)
            {
                if (i % 2 !=0)
                {
                    Console.WriteLine(i + "\t");
                }
                else
                {
                    Console.WriteLine("\t" + i);
                }
            }
        }
    }
}
