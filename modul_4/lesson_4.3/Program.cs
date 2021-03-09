using System;

namespace lesson_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Последняя буква вашего имени: {0}", name[^1]);

        }
    }
}
