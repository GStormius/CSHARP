using System;


namespace lesson_5._2_5._2._8
{
    class Program
    {
        static int[] GetArrayFromConsole(ref int size)
        {
            size = 6;

            int[] result = new int[size];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Введите элемент массива номер {0}: ", i);
                int.TryParse(Console.ReadLine(), out result[i]);
            }

            Console.WriteLine();

            return result;
        } 

        static int[] SortArray(int[] arr)
        {
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

            return arr;
        }  

        static void GetArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }  

        static void ShowArray(int[] arr, bool isSort = false)
        {
            var temp = arr;

            if (isSort)
            {
                temp = SortArray(arr);
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("Элемент массива номер {0} равен: {1}", i, temp[i]);
            }
        }


        static void Main(string[] args)
        {
            int sizeArray = 10;

            var array = GetArrayFromConsole(ref sizeArray);

            GetArray(array);

            var sortedArray = SortArray(array);

            GetArray(sortedArray);

        }
    }
}
