using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        struct Person
        { 
         public int PersonID { get; set; }
         public string Name { get; set; }
         public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>()
            {
             new Person {PersonID = 1, Name="Shahida", Age=28 },
             new Person {PersonID = 2, Name="Niloy", Age=22 },
             new Person { PersonID = 3, Name = "Izhaan", Age = 2 },
             new Person { PersonID = 4, Name = "Shuvo", Age = 68 },
             new Person { PersonID = 5, Name = "Alam", Age = 55 },
             };
            foreach (var per in personList)
            {
                Console.WriteLine("PersonID:" + per.PersonID + ", Name:" + per.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Find Any Of Them");
            Console.WriteLine();
            Console.Write("Please Enter Person ID: ");
            int pid = Convert.ToInt32(Console.ReadLine());

            Person prsn = personList.Find((Person p) => { return p.PersonID == pid; });
            Console.WriteLine("Person ID: {0}\nName: {1}\nAge:{2}", prsn.PersonID,prsn.Name,prsn.Age);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
