using ScreenDiary.Data.Entities;
using ScreenDiary.ViewModels.Movies;

namespace ScreenDiary.Views.Movies;

public partial class MovieDetailsPage : ContentPage
{
    private MovieDetailsViewModel ViewModel => BindingContext as MovieDetailsViewModel;

    public MovieDetailsPage(MovieEntity movie)
    {
        InitializeComponent();
        BindingContext = new MovieDetailsViewModel(movie);
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        await ViewModel.SaveAsync();
        await Shell.Current.GoToAsync("//movies");
    }
}