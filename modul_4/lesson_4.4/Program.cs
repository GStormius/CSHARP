using System;

namespace lesson_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age, string birthday) anketa;                                 
            
            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out anketa.age);

            Console.WriteLine("Your name is {0} and age is {1}", anketa.name, anketa.age);

            Console.Write("Enter your berthday: ");
            anketa.birthday =  Console.ReadLine();

            Console.WriteLine("Your drthday is {0}", anketa.birthday);
        }
    }
}
