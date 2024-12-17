using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.
    // Properties are special kind of class member, In Properties we use predefined Set or Get method.
    // Properties are named members of classes, structures, and interfaces.
    // Member variables or methods in a class or structures are called Fields.
    // Properties are an extension of fields and are accessed using the same syntax.
    // Properties can be read-write, read-only, or write-only.
    // A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.

    class Student
    {
        private string code = "N.A";
        private string name = "Unknown";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "101";
            Console.WriteLine(s.Code);

            s.Age += 55;
            Console.WriteLine(s.Age);
        }
    }
}
