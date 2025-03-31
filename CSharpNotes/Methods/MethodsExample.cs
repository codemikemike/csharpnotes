namespace CSharpNotes.Methods;

public class MethodsExample
{
    public void SayHi()
    {
        Console.WriteLine("Hello world");
    }

    public void SayHiWithParams(string name, int age)
    {
        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }

    public int Cube(int num)
    {
        return num * num * num;
    }

    public void MethodExamples()
    {
        SayHi();
        SayHiWithParams("Helle", 65);
        Console.WriteLine($"Cube of 5: {Cube(5)}"); // Output: 125
    }
}