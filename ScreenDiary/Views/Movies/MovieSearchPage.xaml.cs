using ScreenDiary.Api.Dto;
using ScreenDiary.ViewModels.Movies;

namespace ScreenDiary.Views.Movies;

public partial class MovieSearchPage : ContentPage
{
    private MovieSearchViewModel ViewModel =>
        BindingContext as MovieSearchViewModel;

    public MovieSearchPage()
    {
        InitializeComponent();
    }

    private async void Search_Clicked(object sender, EventArgs e)
    {
        await ViewModel.SearchAsync();
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