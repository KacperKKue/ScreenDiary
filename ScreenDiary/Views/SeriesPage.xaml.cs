using ScreenDiary.Data.Entities;
using ScreenDiary.Services;

namespace ScreenDiary.Views;

public partial class SeriesPage : ContentPage
{
	public SeriesPage()
	{
		InitializeComponent();
	}

    private async void AddSeries_Clicked(object sender, EventArgs e)
    {
        // Prosty popup – w prawdziwej aplikacji bêdzie osobna strona / modal
        string title = await DisplayPromptAsync("New series", "Enter series title:");
        if (string.IsNullOrWhiteSpace(title))
            return;

        var series = new SeriesEntity
        {
            Title = title,
            Rating = 0,
            IsFavorite = false
        };

        await DatabaseService.Database.SaveSeriesAsync(series);

        // Odœwie¿enie listy
        (BindingContext as ViewModels.SeriesViewModel)?.LoadSeries();
    }
}