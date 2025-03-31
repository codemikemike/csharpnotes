namespace CSharpNotes.Basics;

public class StringMethods
{
    public void ConcatenateStrings()
    {
        string fornavn = "Mike";
        string efternavn = "Andersen";
        string fuldtNavn = fornavn + " " + efternavn;
        Console.WriteLine(fuldtNavn); // Output: Mike Andersen
    }

    public void StringMethodsExample()
    {
        string phrase = "Giraffe Academy";
        Console.WriteLine(phrase.ToUpper());          // Output: GIRAFFE ACADEMY
        Console.WriteLine(phrase.Contains("Academy")); // Output: True
        Console.WriteLine(phrase[0]);                  // Output: G
        Console.WriteLine(phrase.IndexOf("Academy"));  // Output: 8
        Console.WriteLine(phrase.Substring(8, 3));     // Output: Aca
    }
}