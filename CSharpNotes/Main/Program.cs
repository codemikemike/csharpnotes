using CSharpNotes.Basics;
using CSharpNotes.Arrays;
using CSharpNotes.Methods;
using CSharpNotes.ControlFlow;
using CSharpNotes.Loops;
using CSharpNotes.OOP;

namespace CSharpNotes.Main;

class Program
{
    static void Main(string[] args)
    {
        // Basics
        VariablesAndFields variables = new VariablesAndFields();
        variables.LocalVariables();
        variables.FieldsExample();
        variables.PropertiesExample();
        variables.ConstantsExample();

        StringMethods stringMethods = new StringMethods();
        stringMethods.ConcatenateStrings();
        stringMethods.StringMethodsExample();

        Numbers numbers = new Numbers();
        numbers.NumberMethods();

        ConvertData convertData = new ConvertData();
        convertData.ConvertStringToInt();

        // Arrays
        ArraysExample arraysExample = new ArraysExample();
        arraysExample.ArrayExample();
        arraysExample.TwoDimensionalArrayExample();

        // Methods
        MethodsExample methodsExample = new MethodsExample();
        methodsExample.MethodExamples();

        // Control flow
        IfStatementsExample ifStatements = new IfStatementsExample();
        ifStatements.IfExample();

        SwitchStatementsExample switchStatements = new SwitchStatementsExample();
        switchStatements.SwitchExample();

        // Loops
        WhileLoopExample whileLoop = new WhileLoopExample();
        whileLoop.WhileLoop();

        DoWhileLoopExample doWhileLoop = new DoWhileLoopExample();
        doWhileLoop.DoWhileLoop();

        ForLoopExample forLoop = new ForLoopExample();
        forLoop.ForLoop();
        forLoop.ForLoopWithArray();

        // OOP
        ClassesAndObjectsExample classesAndObjects = new ClassesAndObjectsExample();
        classesAndObjects.ClassesAndObjectsTest();

        ConstructorsExample constructorsExample = new ConstructorsExample();
        constructorsExample.ConstructorsTest();

        GettersAndSettersExample gettersAndSetters = new GettersAndSettersExample();
        gettersAndSetters.GettersAndSettersTest();

        StaticExample.StaticMethod();

        InheritanceExample inheritance = new InheritanceExample();
        inheritance.InheritanceTest();

        Console.ReadLine();
    }
}
