using System;

namespace lesson_5._5
{
    class Program
    {
        static void Echo(string saidword, int deep)
        {
            Console.ForegroundColor = (ConsoleColor)deep;
            string modSaidword = saidword;

            if (modSaidword.Length > 2)
            {
                modSaidword = modSaidword.Remove(0, 2);
            }

            Console.WriteLine("...{0}", modSaidword);

            if (deep > 1)
            {
                Echo(modSaidword, deep - 1);
            }
        }

        static decimal Factorial(decimal x)
        {
            if (x == 0)
            {
                return 1;
            }

            return x * Factorial(x - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то:");
            string inputStr = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха:");
            int deep = int.Parse(Console.ReadLine());

            Echo(inputStr, deep);

            Console.WriteLine(Factorial(20));
        }
    }
}
