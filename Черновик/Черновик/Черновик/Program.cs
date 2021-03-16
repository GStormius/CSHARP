using System;

namespace Черновик
{
    class Program
    {
        static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            object langChoice = Console.ReadLine();
            Console.WriteLine(langChoice.GetType());

            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
            Console.WriteLine(choice.GetType());

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            Console.WriteLine();
        }

        static void GetName(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        

        static void Main(string[] str)
        {
            ExecutePatternMatchingSwitchWithWhen();

            GetName(out string name, out var oldname);
        }



        
    }
}
