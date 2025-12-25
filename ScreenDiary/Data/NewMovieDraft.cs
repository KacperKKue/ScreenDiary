using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Data
{
    internal class NewMovieDraft
    {
        public string UserTitle { get; set; } = "";
        public string Notes { get; set; } = "";
        public int Rating { get; set; }
        public bool IsFavorite { get; set; }
    }
}
