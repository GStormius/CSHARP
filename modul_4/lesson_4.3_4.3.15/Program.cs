using System;

namespace lesson_4._3_4._3._15
{
    class Program
    {
        static void fillArray(int[] arr)
        {
            Random random = new();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
        }

        static void getArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


        static int getNumberPositiveNumbers(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count += 1;
                }
            }

            return count; 
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[12];

            fillArray(myArray);

            getArray(myArray);

            Console.WriteLine("\nКоличество положительных чисел в массиве составляет: {0}", getNumberPositiveNumbers(myArray)); 
        }
    }
}
