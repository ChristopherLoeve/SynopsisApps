using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Synopsis.Models;
using Synopsis.Razor.Services;

namespace Synopsis.Razor.Pages
{
    public class MovieDetailsModel : PageModel
    {
        private readonly MovieService _movieService;
        public Movie Movie;

        public MovieDetailsModel(MovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Movie = await _movieService.GetMovieByIdAsync(id);
            return Page();
        }
    }
}
