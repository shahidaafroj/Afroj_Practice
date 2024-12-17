using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    sealed class Employee : Person
    {
        public string Designation { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MedicalBill { get; set; }
        public decimal ConveyanceFee { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal OvertimeFee { get; set; }
        public decimal GrossSalary { get; set; }
        public List<string> Roles { get; set; }

        public Employee()
        {
            Roles = new List<string>();
        }

        public void CalculateSalary()
        {
            HouseRent = (int)(BasicSalary * 0.40m);
            ConveyanceFee = (int)(BasicSalary * 0.05m);
            OvertimeFee = (int)((BasicSalary / 208) * 2 * OvertimeHours);
            GrossSalary = BasicSalary + HouseRent + MedicalBill + ConveyanceFee + OvertimeFee;
        }

        public void DisplaySalaryDetails()
        {
            Console.WriteLine("================================OUTPUT================================");
            Console.WriteLine($"Name                : {Name}");
            Console.WriteLine($"ID                  : {ID}");
            Console.WriteLine($"Designation         : {Designation}");
            Console.WriteLine($"Basic Salary        : {BasicSalary}");
            Console.WriteLine($"House Rent          : {HouseRent}");
            Console.WriteLine($"Medical Bill        : {MedicalBill}");
            Console.WriteLine($"Conveyance Fee      : {ConveyanceFee}");
            Console.WriteLine($"Total Overtime Fee  : {OvertimeFee}");
            Console.WriteLine($"Gross Salary        : {GrossSalary}");
            Console.WriteLine($"Your Roles in the Institution are : {string.Join(", ", Roles)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Please Enter Your Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Please Enter Your ID: ");
            employee.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("The Available Designations Are");
            Console.WriteLine("1: Director");
            Console.WriteLine("2: Assistant Director");
            Console.WriteLine("3: General Manager");
            Console.WriteLine("4: Assistant Manager");
            Console.WriteLine("5: Accountant");
            Console.WriteLine("6: Senior Officer");
            Console.WriteLine("7: Cashier");
            Console.WriteLine("8: Others");

            int designationNumber;
            while (true)
            {
                Console.Write("Please Insert Your Designation Number : ");
                if (int.TryParse(Console.ReadLine(), out designationNumber) && designationNumber >= 1 && designationNumber <= 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 to 8.");
                }
            }
            switch (designationNumber)
            {
                case 1: employee.Designation = "Director"; break;
                case 2: employee.Designation = "Assistant Director"; break;
                case 3: employee.Designation = "General Manager"; break;
                case 4: employee.Designation = "Assistant Manager"; break;
                case 5: employee.Designation = "Accountant"; break;
                case 6: employee.Designation = "Senior Officer"; break;
                case 7: employee.Designation = "Cashier"; break;
                case 8: employee.Designation = "Others"; break;
                    //default: employee.Designation = "Unknown"; break;
            }

            Console.Write("Enter Your Basic Salary: ");
            employee.BasicSalary = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Medical Bill: ");
            employee.MedicalBill = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Overtime Hours: ");
            employee.OvertimeHours = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Roles Using (,) and Press Enter to Finish\nEnter Your Roles: ");
            string rolesInput = Console.ReadLine();
            employee.Roles.AddRange(rolesInput.Split(','));

            employee.CalculateSalary();
            employee.DisplaySalaryDetails();

            Console.ReadLine();
        }

    }
}
