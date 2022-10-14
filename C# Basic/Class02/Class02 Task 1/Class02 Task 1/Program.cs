using System;

namespace Class02_Task_1_RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number one is: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Number two is: ");
            string number2 = Console.ReadLine();
            Console.WriteLine("Enter the operation: ");
            string mathOperation = Console.ReadLine();
            double valueOne = double.Parse(number1);
            double valueTwo = double.Parse(number2);

            switch (mathOperation)
            {
                case "+":
                    Console.WriteLine($"The result is: {valueOne + valueTwo}");
                    break;
                case "-":
                    Console.WriteLine($"The result is: {valueOne - valueTwo}");
                    break;
                case "/":
                    Console.WriteLine($"The result is: {Math.Round(valueOne / valueTwo, 2)}");
                    break;
                case "*":
                    Console.WriteLine($"The result is: {valueOne * valueTwo}");
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
        }
    }
};
