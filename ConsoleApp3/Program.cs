using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Zannat
    {
        public void Show()
        {
            Console.WriteLine("Response from Zannat: Show Method");
        }

        public void Show(string s)
        {
            Console.WriteLine("Response from Zannat: Show Method " + s);
        }

        public virtual void Dekho()
        {
            Console.WriteLine("Response from Zannat: Dekho Method");
        }
    }

    class Shahida : Zannat
    {
        sealed public override void Dekho()
        {
            Console.WriteLine("Response from Shahida: Dekho Method");
        }
    }
    class Shuvo : Shahida
    {
        //public override void Dekho()
        //{
        //    Console.WriteLine("Response from Shuvo: Dekho Method");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shuvo sh1 = new Shuvo();
            sh1.Dekho();
        }
    }
}
