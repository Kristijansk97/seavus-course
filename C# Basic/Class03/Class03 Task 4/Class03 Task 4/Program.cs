using System;
using System.ComponentModel.DataAnnotations;

namespace Class03_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 12, 8, 23, 18 , 3 , 40 , 34 , 14 , 10};
            int i, max, min, n;
            n = 10;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}", min);
        }
    }
}

