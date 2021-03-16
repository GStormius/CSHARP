using System;

namespace lesson_5._5_5._5._8
{
    class Program
    {
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            
            if (pow == 1)
            {
                return N;
            }

            try
            {
                return checked(N * PowerUp(N, --pow));
            }
            catch (Exception)
            {

                Console.WriteLine("Значение слишком велико!");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int value = PowerUp(2, 20);

            Console.WriteLine(value);
        }
    }
}
