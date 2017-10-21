using System;

namespace Functioner
{
    class Functioner
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 2, 7, 5, 2 };

            Methods.BubbleSort(ref testArray);

            Console.WriteLine(Methods.FindLargestValue(testArray));
        }
    }
}
