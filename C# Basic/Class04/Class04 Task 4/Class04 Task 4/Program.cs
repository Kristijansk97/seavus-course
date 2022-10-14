using System;

namespace Class04_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an operator + or - or * or /");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-" && operation !="*" && operation !="/")
            {
                Console.WriteLine("Invalid operator");
                return;
            }
            Console.WriteLine("Enter the first number");
            bool firstParsingResult = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter the second number");
            bool secondParsingResult = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (!firstParsingResult || !secondParsingResult)
            {
                Console.WriteLine("Invalid inputs for numbers");
                return;
            }

            if (operation == "+")
            {
                int result = Sum(firstNumber, secondNumber);
                Console.WriteLine($"Sum is: {result}");
            }
            else
            if (operation == "-")
            {
                int result = Subtract(firstNumber, secondNumber);
                Console.WriteLine($"Subtract is: {result}");
            }
            else
            if (operation == "*")
            {
                int result = Multiplication(firstNumber, secondNumber);
                Console.WriteLine($"Multiplication is: {result}");
            }
            else 
            if (operation == "/")
            {
                int result = Division(firstNumber, secondNumber);
                Console.WriteLine($"Division is: {result}");
            }

        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}

