using System;

namespace lesson_4._5
{
    class Program
    {
        static (string name, string lastName, string login, int countLogin, bool hasPet, int age, string[] favcolors) FillQuestionnaire()
        {
            (string name, string lastName, string login, int countLogin, bool hasPet, int age, string[] favcolors) User;

            Console.Write("Введите ваше имя: ");
            User.name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            User.lastName = Console.ReadLine();

            Console.Write("Введите логин: ");
            User.login = Console.ReadLine();
            User.countLogin = User.login.Length;

            Console.Write("Есть ли у вас животные? Да или Нет: ");
            User.hasPet = Console.ReadLine() == "Да" ? true : false;

            Console.Write("Введите ваш возраст: ");
            bool boolAge = int.TryParse(Console.ReadLine(), out User.age);

            if (!boolAge)
            {
                Console.WriteLine("Вы ввели некорректное значение возраста!");
            }

            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета");

            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }

            Console.WriteLine("\n==========\n");

            return User;
        }

        static void GetValues((string name, string lastName, string login, int countLogin, bool hasPet, int age, string[] favcolors) User)
        {
            Console.WriteLine("Ваше имя: {0}", User.name);
            Console.WriteLine("Ваша фамилия: {0}", User.lastName);
            Console.WriteLine("Ваш логин: {0}", User.login);
            Console.WriteLine("Длина вашего логина: {0}", User.countLogin);
            Console.WriteLine("Наличие у вас питомца {0}", User.hasPet);
            Console.WriteLine("Ваш возраст {0}", User.age);

            Console.Write("Три ваших любимых цвета: ");
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                Console.WriteLine(User.favcolors[i]);
            }

            Console.WriteLine("\n==========\n");
        }

        static void Main(string[] args)
        {
            var User1 = FillQuestionnaire();
            var User2 = FillQuestionnaire();
            var User3 = FillQuestionnaire();

            GetValues(User1);
            GetValues(User2);
            GetValues(User3);

        }
    }
}
