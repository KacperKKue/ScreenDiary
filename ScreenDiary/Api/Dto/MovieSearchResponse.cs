using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ScreenDiary.Api.Dto
{
    public class MovieSearchResponse
    {
        [JsonPropertyName("results")]
        public List<MovieApiItem> Results { get; set; } = new();
    }
}
