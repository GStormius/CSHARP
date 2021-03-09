using System;

namespace lesson_4._3_4._3._14
{  
    class Program
    {
        static void fillArrayRandomElements(int[][] arr)
        {
            Random random = new(100);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(100);
                }
            }
        }  // Заполнить зубчатый массив случайными числами

        static void getArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();

            }
        }  // Получить элементы зубчатого массива

        static void Main(string[] args)
        {
            int[][] myArray = new int[6][];

            myArray[0] = new int[6];
            myArray[1] = new int[12];
            myArray[2] = new int[2];
            myArray[3] = new int[8];
            myArray[4] = new int[2];
            myArray[5] = new int[7];

            fillArrayRandomElements(myArray);

            getArray(myArray);

        }
    }
}
