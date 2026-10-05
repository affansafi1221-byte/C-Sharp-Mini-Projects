using System;

namespace C_Sharp_Mini_Projects._01_Calculator
{
    internal class CalculatorProgram
    {
        public static void Run()
        {
            int num1;
            int num2;
            string answer;
            int result = 0;

            Console.WriteLine("Hello, Welcome to the calculator program");

            Console.WriteLine("Please Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation do you want to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or d for division");
            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }

                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operation.");
                return;
            }

            Console.WriteLine("The result of the operation is: " + result);
            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}