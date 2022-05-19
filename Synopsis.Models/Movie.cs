namespace Synopsis.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public MovieCategory Category { get; set; }
        public int ReleaseYear { get; set; }
        public int RuntimeMinutes { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<String> CastNames { get; set; }

        public Movie()
        {

        }

        public Movie(int id, string title, string plot, MovieCategory category, int releaseYear, int runtimeMinutes, double rating, string imageUrl, IEnumerable<String> cast)
        {
            Id = id;
            Title = title;
            Plot = plot;
            Category = category;
            ReleaseYear = releaseYear;
            RuntimeMinutes = runtimeMinutes;
            Rating = rating;
            CastNames = cast;
            ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return $"{Id}: {Title} is a {Category} movie from {ReleaseYear}. It is {RuntimeMinutes} minutes long";
        }
    }
}
