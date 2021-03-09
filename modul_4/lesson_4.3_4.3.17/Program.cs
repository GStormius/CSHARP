using System;

namespace lesson_4._3_4._3._17
{
    class Program
    {
        static void getArray(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }  // Вывод двумерного массива в консоль

        static void sortedArray(int[,] arr)
        {
            for (int i = 0; i < arr.Rank; i++)
            {
                for (int j = 1; j < arr.Length / 2; j++)
                {
                    int f = 0;
                    int temp = 0;

                    for (int k = 0; k < arr.Length / 2 - 1; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1])
                        {
                            temp = arr[i, k + 1];
                            arr[i, k + 1] = arr[i, k];
                            arr[i, k] = temp;

                            f = 1;
                        }
                    }

                    if (f == 0)
                        break;
                }
            }
        }  // Сортировка двумерного массива

        static void Main(string[] args)
        {
            int[,] myArray =
            {
                {-5, 6, 9, 1, 2, -3 },
                {-8, 8, 1, 1, 2, -3 },
            };

            getArray(myArray);

            sortedArray(myArray);

            getArray(myArray);
        }
    }
}
