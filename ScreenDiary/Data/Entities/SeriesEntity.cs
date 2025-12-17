using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Data.Entities
{
    public class SeriesEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public bool IsFavorite { get; set; }

        public int Rating { get; set; }

        public string Status { get; set; } = "Planned"; // Planned, Watching, Finished, Dropped
    }
}
