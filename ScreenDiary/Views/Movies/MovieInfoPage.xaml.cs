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
        var vm = ViewModel;
        var m = vm.Movie;

        var entity = new MovieEntity
        {
            TMDBId = m.Id,
            Title = m.Title,
            ImageUrl = m.FullPosterUrl,
            ReleaseDate = m.ReleaseDate,
            Description = m.Overview,
            TMDBRating = m.VoteAverage,
            Status = vm.SelectedStatus,
            UserRating = vm.UserRating,
            Notes = vm.Note
        };

        await DatabaseService.Database.SaveMovieAsync(entity);
        await Shell.Current.GoToAsync("//movies");
    }
}