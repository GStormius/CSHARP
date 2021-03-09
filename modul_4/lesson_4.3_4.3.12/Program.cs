using System;

namespace lesson_4._3_4._3._12
{
    class Program
    {
        static int[] arraySorted(ref int[] arr)
        {
            int[] myArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int maxValue = arr[0];
                int maxIndex = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > maxValue)
                    {
                        maxValue = arr[j];
                        maxIndex = j;
                    }
                }

                myArray[myArray.Length - i - 1] = maxValue;
                arr[maxIndex] = 0;
            }

            return arr = myArray;

        }  // Вариант с применением дополнительного массива

        static void arraySortedBuf(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }  // Псевдопузырьковая сортировка

        static void bubbleSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int f = 0;
                int temp = 0;

                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        arr[j+1] = temp;
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                        f = 1;
                    }
                }

                if (f == 0)
                    break;
            }
        } // Пузырьковая сортировка

        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        } // Вывод элементов массива на консоль

        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3 };

            printArray(myArray);

            bubbleSorted(myArray);

            printArray(myArray);
        }
    }
}
