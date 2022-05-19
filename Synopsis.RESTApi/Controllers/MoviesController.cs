using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Synopsis.Models;
using Synopsis.Api.Repositories.Interfaces;

namespace Synopsis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            try
            {
                var movies = _movieRepository.GetMovies();
                if (movies == null)
                {
                    return NotFound();
                }
                return Ok(movies);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from the server");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            try
            {
                var movie = _movieRepository.GetMovie(id);
                if (movie == null)
                {
                    return NotFound($"Movie with id {id} does not exist.");
                }
                return Ok(movie);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from the server");
            }
        }
    }
}
