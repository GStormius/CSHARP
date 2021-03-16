using System;

namespace lesson_4._3_4._3._13
{
    class Program
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }  

        static int getSumElementsArray(int[] arr)
        {
            int sum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }  

        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            Console.WriteLine(getSumElementsArray(myArray)); 
        }
    }
}
