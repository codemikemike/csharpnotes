namespace CSharpNotes.ControlFlow;

public class SwitchStatementsExample
{
    public string GetDay(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }

        return dayName;
    }

    public void SwitchExample()
    {
        Console.WriteLine(GetDay(1)); // Output: Monday
    }
}