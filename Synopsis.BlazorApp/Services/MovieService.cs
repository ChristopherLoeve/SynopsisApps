using Synopsis.Models;
using System.Net;
using System.Net.Http.Json;

namespace Synopsis.BlazorApp.Services
{
    public class MovieService
    {

        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("Movies");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<Movie>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<Movie>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http Status: {response.StatusCode} - Message: {message}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Movies/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.NoContent)
                    {
                        return default;
                    }

                    return await response.Content.ReadFromJsonAsync<Movie>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http Status: {response.StatusCode} - Message: {message}");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
