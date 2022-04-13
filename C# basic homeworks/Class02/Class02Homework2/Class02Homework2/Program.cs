using System;

namespace Class02Homework2
{
    class Program
    {
        static void Main(string[] args)
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
};
