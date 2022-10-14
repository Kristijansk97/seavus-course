using System;

namespace Class02_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(" ");
                string number;
                double sum = 0;
                Console.WriteLine("Enter 4 numbers: ");
                for (int i = 0; i < 4; i++)
                {
                    number = Console.ReadLine();
                    sum += double.Parse(number);
                }
                Console.WriteLine($"Average result is {sum / 4}");
            }
        }
    }
}
