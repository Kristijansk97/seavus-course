using System;

namespace Class03_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());

                for (int i = 0; i <= number; i++)
                {
                    if (i % 5 == 0)
                    {
                        continue;
                    }

                    if (i == 81)
                    {
                        Console.WriteLine("You have reached the limit!");
                        break;
                    }
                    Console.WriteLine(i);
                }
            }
        }
    }
};


