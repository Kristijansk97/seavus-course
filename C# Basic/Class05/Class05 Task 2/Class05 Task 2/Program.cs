using System;

namespace Class05_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Human human = new Human(firstName, lastName, age);

            string description = human.GetPersonStats();
            Console.WriteLine(description);
        }
    }
}
