using System;

namespace ConsoleApp1
{
    class Human{
        public string FirstName(string name) {
            Console.WriteLine("Enter your Firstname");
            name = Console.ReadLine();
            return name;
        }
        public string LastName(string name)
        {
            Console.WriteLine("Enter your LastName");
            name = Console.ReadLine();
            return name;
        }
    }
    class Person : Human{
        static void Main(string[] args)
        {
            Person person = new Person();
            string FirstName = person.FirstName("");
            string LastName = person.LastName("");
            Console.WriteLine("Your Name:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FirstName);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(LastName);
            Console.ResetColor();
        }
    }
}
