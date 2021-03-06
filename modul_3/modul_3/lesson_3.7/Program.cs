using System;

namespace lesson_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.Write("Enter your berthday: ");
            var birthday =  Console.ReadLine();

            Console.WriteLine("Your drthday is {0}", birthday);
        }
    }
}
