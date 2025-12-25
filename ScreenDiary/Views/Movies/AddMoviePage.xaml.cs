using ScreenDiary.ViewModels.Movies;

namespace ScreenDiary.Views.Movies;

public partial class AddMoviePage : ContentPage
{
    private AddMovieViewModel ViewModel => BindingContext as AddMovieViewModel;

    public AddMoviePage()
    {
        InitializeComponent();
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(ViewModel.Title))
        {
            await DisplayAlert("B³¹d", "Tytu³ filmu jest wymagany.", "OK");
            return;
        }

        await ViewModel.SaveAsync();
        await Shell.Current.GoToAsync("..");
    }
}