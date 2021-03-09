using System;

namespace lesson_4._2
{
    class Program
    {
        enum myPalette
        {
            red = 0,
            красный = red,
            green = 1,
            зеленый = green,
            cyan = 2,
            голубой = cyan,
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Напишите свой любимый цвет (красный, зеленый или голубой)");
                string strColor = Console.ReadLine();
                int color = -1;

                try
                {
                    color = (int)Enum.Parse(typeof(myPalette), strColor, ignoreCase: true);
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы указали несуществующий цвет! Будет применено стандартное решение!");
                }

                switch (color)
                {
                    case 0:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case 1:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case 2:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
            }
        }
    }
}
