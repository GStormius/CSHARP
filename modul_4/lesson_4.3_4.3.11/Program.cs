using System;

namespace lesson_4._3_4._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[4, 3] { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < myArray.GetUpperBound(1) + 1; i++)
            {
                for (int j = 0; j < myArray.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(myArray[j, i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
