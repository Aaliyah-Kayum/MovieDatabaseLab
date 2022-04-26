namespace Movie
{
    public class Movie
    {
        public object category { get; private set; }

        public static void Main()
        {
            //List<Movie> list = new List<Movie>()
            //{
            //    new Movie("The Lion King", "Animation"),
            //    new Movie("Annabelle", "Horror"),
            //    new Movie("Spider-Man", "Action"),
            //    new Movie("Spirited Away", "Animation"),
            //    new Movie("Insidious", "Horror"),
            //    new Movie("Terminator", "Sci-fi"),
            //    new Movie("Endgame", "Action"),
            //    new Movie("Batman", "Action"),
            //    new Movie("Star Wars", "Sci-fi"),
            //    new Movie("Planet of the Apes", "Sci-fi"),
            //    new Movie("The Matrix", "Sci-fi"),
            //    new Movie("No Time To Die", "Action")
            //};
            Console.WriteLine("Welcome to the Movie List App!");
            Dictionary<string, string> menu = new Dictionary<string, string>()
            {
                ["The Lion King"] = "Animation",
                ["Annabelle"] = "Horror",
                ["No Time To Die"] = "Action",
                ["Terminator"] = "Sci-fi",
                ["Planet of the Apes"] = "Sci-fi",
                ["Spirited Away"] = "Animation",
                ["Annabelle"] = "Horror",
                ["Blade"] = "Action",
                ["Star Wars"] = "Sci-fi",
                ["Spirited Away"] = "Animated"

            };

            List<string> Movies = new List<string>();
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("There are 10 Movies in this list.");
                Console.WriteLine("Which category would you like to view?");

                int num = 0;
                while (true)
                {
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num >= 0 && num < menu.Count)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry. I didn't understand.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                string category = Console.ReadLine();
                foreach (Movie movie in Movies)
                {
                    if (movie.category == category)
                    {
                        List<Movie> result = Movies.Where(movie => movie.category;
                        result.Add(movie);
                    }
                    else
                    {
                        break;
                    } 
                        
                }

                List<Movie> movies = new List<Movie>();
                if (menu.Count == 0)
                {
                    Console.WriteLine("I'm sorry. We don't have that category available");
                }

                while (true)
                {
                    Console.WriteLine("Would you like to select another category to explore? (y/n)");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "y")
                    {
                        keepPlaying = true;
                        break;
                    }
                    else if (input.ToLower() == "n")
                    {
                        keepPlaying = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I didn't understand");
                    }
                }
            }
        }
    }
}