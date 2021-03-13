using System;

namespace lesson_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string[] Dishes) User;

            Console.WriteLine("Введите имя пользователя");
            User.name = Console.ReadLine();

            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите ваше любимое блюдо {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
