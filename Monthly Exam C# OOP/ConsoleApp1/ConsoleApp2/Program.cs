using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        // 1. Create C# console application to take and print the following salary information: 
        // i.Name
        // ii.Designation
        // iii.Basic = Any Amount
        // iv. House Rent = 40 % of the Basic
        // v.Medical = Any Amount
        //vi. Conveyance = 5 % of the basic
        // vii.Overtime = Twice of the hourly Basic Rate
        // viii. Gross Salary
        //  ix.Role Plays
        //The application will follow the following instructions strictly: 
        // a) Principle of OOP must be used to develop the application.
        // b) Overtime must be implemented through interface
        // c) Employee must inherit person.Person cannot be instantiated.Employee cannot be inherited. 
        // d) Enum will be used for designation
        // e) Role Plays are unlimited

        public enum Designation
        {
            Director = 1,
            AssistantDirector,
            GeneralManager,
            AssistantManager,
            Accountant,
            SeniorOfficer,
            Cashier,
            Others
        }
        public abstract class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public interface IOvertime
        {
            double CalculateOvertime(double basic, double hoursWorked);
        }
        public sealed class Employee : Person, IOvertime
        {
            public Designation EmployeeDesignation { get; set; }
            public double BasicSalary { get; set; }
            public double HoursRent => 0.4 * BasicSalary;
            public double MedicalAllowance { get; set; }
            public double Conveyance => 0.05 * BasicSalary;
            public double OvertimeHours { get; set; }
            public double GrossSalary => BasicSalary + HoursRent + MedicalAllowance + Conveyance + CalculateOvertime(BasicSalary, OvertimeHours);
            public List<string> Roles { get; set; } = new List<string>();
            public double CalculateOvertime(double basic, double hoursWorked)
            {
                double hourlyRate = basic / 208;
                double overtimePayment = 2 * hourlyRate * hoursWorked;
                return Math.Round(overtimePayment, 2);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Employee ID:");
                int id;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out id))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID format!!!! Please enter a valid numeric ID.");
                        Console.Write("Enter Employee ID:");
                    }
                }
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("The Available Designations Are:");
                Console.WriteLine("1: Director");
                Console.WriteLine("2: Assistant Director");
                Console.WriteLine("3: General Manager");
                Console.WriteLine("4: Assistant Manager");
                Console.WriteLine("5: Accountant");
                Console.WriteLine("6: Senior Officer");
                Console.WriteLine("7: Cashier");
                Console.WriteLine("8: Others");
                Console.WriteLine();

                Designation designation;
                while (true)                
                {
                    Console.Write("Please Insert Designation Number (1-8): ");
                    if (int.TryParse(Console.ReadLine(), out int designationNumber) && designationNumber >= 1 && designationNumber <= 8)
                    {
                        designation = (Designation)designationNumber;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!!!!!! Please enter a valid number between 1 and 8.");
                    }
                }
                Console.Write("Enter Basic Salary:");
                double basicSalary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Medical Allowance:");
                double medicalAllowance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Overtime Hours:");
                double overtimeHours = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Roles Using (,) and Press Enter to Finish\nEnter Your Roles: ");
                string rolesInput = Console.ReadLine();
                List<string> roles = new List<string>(rolesInput.Split(','));


                // Create Employee object
                Employee employee = new Employee
                {
                    Name = name,
                    Id = id,
                    EmployeeDesignation = designation,
                    BasicSalary = basicSalary,
                    MedicalAllowance = medicalAllowance,
                    OvertimeHours = overtimeHours,
                    Roles = roles
                };
                Console.WriteLine();
                Console.WriteLine("======================Salary Details========================");
                Console.WriteLine($"Name                    : {employee.Name}");
                Console.WriteLine($"ID                      : {employee.Id}");
                Console.WriteLine($"Designation             : {employee.EmployeeDesignation}");
                Console.WriteLine($"Basic Salary            : {employee.BasicSalary}");
                Console.WriteLine($"House Rent              : {employee.HouseRent}");
                Console.WriteLine($"Medical Allowance       : {employee.MedicalAllowance}");
                Console.WriteLine($"Conveyance              : {employee.Conveyance}");
                Console.WriteLine($"Overtime Payment        : {employee.CalculateOvertime(employee.BasicSalary, employee.OvertimeHours)}");
                Console.WriteLine($"Gross Salary            : {employee.GrossSalary}");
                Console.WriteLine($"Roles Of Employee       : {(string.Join(", ", employee.Roles).Trim())}");
                Console.ReadKey();
            }

            }
        }
    }

