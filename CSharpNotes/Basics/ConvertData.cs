namespace CSharpNotes.Basics;

public class ConvertData
{
    public void ConvertStringToInt()
    {
        int age = Convert.ToInt32("42");
        Console.WriteLine($"Age: {age}");

        // Eller brug .ToDouble hvis det er decimaler
        double height = Convert.ToDouble("1.75");
        Console.WriteLine($"Height: {height}");
    }
}