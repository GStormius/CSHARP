using System;

namespace lesson_4._3_4._3._16
{
    class Program
    {
        static int getNumberPositiveNumbers(int[,] arr)
        {
            int count = 0;

            for (int j = 0; j <= arr.GetUpperBound(0); j++)
            {
                for (int i = 0; i <= arr.GetUpperBound(1); i++)
                {
                    if (arr[j, i] > 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static int getNumberPositiveNumbers2(int[,] arr)
        {
            int count = 0;

            foreach (int item in arr)
            {
                if (item > 0)
                    count++;
            }

            return count;
        }


        static void Main(string[] args)
        {
            int[,] myArray =
            {
                {-5, 6, 9, 1, 2, -3 },
                {-8, 8, 1, 1, 2, -3 },
            };

            Console.WriteLine(getNumberPositiveNumbers(myArray));
            Console.WriteLine(getNumberPositiveNumbers2(myArray));
        }
    }
}
