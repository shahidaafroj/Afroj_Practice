using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Do_While_IF_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("01. For Loop");
                Console.WriteLine("02. Do Loop");
                Console.WriteLine("03. While Loop");
                Console.WriteLine("04. Switch Case");
                Console.WriteLine("05. If, Else If");
                Console.WriteLine("06. Else");
                Console.WriteLine("07. Method - Parameter, Argument, Optional Parameter, Overloading, Return, Void, Variable");
                Console.WriteLine("08. Static");
                Console.WriteLine("09. Object Creation");
                Console.WriteLine("10. Namespace and Using Directive");
                Console.WriteLine("==============================================================");
                Console.WriteLine("Select an Option (1-10): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            ForLoopExample();
                            break;
                        }
                    case "2":
                        {
                            DoLoopExample();
                            break;
                        }
                    case "3":
                        {
                            WhileLoopExample();
                            break;
                        }
                    case "4":
                        {
                            SwitchExample();
                            break;
                        }
                    case "5":
                        {
                            IfElseIfExample();
                            break;
                        }
                    case "6":
                        {
                            ElseExample();
                            break;
                        }
                    case "7":
                        {
                            MethodExamples();
                            break;
                        }
                    case "8":
                        {
                            StaticExample();
                            break;
                        }
                    case "9":
                        {
                            ObjectCreationExmaple();
                            break;
                        }
                    case "10":
                        {
                            NamespaceUsingDirectiveExample();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                        }
                }
                Console.Write("\nPress nay key to return to the menu....");
                Console.ReadLine();

            }
        }


        //01.FOR LOOP
        static void ForLoopExample()
        {
            //Console.Write("For Loop Example: ");
            Console.WriteLine("Give A Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        //02.DO LOOP
        static void DoLoopExample()
        {
            Console.WriteLine("Do Loop Example: ");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 10);

        }

        //WhileLoopExample
        static void WhileLoopExample()
        {
            Console.WriteLine("While Loop Example: ");
            Console.WriteLine("Give A Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
            }
        }

        static void SwitchExample()
        {
            Console.WriteLine("Switch Case Example:");
            Console.Write("Enter a number (0-4): ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
        }
        static void IfElseIfExample()
        {
            Console.WriteLine("If, Else If Example:");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 5)
            {
                Console.WriteLine("The number is less than 5.");
            }
            else if (num >= 5 && num < 10)
            {
                Console.WriteLine("The number is between 5 and 10.");
            }
            else if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("The number is 10 or greater.");
            }
        }

        static void ElseExample()
        {
            Console.WriteLine("Else Example:");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 10)
            {
                Console.WriteLine("The number is less than 10.");
            }
            else
            {
                Console.WriteLine("The number is 10 or more.");
            }
        }

        static void MethodExamples()
        {
            Console.WriteLine("Method Examples:");
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum: " + Add(a, b));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        //Object Creation
        static void StaticExample()
        {
            Console.WriteLine("Static Example:");
        }

        static void ObjectCreationExmaple()
        {
            Console.WriteLine("Object Creation Example");
        }

        static void NamespaceUsingDirectiveExample()
        {
            Console.WriteLine("Namespace and Using Directive Example.");
        }

    }

}
