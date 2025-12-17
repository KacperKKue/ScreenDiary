using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Services
{
    internal class ResetService
    {
        public static async Task ResetAllAsync()
        {
            await DatabaseService.Database.ResetDatabaseAsync();

            Preferences.Clear();

            try
            {
                var dir = FileSystem.AppDataDirectory;
                if (Directory.Exists(dir))
                {
                    Directory.Delete(dir, true);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
