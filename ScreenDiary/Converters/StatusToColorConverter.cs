using System.Globalization;
using ScreenDiary.Helpers; // Pamiętaj o zaimportowaniu namespace'a enuma

namespace ScreenDiary.Converters;

public class WatchStatusToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is WatchStatus status)
        {
            return status switch
            {
                WatchStatus.Finished => Color.FromArgb("#2ECC71"), // Zielony
                WatchStatus.Watching => Color.FromArgb("#3498DB"), // Niebieski
                WatchStatus.Planned => Color.FromArgb("#F1C40F"), // Żółty
                WatchStatus.Dropped => Color.FromArgb("#E74C3C"), // Czerwony
                _ => Color.FromArgb("#95A5A6")
            };
        }
        return Color.FromArgb("#95A5A6");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
}