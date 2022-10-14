using System;

namespace Class03_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 7, 3, 2, 8 };
            int evenSum = 0;
            int evenNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"Even number: {evenNum = array[i]}");
                    Console.WriteLine($"The sum is: {evenSum += evenNum}");
                }

            }
        }
    }
}
