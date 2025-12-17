using ScreenDiary.ViewModels.Profile;

namespace ScreenDiary.Views;

public partial class ProfilePage : ContentPage
{
    private ProfileViewModel ViewModel => BindingContext as ProfileViewModel;

    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void ChangeAvatar_Clicked(object sender, EventArgs e)
    {
        var result = await FilePicker.Default.PickAsync(
            new PickOptions { PickerTitle = "Wybierz avatar" });

        if (result == null)
            return;

        var newPath = Path.Combine(
            FileSystem.AppDataDirectory,
            result.FileName);

        using var stream = await result.OpenReadAsync();
        using var fileStream = File.Create(newPath);
        await stream.CopyToAsync(fileStream);

        ViewModel.AvatarPath = newPath;
    }
}