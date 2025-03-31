namespace CSharpNotes.OOP;

public class InheritanceExample
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    public void InheritanceTest()
    {
        Dog dog = new Dog();
        dog.Eat();  // Inherited method
        dog.Bark(); // Dog-specific method
    }
}