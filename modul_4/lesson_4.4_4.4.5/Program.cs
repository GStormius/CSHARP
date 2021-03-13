using System;

namespace lesson_4._4_4._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя питомца: ");
            (string name, string type, double age, int nameCount) Pet;
            Pet.name = Console.ReadLine();
            Pet.nameCount = Pet.name.Length;

            Console.Write("Введите тип питомца: ");
            Pet.type = Console.ReadLine();

            Console.Write("Введите возраст питомца: ");
            bool boolAge = double.TryParse(Console.ReadLine(), out Pet.age);

            if (!boolAge)
                Console.WriteLine("Вы ввели некорректное значение возраста питомца!");

            Console.WriteLine("\n=================\n");

            Console.WriteLine("Имя вашего питомца: {0}", Pet.name);
            Console.WriteLine("Тип вашего питомца: {0}", Pet.type);
            Console.WriteLine("Возраст вашего питомца: {0}", Pet.age);
            Console.WriteLine("Длина имени вашего питомца: {0}", Pet.nameCount);



        }
    }
}
