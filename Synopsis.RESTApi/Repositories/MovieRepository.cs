using Synopsis.Api.Repositories.Interfaces;
using Synopsis.Models;
using Synopsis.Api.MockData;

namespace Synopsis.Api.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private static MockMovies _movies;
        private static MockMovieCategories _movieCategories;

        public MovieRepository()
        {
            if (_movies == null) _movies = new MockMovies();
            if (_movieCategories == null) _movieCategories = new MockMovieCategories();
        }

        public IEnumerable<MovieCategory> GetCategories()
        {
            return _movieCategories.GetMockMovieCategories();
        }

        public MovieCategory GetCategory(int id)
        {
            var category = _movieCategories.GetMovieCategory(id);
            return category;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _movies.GetMockMovies();
        }

        public Movie GetMovie(int id)
        {
            var movie = _movies.GetMockMovie(id);
            return movie;
        }
    }
}
