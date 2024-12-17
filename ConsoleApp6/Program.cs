using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Izhaan
    {
        public Izhaan()
        {
            Console.WriteLine("Default Constructor.....");
        }
        ~Izhaan()
        { 
        Console.WriteLine("Destractor........");
        }
        public void Dispose()
        { 
         GC.SuppressFinalize(this);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Izhaan izhaan = new Izhaan();  //Created an unmanaged memory instance
            try
            {
                Console.WriteLine("Try............");
                // Izhaan = new Izhaan();     // Memory gets created
                //  Do some task
            }
            finally
            {
               // Izhaan.Dispose();    //memory gets cleared
                Console.WriteLine("Finally......");
            }
            }
        }
    }

