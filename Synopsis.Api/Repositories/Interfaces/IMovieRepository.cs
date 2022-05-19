using Synopsis.Models;

namespace Synopsis.Api.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        IEnumerable<MovieCategory> GetCategories();
        MovieCategory GetCategory(int id);

    }
}
