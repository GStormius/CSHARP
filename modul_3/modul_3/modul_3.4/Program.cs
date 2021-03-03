using System;

namespace modul_3._4
{
    class Program
    {
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300,
        }

        static void Main(string[] args)
        {
            Console.WriteLine((int)Semaphore.Green);
            Console.WriteLine((Semaphore)200);
            Console.WriteLine(Enum.GetUnderlyingType(typeof(Semaphore)));
        }
    }
}
