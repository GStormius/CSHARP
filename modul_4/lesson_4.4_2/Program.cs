using System;

namespace lesson_4._4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age, birthday) = ("Nikita", 23, "24.07.1997");

            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.WriteLine("Your drthday is {0}", birthday);

            Console.WriteLine("\n===========\n");

            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out int inputAge);

            Console.WriteLine("Your name is {0} and age is {1}", inputName, inputAge);

            Console.Write("Enter your berthday: ");
            string inputBirthday = Console.ReadLine();

            Console.WriteLine("Your drthday is { 0 }", inputBirthday);

        }
    }
}
