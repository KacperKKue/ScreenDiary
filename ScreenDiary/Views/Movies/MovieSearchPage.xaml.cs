using ScreenDiary.Api.Dto;

namespace ScreenDiary.Views.Movies;

public partial class MovieSearchPage : ContentPage
{
	public MovieSearchPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await (BindingContext as ViewModels.Movies.MovieSearchViewModel).LoadAsync();
    }

    private async void Movie_Selected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is MovieApiItem movie)
        {
            await Navigation.PushAsync(new MovieInfoPage(movie));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}