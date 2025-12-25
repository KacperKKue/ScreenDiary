using ScreenDiary.Api;
using ScreenDiary.Api.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class MovieInfoViewModel
    {
        private readonly MediaApiService _api = new();

        public MovieApiItem Movie { get; }

        public string PosterUrl => _api.GetPosterUrl(Movie.PosterPath);

        public MovieInfoViewModel(MovieApiItem movie)
        {
            Movie = movie;
        }
    }
}
