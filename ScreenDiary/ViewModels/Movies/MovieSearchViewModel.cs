using ScreenDiary.Api;
using ScreenDiary.Api.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class MovieSearchViewModel
    {
        private readonly MediaApiService _apiService = new();

        public string Query { get; set; } = string.Empty;

        public ObservableCollection<MovieApiItem> Results { get; } = new();

        public async Task SearchAsync()
        {
            Results.Clear();

            if (string.IsNullOrWhiteSpace(Query))
                return;

            var response = await _apiService.SearchMoviesAsync(Query);

            if (response == null)
            {
                return;
            }

            foreach (var movie in response.Results)
            { 
                Trace.WriteLine(
                    $"Found movie: {movie.Title} ({movie.ReleaseDate})");
                Results.Add(movie); 
            }
        }
    }
}
