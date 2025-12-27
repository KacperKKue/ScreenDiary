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
        public int TMDBId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;

        public bool IsFavorite { get; set; }
        public float TMDBRating { get; set; }
        public float UserRating { get; set; }

        public WatchStatus Status { get; set; }

        public string Description { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
