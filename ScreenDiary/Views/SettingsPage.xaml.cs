using ScreenDiary.ViewModels;

namespace ScreenDiary.Views;

public partial class SettingsPage : ContentPage
{
    private SettingsViewModel ViewModel => BindingContext as SettingsViewModel;

    public SettingsPage()
	{
		InitializeComponent();
	}

    private async void Reset_Clicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert(
            "Potwierdzenie",
            "Czy na pewno chcesz usun¹æ wszystkie dane? Tej operacji nie mo¿na cofn¹æ.",
            "Tak",
            "Anuluj");

        if (!confirm)
            return;

        await ViewModel.ResetAsync();

        await DisplayAlert(
            "Gotowe",
            "Wszystkie dane zosta³y usuniête.",
            "OK");

        Application.Current.MainPage = new AppShell();
    }
}