using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //01.FOR LOOP
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine(i);
                //}

                //02.DO LOOP
                //int j = 0;
                //do
                //{
                //    Console.WriteLine(j);
                //    j++;
                //} 
                //while (j < 10);

                //03.WHILE LOOP
                //int k = 0;
                //while (k < 10)
                //{
                //    Console.WriteLine(k);
                //    k++;
                //}

                //04.SWITCH
                //Console.Write("Give a Number: ");
                //int a = Convert.ToInt32(Console.ReadLine());
                //switch (a)
                //{ 
                //    case 0:
                //            {
                //                Console.WriteLine("Saturday");
                //                break;
                //            }
                //    case 1:
                //            {
                //                Console.WriteLine("Sunday");
                //                break;
                //            }
                //    case 2:
                //            {
                //                Console.WriteLine("Monday");
                //                break;
                //            }
                //    case 3:
                //            {
                //                Console.WriteLine("Tuesday");
                //                break;
                //            }
                //    case 4:
                //            {
                //                Console.WriteLine("Wednesday");
                //                break;
                //            }
                //    default:
                //            {
                //                Console.WriteLine("Give valid Number to get Day!!!");
                //                break;
                //            }   
                //}
                //05.IF, ELSE IF
                //Console.Write("Give a Number:");
                //int a = Convert.ToInt32(Console.ReadLine());
                //if (a < 5)
                //{
                //    Console.WriteLine("This number less than 5");
                //}
                //else if (a > 5 && a < 15)
                //{ 
                //    Console.WriteLine("This number between 5 and 15");
                //}

                //06.ELSE
                //Console.Write("Give a Number:");
                //int a = Convert.ToInt32(Console.ReadLine());
                //if (a < 10)
                //{
                //    Console.WriteLine("This number is less than 10.");
                //}
                //else 
                //{
                //Console.WriteLine("This number is 10 or More.");
                //}

                //07.METHOD
                //Method with parameters and return type
                Console.Write("Give a Number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give another Number:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Result is: " + Add(a, b));
                //Program p= new Program();
                //Console.WriteLine("The Result is: "+.Multiply(a, b));
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        //int Multiply(int a, int b)
        //{
        //    return a * b; 
        //}
    }
}
        
