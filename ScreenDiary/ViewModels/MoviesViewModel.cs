using ScreenDiary.Data.Entities;
using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ScreenDiary.ViewModels
{
    internal class MoviesViewModel
    {
        public ObservableCollection<MovieEntity> Movies { get; } = new();

        public MoviesViewModel()
        {
            LoadMovies();
        }

        public async void LoadMovies()
        {
            var movies = await DatabaseService.Database.GetMoviesAsync();
            Movies.Clear();
            foreach (var movie in movies)
                Movies.Add(movie);
        }
    }
}
