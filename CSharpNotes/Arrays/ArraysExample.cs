namespace CSharpNotes.Arrays;

public class ArraysExample
{
    public void ArrayExample()
    {
        int[] myAge = { 2, 3, 4, 5, 6 };
        Console.WriteLine(myAge[2]); // Output: 4
    }

    public void TwoDimensionalArrayExample()
    {
        int[,] numberGrid = {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

        Console.WriteLine(numberGrid[1, 1]); // Output: 4
    }
}