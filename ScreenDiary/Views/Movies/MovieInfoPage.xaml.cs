using ScreenDiary.Api.Dto;
using ScreenDiary.Data.Entities;
using ScreenDiary.Helpers;
using ScreenDiary.Services;
using ScreenDiary.ViewModels.Movies;

namespace ScreenDiary.Views.Movies;

public partial class MovieInfoPage : ContentPage
{
    private MovieInfoViewModel ViewModel => BindingContext as MovieInfoViewModel;

    public MovieInfoPage(MovieApiItem movie)
    {
        InitializeComponent();
        BindingContext = new MovieInfoViewModel(movie);
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        var m = ViewModel.Movie;

        var entity = new MovieEntity
        {
            Title = m.Title,
            ImageUrl = m.FullPosterUrl,
            Notes = m.Overview,
            Rating = (int)Math.Round(m.VoteAverage),
            Status = WatchStatus.Planned
        };

        await DatabaseService.Database.SaveMovieAsync(entity);
        await Shell.Current.GoToAsync("..");
    }
}