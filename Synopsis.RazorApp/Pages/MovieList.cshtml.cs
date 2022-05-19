using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Synopsis.Models;
using Synopsis.Razor.Services;

namespace Synopsis.Razor.Pages
{
    public class MovieListModel : PageModel
    {
        private readonly MovieService _movieService;
        public List<Movie> Movies;

        public MovieListModel(MovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Movies = (await _movieService.GetMoviesAsync()).ToList();
            return Page();
        }
    }
}
