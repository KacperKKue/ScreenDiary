using ScreenDiary.Data.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Services
{
    internal class DatabaseService
    {
        private static AppDatabase? _database;

        public static AppDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var path = Path.Combine(
                        FileSystem.AppDataDirectory,
                        "screendiary.db3");

                    _database = new AppDatabase(path);
                }

                return _database;
            }
        }
    }
}
