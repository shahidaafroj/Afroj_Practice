using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Method
{
    abstract class Zannat
    {
        public void Show()
        {
            Console.WriteLine("Response from Zannat: Show Method");
        }
        public abstract void Test();

    }

    class Shahida : Zannat
    {
        public void Dekho()
        {
            Console.WriteLine("Response from Shahida: Dekho Method");
        }

        public override void Test()
        {
            Console.WriteLine("Response from Shahida: Test Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zannat zannat = new Zannat();
            //zannat.Show();

            Shahida shahida = new Shahida();
            shahida.Test();
        }
    }
}
