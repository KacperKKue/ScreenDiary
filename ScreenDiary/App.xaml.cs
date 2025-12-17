using Microsoft.Extensions.DependencyInjection;
using ScreenDiary.Views;

namespace ScreenDiary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}