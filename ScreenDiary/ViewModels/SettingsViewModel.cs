using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.ViewModels
{
    internal class SettingsViewModel : BaseViewModel
    {
        public async Task ResetAsync()
        {
            await ResetService.ResetAllAsync();
        }
    }
}
