using System;

namespace lesson_4._3_4._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
                       
            Console.Write("Ваше имя наоборот: ");

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[name.Length - i - 1]);
            }

        }
    }
}
