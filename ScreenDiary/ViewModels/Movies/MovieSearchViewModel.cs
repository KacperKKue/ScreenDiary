using ScreenDiary.Api;
using ScreenDiary.Api.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class MovieSearchViewModel
    {
        private readonly MediaApiService _api = new();

        public ObservableCollection<MovieApiItem> Results { get; } = new();

        public async Task LoadAsync()
        {
            Results.Clear();
            var movies = await _api.SearchMoviesAsync();

            foreach (var movie in movies)
                Results.Add(movie);
        }
    }
}
