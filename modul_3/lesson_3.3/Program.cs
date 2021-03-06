using System;

namespace lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Есть ли у вас питомец? (Да или Нет) ");
            bool pet = Console.ReadLine() == "Да";

            Console.Write("Какой у вас размер ноги? ");
            double size = double.Parse(Console.ReadLine());

            Console.WriteLine("\n===Вывод===");
            Console.WriteLine("Вас зовут {0}", name);
            Console.WriteLine("Вам {0} лет", age);
            Console.WriteLine("Есть ли у вас питомец? {0}", pet);
            Console.WriteLine("У вас {0} размер ноги", size);
        }
    }
}
