using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Synopsis.Models;
using Synopsis.Api.Repositories.Interfaces;

namespace Synopsis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCategoriesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieCategoriesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieCategory>>> GetCategories()
        {
            try
            {
                var categories = _movieRepository.GetCategories();
                if (categories == null)
                {
                    return NotFound();
                }
                return Ok(categories);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from the server");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieCategory>> GetCategory(int id)
        {
            try
            {
                var category = _movieRepository.GetCategory(id);
                if (category == null)
                {
                    return NotFound($"Category with id {id} does not exist.");
                }
                return Ok(category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error retrieving data from the server");
            }
        }
    }
}
