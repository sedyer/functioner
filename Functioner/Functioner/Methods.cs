namespace Functioner
{
    public static class Methods
    {
        //Finds the largest integer in an array of integers
        public static int FindLargestValue(int[] array)
        {
            int value = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > value) value = array[i];
            }

            return value;
        }

        //Sorts an array of integers into ascending order
        public static void BubbleSort(int[] array)
        {
            int swap;

            for (int i = 0; i < array.Length; i++)
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

        //Returns true if an integer is prime and false otherwise
        public static bool IsPrime(int value)
        {
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //Reverses the digits of an integer, ex. 1234 becomes 4321
        public static int ValueReverser(int value)
        {
            int val = value;

            string backwards = "";

            while (val > 0)
            {
                backwards = backwards + (val % 10).ToString();
                val = val / 10;
            }

            return System.Convert.ToInt32(backwards);
        }

        //Reverses the characters in a string, ex. "ABCD" becomes "DCBA"
        public static string StringReverser(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[str.Length - i - 1];
            }

            return result;
        }
    }
}