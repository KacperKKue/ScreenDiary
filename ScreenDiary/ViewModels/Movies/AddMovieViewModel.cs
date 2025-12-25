using ScreenDiary.Data.Entities;
using ScreenDiary.Helpers;
using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class AddMovieViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public int Rating { get; set; }
        public bool IsFavorite { get; set; }

        public WatchStatus Status { get; set; } = WatchStatus.Planned;

        public Array Statuses => Enum.GetValues(typeof(WatchStatus));

        public async Task SaveAsync()
        {
            var movie = new MovieEntity
            {
                Title = Title,
                ImageUrl = ImageUrl,
                Notes = Notes,
                Rating = Rating,
                IsFavorite = IsFavorite,
                Status = Status
            };

            await DatabaseService.Database.SaveMovieAsync(movie);
        }
    }
}
