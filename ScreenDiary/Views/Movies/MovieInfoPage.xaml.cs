using ScreenDiary.Api.Dto;
using ScreenDiary.ViewModels.Movies;

namespace ScreenDiary.Views.Movies;

public partial class MovieInfoPage : ContentPage
{
    private MovieApiItem _movie;

    public MovieInfoPage(MovieApiItem movie)
    {
        InitializeComponent();
        _movie = movie;
        BindingContext = new MovieInfoViewModel(movie);
    }

    private async void SavePoster_Clicked(object sender, EventArgs e)
    {
        // tutaj w kolejnym kroku:
        // - zapis URL do MovieEntity
        // albo
        // - pobranie i zapis lokalny

        await DisplayAlert("OK", "Plakat zapisany", "OK");
        await Shell.Current.GoToAsync("..");
    }
}