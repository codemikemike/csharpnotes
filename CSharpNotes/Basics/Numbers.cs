namespace CSharpNotes.Basics;

public class Numbers
{
    public void NumberMethods()
    {
        int nums = 4;
        nums--; // Trækker én fra
        nums++; // Lægger én til
        Console.WriteLine($"Tallet er nu: {nums}");

        Console.WriteLine(Math.Abs(-15)); // Output: 15
    }
}