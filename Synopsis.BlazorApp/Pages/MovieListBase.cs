using Microsoft.AspNetCore.Components;
using Synopsis.Models;
using Synopsis.BlazorApp.Services;

namespace Synopsis.BlazorApp.Pages
{
    public class MovieListBase : ComponentBase
    {
        [Inject]
        public MovieService MovieService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public List<Movie> Movies { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Movies = (await MovieService.GetMoviesAsync()).ToList();
        }

    }
}
