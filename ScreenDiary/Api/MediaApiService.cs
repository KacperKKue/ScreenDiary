using ScreenDiary.Api.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ScreenDiary.Api
{
    internal class MediaApiService
    {
        public async Task<List<MovieApiItem>> SearchMoviesAsync()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("movies_mock.json");
            using var reader = new StreamReader(stream);

            var json = await reader.ReadToEndAsync();

            var response = JsonSerializer.Deserialize<MovieSearchResponse>(json);
            return response?.Results ?? new();
        }

        public string GetPosterUrl(string posterPath)
            => $"https://image.tmdb.org/t/p/w185{posterPath}";
    }
}
