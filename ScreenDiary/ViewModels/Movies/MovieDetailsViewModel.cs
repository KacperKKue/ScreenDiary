using ScreenDiary.Data.Entities;
using ScreenDiary.Helpers;
using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class MovieDetailsViewModel : BaseViewModel
    {
        private MovieEntity _movie;

        public MovieEntity Movie
        {
            get => _movie;
            set
            {
                _movie = value;
                OnPropertyChanged();
            }
        }

        public Array Statuses => Enum.GetValues(typeof(WatchStatus));

        public MovieDetailsViewModel(MovieEntity movie)
        {
            Movie = movie;
        }

        public async Task SaveAsync()
        {
            await DatabaseService.Database.SaveMovieAsync(Movie);
        }
    }
}
