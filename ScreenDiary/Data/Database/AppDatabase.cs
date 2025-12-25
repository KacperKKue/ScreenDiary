using ScreenDiary.Data.Entities;
using ScreenDiary.Helpers;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenDiary.Data.Database
{
    internal class AppDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public AppDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<MovieEntity>().Wait();
            _database.CreateTableAsync<SeriesEntity>().Wait();
        }

        public Task<List<SeriesEntity>> GetSeriesAsync()
            => _database.Table<SeriesEntity>().ToListAsync();

        public Task<List<MovieEntity>> GetMoviesAsync()
            => _database.Table<MovieEntity>().ToListAsync();


        public Task<int> SaveSeriesAsync(SeriesEntity series)
            => _database.InsertAsync(series);

        public Task<int> SaveMovieAsync(MovieEntity movie)
            => _database.InsertAsync(movie);


        public Task<int> GetMoviesCountAsync()
            => _database.Table<MovieEntity>().CountAsync();

        public Task<int> GetSeriesCountAsync()
            => _database.Table<SeriesEntity>().CountAsync();

        public Task<int> GetFinishedMoviesCountAsync()
            => _database.Table<MovieEntity>()
                .Where(m => m.Status == WatchStatus.Finished)
                .CountAsync();

        public Task<int> GetFavoriteMoviesCountAsync()
            => _database.Table<MovieEntity>()
                .Where(m => m.IsFavorite)
                .CountAsync();


        public async Task ResetDatabaseAsync()
        {
            await _database.DeleteAllAsync<MovieEntity>();
            await _database.DeleteAllAsync<SeriesEntity>();
        }
    }
}