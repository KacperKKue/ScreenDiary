using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Services
{
    internal class PreferencesService
    {
        public string Nickname
        {
            get => Preferences.Get("nickname", "User");
            set => Preferences.Set("nickname", value);
        }

        public string AvatarPath
        {
            get => Preferences.Get("avatar_path", string.Empty);
            set => Preferences.Set("avatar_path", value);
        }

        public bool DisplayPeopleVotes
        {
            get => Preferences.Get("display_vote_votes", true);
            set => Preferences.Set("display_vote_votes", value);
        }
    }
}
