using System;

namespace Functioner
{
    public class Methods
    {
        public static int FindLargestValue(int[] array)
        {
            int value = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > value) value = array[i];
            }

            return value;
        }

        public static void BubbleSort(ref int[] array)
        {
            int swap;

            for (int i = 0;  i < array.Length; i++)
            {
                for (int j = array.Length - 2; j >= 0; j--)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }

        public static bool IsPrime(long value)
        {
            for (long i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int ValueReverser(int value)
        {
            int val = value;

            string backwards = "";

            while (val > 0)
            {
                backwards = backwards + (val % 10).ToString();
                val = val / 10;
            }

            return Convert.ToInt32(backwards);
        }
    }
}
