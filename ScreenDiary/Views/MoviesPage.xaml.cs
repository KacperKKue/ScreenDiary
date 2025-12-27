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

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as ViewModels.MoviesViewModel)?.LoadMovies();
    }


    private async void AddMovie_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Movies.MovieSearchPage());
        //await Shell.Current.GoToAsync(nameof(Views.Movies.MovieSearchPage));
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