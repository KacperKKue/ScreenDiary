using ScreenDiary.Data.Entities;
using ScreenDiary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ScreenDiary.ViewModels
{
    internal class SeriesViewModel
    {
        public ObservableCollection<SeriesEntity> Series { get; } = new();

        public SeriesViewModel()
        {
            LoadSeries();
        }

        public async void LoadSeries()
        {
            var seriesList = await DatabaseService.Database.GetSeriesAsync();
            Series.Clear();
            foreach (var series in seriesList)
                Series.Add(series);
        }
    }
}
