using Synopsis.Models;

namespace Synopsis.Api.MockData
{
    public class MockMovies
    {
        private List<Movie> _movies;
        private MockMovieCategories _movieCategories;

        public MockMovies()
        {
            _movieCategories = new MockMovieCategories();

            _movies = new List<Movie>()
            {

                new Movie(1,
                    "Spectre",
                    "A cryptic message from James Bond's past sends him on a trail to uncover " +
                    "the existence of a sinister organisation named SPECTRE. With a new threat " +
                    "dawning, Bond learns the terrible truth about the author of all his pain in " +
                    "his most recent missions.",
                    _movieCategories.GetMovieCategory("Action"),
                    2015,
                    148,
                    6.8,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/zj8ongFhtWNsVlfjOGo8pSr7PQg.jpg",
                    new List<string>()
                    {
                        "Daniel Craig",
                        "Christoph Waltz",
                        "Léa Seydoux"
                    }
                ),

                new Movie(2,
                    "Skyfall",
                    "James Bond's loyalty to M is tested when her past comes back to haunt her. " +
                    "When MI6 comes under attack, 007 must track down and destroy the threat, " +
                    "no matter how personal the cost.",
                    _movieCategories.GetMovieCategory("Action"),
                    2012,
                    143,
                    7.8,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/izrHg2UzxG3YXTBcKFaUbYp9LWA.jpg",
                    new List<string>()
                    {
                        "Daniel Craig",
                        "Javier Bardem",
                        "Naomie Harris"
                    }
                ),

                new Movie(3,
                    "No Time to Die",
                    "James Bond has left active service. His peace is short-lived when Felix Leiter, " +
                    "an old friend from the CIA, turns up asking for help, leading Bond onto the trail " +
                    "of a mysterious villain armed with dangerous new technology.",
                    _movieCategories.GetMovieCategory("Action"),
                    2021,
                    163,
                    7.3,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/iUgygt3fscRoKWCV1d0C7FbM9TP.jpg",
                    new List<string>()
                    {
                        "Daniel Craig",
                        "Ana De Armas",
                        "Rami Malek"
                    }
                ),

                new Movie(4,
                    "The Godfather",
                    "The aging patriarch of an organized crime dynasty in postwar New York City " +
                    "transfers control of his clandestine empire to his reluctant youngest son.",
                    _movieCategories.GetMovieCategory("Drama"),
                    1972,
                    175,
                    9.2,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/n6PvMAKL66gavIFxOyRB6czAeQO.jpg",
                    new List<string>()
                    {
                        "Marlon Brando",
                        "Al Pacino",
                        "James Caan"
                    }
                ),

                new Movie(5,
                    "The Dark Knight",
                    "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, " +
                    "Batman must accept one of the greatest psychological and physical tests of his " +
                    "ability to fight injustice.",
                    _movieCategories.GetMovieCategory("Action"),
                    2008,
                    153,
                    9.0,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
                    new List<string>()
                    {
                        "Christian Bale",
                        "Heath Ledger",
                        "Aaron Eckhart"
                    }
                ),

                new Movie(6,
                    "Back to the Future",
                    "Marty McFly, a 17-year-old high school student, is accidentally sent thirty years " +
                    "into the past in a time-traveling DeLorean invented by his close friend, " +
                    "the eccentric scientist Doc Brown.",
                    _movieCategories.GetMovieCategory("Sci-Fi"),
                    1985,
                    156,
                    8.5,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/7lyBcpYB0Qt8gYhXYaEZUNlNQAv.jpg",
                    new List<string>()
                    {
                        "Michael J. Fox",
                        "Christopher Lloyd",
                        "Lea Thompson"
                    }
                ),

                new Movie(7,
                    "City of God",
                    "In the slums of Rio, two kids' paths diverge as one struggles to become " +
                    "a photographer and the other a kingpin.",
                    _movieCategories.GetMovieCategory("Drama"),
                    2002,
                    130,
                    8.6,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/k7eYdWvhYQyRQoU2TB2A2Xu2TfD.jpg",
                    new List<string>()
                    {
                        "Alexandre Rodrigues",
                        "Leandro Firmino",
                        "Matheus Nachtergaele"
                    }
                ),

                new Movie(8,
                    "It's a Wonderful Life",
                    "An angel is sent from Heaven to help a desperately frustrated businessman " +
                    "by showing him what life would have been like if he had never existed.",
                    _movieCategories.GetMovieCategory("Drama"),
                    1946,
                    130,
                    8.6,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/bSqt9rhDZx1Q7UZ86dBPKdNomp2.jpg",
                    new List<string>()
                    {
                        "James Stewart",
                        "Donna Reed",
                        "Lionel Barrymore"
                    }
                ),

                new Movie(9,
                    "Forrest Gump",
                    "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate " +
                    "scandal and other historical events unfold from the perspective of an " +
                    "Alabama man with an IQ of 75, whose only desire is to be reunited with " +
                    "his childhood sweetheart.",
                    _movieCategories.GetMovieCategory("Drama"),
                    1994,
                    142,
                    8.8,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/saHP97rTPS5eLmrLQEcANmKrsFl.jpg",
                    new List<string>()
                    {
                        "Tom Hanks",
                        "Robin Wright",
                        "Gary Sinise"
                    }
                ),

                new Movie(10,
                    "Pulp Fiction",
                    "The lives of two mob hitmen, a boxer, a gangster and his wife, " +
                    "and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    _movieCategories.GetMovieCategory("Drama"),
                    1994,
                    154,
                    8.9,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/fIE3lAGcZDV1G6XM5KmuWnNsPp1.jpg",
                    new List<string>()
                    {
                        "John Travolta",
                        "Uma Thurman",
                        "Samuel L. Jackson"
                    }
                ),

                new Movie(11,
                    "Lord of the Rings: The Return of the King",
                    "Gandalf and Aragorn lead the World of Men against Sauron's army " +
                    "to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    _movieCategories.GetMovieCategory("Action"),
                    2003,
                    201,
                    9.0,
                    "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg",
                    new List<string>()
                    {
                        "Elijah Wood",
                        "Viggo Mortensen",
                        "Ian McKellen"
                    }
                ),

            };
        }

        public IEnumerable<Movie> GetMockMovies()
        {
            return _movies;
        }

        public Movie GetMockMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null) return null;
            return movie;
        }
    }
}
