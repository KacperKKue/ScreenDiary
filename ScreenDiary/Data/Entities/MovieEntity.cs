using ScreenDiary.Helpers;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Data.Entities
{
    public class MovieEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        public bool IsFavorite { get; set; }
        public int Rating { get; set; }

        public WatchStatus Status { get; set; }

        public string Notes { get; set; } = string.Empty;
    }
}
