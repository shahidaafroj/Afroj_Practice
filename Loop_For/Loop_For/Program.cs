using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Loop_For
{
    internal class Program
    {
        public static bool StartNo { get; private set; }

        static void Main(string[] args)
        {
            int a = 5;
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }

            // Console.WriteLine("Please Enter The end Number.");
            //  int StartNO = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Please Enter The end Number.");
            //  int endNo = Convert.ToInt32(Console.ReadLine());
            //  for (int i = 1; i <= endNo; i++)
            // {
            //     Console.WriteLine(i);
            // }


            // Console.WriteLine("Please Enter The end Number.");
            // int StartNO = Convert.ToInt32(Console.ReadLine());
            //  Console.Write("Please Enter The end Number.");
            //  int endNo = Convert.ToInt32(Console.ReadLine());
            //  do
            //  {
            //      Console.WriteLine(StartNO);
            //      StartNO++;
            //  }
            //  while (StartNO <= endNo);
            //      {
            //         Console.WriteLine(StartNo);
            //         StartNO++;
            //     }

            //Pattern
            // Console.WriteLine("Please Enter The end Number.");
            // int StartNO = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Please Enter The end Number.");
            // int endNo = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine();
            // Console.WriteLine("===========Result===========");
            // Console.WriteLine();
            //  for (int i = StartNO; i <= endNo; i++)
            //  {
            //     Console.Write(" * ");
            // }
            // Console.WriteLine();
            // Console.ReadLine();


            Console.WriteLine("Please Enter The end Number.");
            int StartNO = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter The end Number.");
            int endNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("===========Result===========");
            Console.WriteLine();
            for (int i = StartNO; i <= endNo; i++)
            {
                for (int s = i; s <= endNo; s++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
