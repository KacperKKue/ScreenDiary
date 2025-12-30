using ScreenDiary.Api;
using ScreenDiary.Api.Dto;
using ScreenDiary.Helpers;
using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class MovieInfoViewModel : BaseViewModel
    {
        private readonly PreferencesService _prefs;

        public MovieApiItem Movie { get; }

        public WatchStatus SelectedStatus { get; set; } = WatchStatus.Planned;
        public string Note { get; set; } = string.Empty;
        public float UserRating { get; set; }

        public bool ShowRatings { get; set; }

        public Array Statuses => Enum.GetValues(typeof(WatchStatus));

        public MovieInfoViewModel(MovieApiItem movie)
        {
            _prefs = new PreferencesService();
            ShowRatings = _prefs.DisplayPeopleVotes;

            Trace.WriteLine($"MovieInfoViewModel: ShowRatings = {ShowRatings}");

            Movie = movie;
        }
    }
}
