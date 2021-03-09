using System;

namespace Черновик
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[5, 10, 15];

            Console.WriteLine(myArray.GetUpperBound(0));
            Console.WriteLine(myArray.GetUpperBound(1));
            Console.WriteLine(myArray.GetUpperBound(2));

        }
    }
}
