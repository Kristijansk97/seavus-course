using System;

namespace Class04_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "We are learning C# and it is FUN and EASY.Okay,maybe just FUN.";
            string newString = myString.Substring(myString.Length - 5);
            Console.WriteLine(newString);
        }
    }
}
