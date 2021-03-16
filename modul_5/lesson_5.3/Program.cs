using System;

namespace lesson_5._3
{
    class Program
    {
        static void ChangeAge(ref int age)
        {
            age = 22;
        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }

        static void Main(string[] args)
        {
            int age = 23;

            ChangeAge(ref age);

            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
                      
        }
    }
}
