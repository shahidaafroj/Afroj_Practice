using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MyGenericClass<T>
    {
        private T[] myArray;
        public MyGenericClass(int size)
        { 
         myArray = new T[size + 1];
        }
        public T MyGetItem(int mi)
        { 
         return myArray[mi];
        }
        public void MySetItem(int mi, T value)
        { 
         myArray[mi] = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring an int Array
            MyGenericClass<int> mia = new MyGenericClass<int>(5);
            //Setting Values
            for (int i = 0; i < 5; i++)
            { 
             mia.MySetItem(i, i * 3);
            }
            //Getting Values
            for (int i = 0; i < 5; i++)
            {
                Console.Write(mia.MyGetItem(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine();

            //Declaring an char Array
            MyGenericClass<char> mca = new MyGenericClass<char>(5);
            //Setting Values
            for (int i = 0; i < 5; i++)
            {
                mca.MySetItem(i, (char)(i+97));   //97 & 65 ASCII Refarance Code
            }
            //Getting Values
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(mca.MyGetItem(i) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
