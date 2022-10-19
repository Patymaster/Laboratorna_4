using System;

namespace ConsoleApp1
{
    class Name {
        public string Name_(string name)
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            return name;
        }
    }
    class Age:Name
    {
        public int Age_(int age)
        {
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
    }
    class User:Age{
        static void Main(string[] args)
        {
            User user = new User();
            string name = user.Name_("");
            int age = user.Age_(0);
            Console.WriteLine("Your name is " + name + " you are " + age + " yers old.");
        }
    }
}
