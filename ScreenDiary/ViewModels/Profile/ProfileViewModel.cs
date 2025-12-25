using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels.Profile
{
    internal class ProfileViewModel : BaseViewModel
    {
        private readonly PreferencesService _prefs = new();

        private string _nickname;
        public string Nickname
        {
            get => _nickname;
            set
            {
                _nickname = value;
                _prefs.Nickname = value;
                OnPropertyChanged();
            }
        }

        private string _avatarPath;
        public string AvatarPath
        {
            get => _avatarPath;
            set
            {
                _avatarPath = value;
                _prefs.AvatarPath = value;
                OnPropertyChanged();
            }
        }

        public int MoviesCount { get; private set; }
        public int SeriesCount { get; private set; }
        public int FinishedCount { get; private set; }
        public int FavoritesCount { get; private set; }
        public double AverageRating { get; private set; }

        public ProfileViewModel()
        {
            Nickname = _prefs.Nickname;
            AvatarPath = _prefs.AvatarPath;

            LoadStatistics();
        }

        public async void LoadStatistics()
        {
            MoviesCount = await DatabaseService.Database.GetMoviesCountAsync();
            SeriesCount = await DatabaseService.Database.GetSeriesCountAsync();
            FinishedCount = await DatabaseService.Database.GetFinishedMoviesCountAsync();
            FavoritesCount = await DatabaseService.Database.GetFavoriteMoviesCountAsync();

            OnPropertyChanged(nameof(MoviesCount));
            OnPropertyChanged(nameof(SeriesCount));
            OnPropertyChanged(nameof(FinishedCount));
            OnPropertyChanged(nameof(FavoritesCount));
        }
    }
}
