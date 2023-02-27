using System;

namespace HelloWorld_Maxey_Andrew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            Console.WriteLine("What is your last name?");
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {firstname} {lastname}!");
        }
    }
}
