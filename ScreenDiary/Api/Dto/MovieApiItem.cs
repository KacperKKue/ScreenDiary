using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ScreenDiary.Api.Dto
{
    public class MovieApiItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = string.Empty;

        [JsonPropertyName("overview")]
        public string Overview { get; set; } = string.Empty;

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; } = string.Empty;

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = string.Empty;

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        public string? FullPosterUrl => string.IsNullOrEmpty(PosterPath)
            ? null
            : $"https://image.tmdb.org/t/p/w500{PosterPath}";
    }
}
