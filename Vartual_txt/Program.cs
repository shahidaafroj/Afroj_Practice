using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vartual_txt
{
    class Shahida
    {
        public void Show()
        {
            Console.WriteLine("Response from Shahida: Show Method");
        }
        public void show(string s)
        {
            Console.WriteLine("Response from Shahida: Show Method" + s);
        }
        public virtual void Dekho()
        {
            Console.WriteLine("Response from Shahida: Dekho Method");
        }
    }
    class Afroj:Shahida
    {
        public override void Dekho()
        {
            Console.WriteLine("Response from Afroj: Dekho Method");
        }
    }
    class Bokul:Afroj
    {
        public override void Dekho()
        {
            Console.WriteLine("Response from Bokul: Dekho Method");
        }
    }
    internal class Program
    {
    static void Main(string[] args)
        {
            Bokul Bo1 = new Bokul();
            Bo1.Dekho();
        }
    }
}
