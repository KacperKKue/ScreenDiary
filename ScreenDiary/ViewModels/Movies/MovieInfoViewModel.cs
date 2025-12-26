using ScreenDiary.Api;
using ScreenDiary.Api.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels.Movies
{
    internal class MovieInfoViewModel : BaseViewModel
    {
        public MovieApiItem Movie { get; }

        public MovieInfoViewModel(MovieApiItem movie)
        {
            Movie = movie;
        }
    }
}
