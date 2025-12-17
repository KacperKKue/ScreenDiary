using ScreenDiary.Data.Entities;
using ScreenDiary.Services;
using ScreenDiary.ViewModels;

namespace ScreenDiary.Views;

public partial class MoviesPage : ContentPage
{
	public MoviesPage()
	{
		InitializeComponent();
	}

    private async void AddMovie_Clicked(object sender, EventArgs e)
    {
        // Prosty popup – w prawdziwej aplikacji bêdzie osobna strona / modal
        string title = await DisplayPromptAsync("Nowy film", "Podaj tytu³ filmu:");
        if (string.IsNullOrWhiteSpace(title))
            return;

        var movie = new MovieEntity
        {
            Title = title,
            Rating = 0,
            IsFavorite = false
        };

        await DatabaseService.Database.SaveMovieAsync(movie);

        (BindingContext as MoviesViewModel)?.LoadMovies();
    }

    private async void Movie_Selected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is MovieEntity movie)
        {
            await Navigation.PushAsync(
                new Views.Movies.MovieDetailsPage(movie)
            );

            ((CollectionView)sender).SelectedItem = null;
        }
    }

}