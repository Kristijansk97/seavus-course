using System;

namespace Class02_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.Write("Enter number one: ");
            string parseNumber1 = Console.ReadLine();
            Console.Write("Enter number two: ");
            string parseNumber2 = Console.ReadLine();

            int swapNumber1 = int.Parse(parseNumber1);
            int swapNumber2 = int.Parse(parseNumber2);

            int temp = swapNumber1;

            swapNumber1 = swapNumber2;
            swapNumber2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine($"number one is: {swapNumber1}\nnumber two is: {swapNumber2}");
        }
    }
}

