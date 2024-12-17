using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Example : IEnumerable<string>
    {
        List<string> _element;
        public Example(string[] array)
        {
            this._element = new List<string>(array);
        }
        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            Console.WriteLine("Here............");
            return this._element.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._element.GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example(new string[] {"Mouse","Keyboard","Monitor","Printer" });
            foreach (string element in example)
            { 
             Console.WriteLine(element);
            }
        }
    }
}
