using System;

namespace lesson_5._1_5._1._6
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            Console.Write("Введите количество элементов в массиве: ");
            int size;
            int.TryParse(Console.ReadLine(), out size);

            int[] result = new int[size];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Введите элемент массива номер {0}: ", i);
                int.TryParse(Console.ReadLine(), out result[i]);
            }

            Console.WriteLine();

            return result;
        } 


        static void ArraySorted(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int f = 0;

                for (int i = 0; i < arr.Length - j -1; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        f = 1;
                    }
                }

                if (f == 0)
                    break;
            }
        }  


        static void GetArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }  

        static void Main(string[] args)
        {                        
            var myArray = GetArrayFromConsole();

            GetArray(myArray);

            ArraySorted(myArray);

            GetArray(myArray);

        }
    }
}
