using System;

namespace lesson_5._2_5._2._2
{
    class Program
    {

        enum NewColors
        {
            red = 0,
            красный = red,
            green = 1,
            зеленый = green,
            blue = 2,
            синий = blue,
            cyan = 3,
            голубой = cyan
        }; 

        static string ShoWColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} лет,\nвведите ваш любимый цвет (красный, синий, голубой, зеленый): ", username, userage);

            string inputColor = Console.ReadLine();
            int color = -1;

            try
            {
                color = (int)Enum.Parse(typeof(NewColors), inputColor, ignoreCase: true);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели некорректное значение цвета. Будем применено стандартное решение!");
            }

            switch (color)
            {
                // red
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red");
                    break;

                // green
                case 1:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green");
                    break;

                // blue
                case 2:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is blue");
                    break;

                // cyan 
                case 3:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan");
                    break;

                // yellow
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("The color is yellow");
                    break;
            }

            Console.ResetColor();

            Console.WriteLine();

            return inputColor;
        }  

        static void ShowArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Любимый цвет №{0}: {1}", i + 1, arr[i]);
            }
        } 

        static (string name, int age, string birthday) newUser()
        {
             (string name, int age, string birthday) anketa;

            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out anketa.age);

            Console.Write("Enter your berthday: ");
            anketa.birthday = Console.ReadLine();

            Console.WriteLine("Your name is {0} and age is {1}. Your berthday is {2}", anketa.name, anketa.age, anketa.birthday);

            Console.WriteLine();

            return anketa;
        }  

        static void Main(string[] args)
        {
            string[] favcolors = new string[3];

            var User1 = newUser();

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShoWColor(User1.name, User1.age);
            }

            ShowArray(favcolors);
        }
    }
}
