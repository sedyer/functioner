class Program
{
    static void Main(string[] args)
    {
        int[] testArray = { 4, 2, 7, 5, 2 };

        Functioner.Methods.BubbleSort(testArray);

        string reversedString = Functioner.Methods.StringReverser("abcdef");

        System.Console.WriteLine(Functioner.Methods.FindLargestValue(testArray));
    }
}