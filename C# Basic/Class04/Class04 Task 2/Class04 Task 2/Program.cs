//1# Reshenie so Split
using System;

namespace Class04_Task_2
{
 internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "We are learning C# and it is FUN and EASY.Okay, maybe just FUN.";

            foreach (var a in myString.Split(' '))
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }

    }
}

//2# Reshenie so Contains
//using System;

//namespace Class04_Task_2
//{
//internal class Program
// {
// static void Main(string[] args)
// {
//  string myString = "We are learning C# and it is FUN and EASY.Okay, maybe just FUN.";

// if (myString.Contains("FUN") == true)
//  {
//      Console.WriteLine("Word found!");
//  } else
//  {
//      Console.WriteLine("Word not found");
//  }
//  }

//  }
//}
