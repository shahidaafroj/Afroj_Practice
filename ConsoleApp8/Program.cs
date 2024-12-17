using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Swap<T>(ref T SA, ref T ZB)
        {
            T temp;
            temp = SA;
            SA = ZB;
            ZB = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = 27;
            b = 3;
            char c = 'D';
            char d = 'K';
            Console.WriteLine("Before Swaping");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("After Awaping");
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
