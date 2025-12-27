using ScreenDiary.Api.Dto;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ScreenDiary.Api
{
    internal class MediaApiService
    {
        private const string ApiKey = "";
        private const string BaseUrl = "https://api.themoviedb.org/3/search/movie";

        public async Task<MovieSearchResponse?> SearchMoviesAsync(string query)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", ApiKey);

            try
            {
                var url = $"{BaseUrl}?query={query}";

                return await client.GetFromJsonAsync<MovieSearchResponse>(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while searching for movies: {ex.Message}");

                return null;
            }
        }
    }
}
