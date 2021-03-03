using System;

namespace lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName; //  Объявление переменной
            myName = "Nick"; // Инициализация переменной

            const string Name = "Jane";

            Console.WriteLine(Name);

            Console.WriteLine("\tПривет, мир!");
            Console.WriteLine("\tМне 24 года");
            Console.WriteLine("\tMy name is {0}", myName);
            Console.WriteLine('\u0040');  //  Символ '@'
            Console.WriteLine('\u0023'); // Символ '#'

            Console.WriteLine(0x0A);  // Число 10
            Console.WriteLine(0b11);  // Число 3

            Console.ReadKey();
        }
    }
}
