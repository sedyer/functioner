using System;

namespace Functioner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 2, 7, 5, 2 };

            Methods.BubbleSort(ref testArray);

            Console.WriteLine(Methods.FindLargestValue(testArray));
        }
    }
}
