namespace CSharpNotes.OOP;

public class GettersAndSettersExample
{
    public class Movie
    {
        private string rating;

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }

    public void GettersAndSettersTest()
    {
        Movie movie = new Movie();
        movie.Rating = "PG";
        Console.WriteLine($"Movie Rating: {movie.Rating}");
    }
}