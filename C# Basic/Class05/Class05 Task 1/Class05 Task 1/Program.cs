using System;
using System.Runtime.CompilerServices;

namespace Class05_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                    DateTime birthDate;

                Console.WriteLine("Enter your date(eg. 1985/8/15): ");
                string inputDate = Console.ReadLine();

                if (DateTime.TryParse(inputDate, out birthDate))
                {
                    Console.WriteLine($"You are {AgeCalculator(birthDate)} years old.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date");
                }
            }
        }
        static int AgeCalculator(DateTime birthDate)
        {
            int myAge = DateTime.Now.Subtract(birthDate).Days;

            myAge = myAge / 365;

            return myAge;
        }
    }
}
