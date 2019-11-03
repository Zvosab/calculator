using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputInt;
            float num1, num2;
            string userIn1, userIn2, userInput;

            do
            {
                Instructions();

                userInput = Console.ReadLine();
                userInputInt = int.Parse(userInput);

                if (userInputInt == 1)
                {
                    Console.WriteLine("enter 1st number");
                    userIn1 = Console.ReadLine();
                    Console.WriteLine("Enter 2nd number");
                    userIn2 = Console.ReadLine();
                    bool success1 = float.TryParse(userIn1, out num1);
                    bool success2 = float.TryParse(userIn2, out num2);
                    if (success1 && success2)
                    {
                        Add(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number. Press ENTER to try again or type QUIT to exit.");
                        if (Console.ReadLine().Equals("QUIT"))
                        {
                            Environment.Exit(0);
                        }

                    }
                }
                if (userInputInt == 2)
                {
                    Console.WriteLine("enter 1st number");
                    userIn1 = Console.ReadLine();
                    Console.WriteLine("Enter 2nd number");
                    userIn2 = Console.ReadLine();
                    bool success1 = float.TryParse(userIn1, out num1);
                    bool success2 = float.TryParse(userIn2, out num2);
                    if (success1 && success2)
                    {
                        Sub(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number. Press ENTER to try again or type QUIT to exit.");
                        if (Console.ReadLine().Equals("QUIT"))
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                if (userInputInt == 3)
                {
                    Console.WriteLine("enter 1st number");
                    userIn1 = Console.ReadLine();
                    Console.WriteLine("Enter 2nd number");
                    userIn2 = Console.ReadLine();
                    bool success1 = float.TryParse(userIn1, out num1);
                    bool success2 = float.TryParse(userIn2, out num2);
                    if (success1 && success2)
                    {
                        Mul(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number. Press ENTER to try again or type QUIT to exit.");
                        if (Console.ReadLine().Equals("QUIT"))
                        {
                            Environment.Exit(0);
                        }
                    }
                }


                if (userInputInt == 4)
                {
                    Console.WriteLine("enter 1st number");
                    userIn1 = Console.ReadLine();
                    Console.WriteLine("Enter 2nd number");
                    userIn2 = Console.ReadLine();
                    bool success1 = float.TryParse(userIn1, out num1);
                    bool success2 = float.TryParse(userIn2, out num2);
                    if (success1 && success2)
                    {
                        Div(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number. Press ENTER to try again or type QUIT to exit.");
                        if (Console.ReadLine().Equals("QUIT"))
                        {
                            Environment.Exit(0);
                        }
                    }
                }

                if(userInputInt == 5)
                {
                    Environment.Exit(0);    //shuts down the program
                }


            } while (userInputInt !=5);

            

            Console.Read();

        }
        //Instructions Method:
        public static void Instructions()
        {
            Console.WriteLine("Choose one of the options:");
            Console.WriteLine("1 - ADD;");
            Console.WriteLine("2 - SUBSTRACT;");
            Console.WriteLine("3 - MULTIPLY;");
            Console.WriteLine("4 - DIVIDE;");
            Console.WriteLine("5 - QUIT;");
            Console.WriteLine("6 - Instructions;");
        }

        public static float Add(float num1, float num2)
        {
            float result;
            result = num1 +num2;
            Console.WriteLine("The result is {0}",result);  //must be before return
            return result;
        }

        public static float Sub(float num1, float num2)
        {
            float result;
            result = num1 - num2;
            Console.WriteLine("The result is {0}", result);  //must be before return
            return result;
        }

        public static float Mul(float num1, float num2)
        {
            float result;
            result = num1 * num2;
            Console.WriteLine("The result is {0}", result);  //must be before return
            return result;
        }

        public static float Div(float num1, float num2)
        {
            float result;
            result = num1 / num2;
            Console.WriteLine("The result is {0}", result);  //must be before return
            return result;
        }

    }
}
