using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Class04_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter a value for index: {i}");
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (!success)
                {
                    throw new Exception($"Invalid input for index: {i}");
                }
                arr[i] = number;




            }
        }
    }
}

        
           



