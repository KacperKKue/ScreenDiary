using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels
{
    internal class SettingsViewModel : BaseViewModel
    {
        private readonly PreferencesService _prefs = new();

        private bool _displayPeopleVotes;
        public bool DisplayPeopleVotes
        {
            get => _displayPeopleVotes;
            set
            {
                _displayPeopleVotes = value;
                _prefs.DisplayPeopleVotes = value;
                OnPropertyChanged();
            }
        }

        public SettingsViewModel()
        {
            DisplayPeopleVotes = _prefs.DisplayPeopleVotes;
        }

        public async Task ResetAsync()
        {
            await ResetService.ResetAllAsync();
        }
    }
}
