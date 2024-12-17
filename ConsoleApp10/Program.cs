using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    // a delegate is that it does not know or care about the class of the object that it references.
    // Any object will do; all that matters is that the method's argument types and return type match the delegate's. 
    // This makes delegates perfectly suited for "anonymous" invocation.
    // Syntax:   delegate result-type identifier ([parameters]);
    // A delegate will allow us to specify what the function we'll be calling looks like without having to specify which function to call.
    // The declaration for a delegate looks just like the declaration for a function, except that in this case, we're declaring the signature of functions that this delegate can reference.

    internal class Program
    {
        delegate int MyDelegate(int x);
        static void Main(string[] args)
        {
            MyDelegate md01 = y => y * 10;
            MyDelegate md02 = y => y * y * 60;
            MyDelegate md03 = y => y * 100;

            int S = md01(5);
            Console.WriteLine(S);
            Console.WriteLine(md02(20));
            Console.WriteLine(md03(80));
        }
    }
}
