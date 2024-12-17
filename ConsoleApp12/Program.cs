using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Student
    {
        public int StudentID;
        public string Name;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studList = new List<Student>();
            {
                new Student() { StudentID = 1, Name = "Izhaan", Age = 3 };
                new Student() { StudentID = 2, Name = "Sadia", Age = 20 };
                new Student() { StudentID = 3, Name = "Shusmita", Age = 27 };
                new Student() { StudentID = 4, Name = "Sonia", Age = 33 };
                new Student() { StudentID = 5, Name = "Salma", Age = 73 };
            };
            var teenStudents = from s in studList    // Query Does not Execute Here.....
                               where s.Age > 18 && s.Age < 33
                               select s;
            foreach (Student ts in teenStudents)     // Query Execute Here....  
            {
                Console.WriteLine("Name:{0}", ts.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Add New Student.......");
            Console.WriteLine("=================");

            studList.Add(new Student() { StudentID = 10, Name = "Nadia", Age = 21 });  // Add New Student

            //Deferred Execution=> Latest Data Show
            foreach (Student ts in teenStudents)          // Query Execute Here Again (With LAtest Data).... 
            {
                Console.WriteLine("Name:{0}", ts.Name);
                Console.ReadKey();
            }
        }
    }
}
