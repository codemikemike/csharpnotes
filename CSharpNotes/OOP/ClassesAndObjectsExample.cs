namespace CSharpNotes.OOP;

public class ClassesAndObjectsExample
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }

    public void ClassesAndObjectsTest()
    {
        Book book1 = new Book("Harry Potter", "JK Rowling", 400);
        Console.WriteLine($"Book title: {book1.title}, Author: {book1.author}");
    }
}