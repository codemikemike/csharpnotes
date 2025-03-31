namespace CSharpNotes.Basics;

public class VariablesAndFields
{
    // Lokale variabler
    public void LocalVariables()
    {
        int antalBiler = 5;
        string navn = "Mike";
        Console.WriteLine($"Antal biler: {antalBiler}, Navn: {navn}");
    }

    // Felter (fields)
    private int _antal;
    public void FieldsExample()
    {
        _antal = 10;
        Console.WriteLine($"Antal (private field): {_antal}");
    }

    // Properties
    public int Antal { get; set; }

    public void PropertiesExample()
    {
        Antal = 20;
        Console.WriteLine($"Antal (property): {Antal}");
    }

    // Konstanter
    public void ConstantsExample()
    {
        const int MAKS_ANTAL = 100;
        Console.WriteLine($"Maks antal: {MAKS_ANTAL}");
    }
}