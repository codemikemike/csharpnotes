namespace CSharpNotes.ControlFlow;

public class IfStatementsExample
{
    public void IfExample()
    {
        bool isMale = true;
        bool isTall = true;

        if (isMale && isTall)
        {
            Console.WriteLine("You are a tall male");
        }
        else
        {
            Console.WriteLine("You are not a tall male");
        }
    }
}