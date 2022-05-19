using Microsoft.AspNetCore.Components;
using Synopsis.Models;
using Synopsis.BlazorApp.Services;

namespace Synopsis.BlazorApp.Pages
{
    public class MovieDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public MovieService MovieService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Movie Movie { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Movie = (await MovieService.GetMovieByIdAsync(1));
        }

    }
}
