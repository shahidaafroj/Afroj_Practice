using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }

    interface IMyInterface : IParentInterface
    {
        void MethodToImplement();
    }

    //interface ITestInterface:IMyInterface,IParentInterface
    //{

    //}

    internal class Program : IMyInterface
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ParentInterfaceMethod();
            program.MethodToImplement();
        }

        public void MethodToImplement()
        {
            Console.WriteLine("Response from MethodToImplement.......");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("Response from ParentInterfaceMethod.....");
        }
    }
}
