using System;

namespace Class03_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Number one is: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Number two is: ");
            string number2 = Console.ReadLine();
            double valueOne = double.Parse(number1);
            double valueTwo = double.Parse(number2);
            if (valueOne % 2 == 0 && valueTwo % 2 == 0)
            {
                Console.WriteLine($"Both of the numbers are even.The opearation and result are: {valueOne} + {valueTwo} = {valueOne + valueTwo}");
            }
            else if (valueOne % 2 == 0 && valueTwo % 2 != 0)
            {
                Console.WriteLine($"One of the numbers is odd.The operation and result are: {valueOne} - {valueTwo} = {valueOne - valueTwo}");
            }
            else if (valueOne % 2 != 0 && valueTwo % 2 == 0)
            {
                Console.WriteLine($"One of the numbers is odd.The operation and result are: {valueOne} - {valueTwo} = {valueOne - valueTwo}");
            }
            else if (valueOne % 2 != 0 && valueTwo % 2 != 0)
            {
                Console.WriteLine($"Both of the numbers are odd.The operation and result are: {valueOne} * {valueTwo} = {valueOne * valueTwo}");
            }


        }
    }
}
