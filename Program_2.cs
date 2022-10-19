using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class A
    {
        static void Main(string[] args)
        {
            B_2 Person = new B_2();
            string name = Person.Name("");
            int age = Person.Age(0);
            int weight = Person.Weigth(0);
            Console.WriteLine("Your Name: " + name);
            Console.WriteLine("Your Age: " + age);
            Console.WriteLine("Your Weight: " + weight);
        }
    }

    class B
    {
        public int Age(int age)
        {
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
    }
    class B_1 : B {
        public string Name(string name)
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            return name;
        }
    }
    class B_2 : B_1 {
        public int Weigth(int weigth)
        {
            Console.WriteLine("Enter Weigth");
            weigth = Convert.ToInt32(Console.ReadLine());
            return weigth;
        }
    }
}
