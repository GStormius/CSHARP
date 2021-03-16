using System;

namespace lesson_5._3_5._3._13
{
    class Program
    {
        static int[] SortArrayAsc(in int[] arr)
        {
            int[] copyArr = arr;

            for (int j = 0; j < arr.Length - 1; j++)
            {
                int f = 0;

                for (int i = 0; i < arr.Length - j - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        f = 1;
                    }
                }

                if (f == 0)
                    break;
            }

            return copyArr;
        }

        static int[] SortArrayDesc(in int[] arr)
        {
            int[] copyArr = arr;

            for (int j = 0; j < arr.Length - 1; j++)
            {
                int f = 0;

                for (int i = 0; i < arr.Length - j - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        f = 1;
                    }
                }

                if (f == 0)
                    break;
            }

            return copyArr;
        }

        static void SortArray(in int[] arr, out int[] sortedAsc, out int[] sortedDesc)
        {
            sortedAsc = SortArrayAsc(arr);

            sortedDesc = SortArrayDesc(arr);
        }

        static int[] NewRandomArray(int value)
        {
            Random random = new();
            int[] arr = new int[value];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }

            return arr;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 4, 4352, 2435, 62, 234, 123, 65, 143, 242, 131, 541 };

            SortArray(myArray, out int[] sortedAsc, out int[] sortedDesc);
        }
    }
}
