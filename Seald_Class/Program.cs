using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seald_Class
{
    sealed class Program
    {
        public void Show()
        {
            Console.WriteLine("Response from Program: Show Method");
        }
    }
    class Program2 //: Program
    {
        public void Dekho()
        {
            Console.WriteLine("Response from Program2: Show Method");
        }
    }
    internal class Program3
    { 
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Show();
        }
    }
}
