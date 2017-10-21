using static System.Console;
using static Functioner.Methods;

class Program
{
    static void Main(string[] args)
    {
        // vars

        int[] testArray = { 4, 2, 7, 5, 2 };

        // program

        WriteLine("Welcome to the Functioner App!");

        WriteLine();
        WriteLine();

        Write("The contents of the current array are: [ ");

        foreach (int i in testArray) Write(i + " ");

        Write("]");

        BubbleSort(testArray);

        WriteLine();
        WriteLine();

        Write("The sorted contents are: [ ");

        foreach (int i in testArray) Write(i + " ");

        Write("]");

        WriteLine();
        WriteLine();

        Write("The largest value in this array is: ");

        WriteLine(FindLargestValue(testArray));

        WriteLine();
        WriteLine();

        WriteLine("Press ENTER to close this window.");

        ReadLine();
    }
}