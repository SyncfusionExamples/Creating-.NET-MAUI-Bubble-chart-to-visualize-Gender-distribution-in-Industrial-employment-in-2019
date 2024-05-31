using Syncfusion.Maui.Charts;
using System;
using System.Globalization;

namespace EmployementDistribution
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        List<int> SelectedIndexes = new List<int>();

        List<SolidColorBrush> Brushes = new List<SolidColorBrush>
        {
            new SolidColorBrush(Color.FromArgb("#01BEFE")),
            new SolidColorBrush(Color.FromArgb("#FFDD00")),
            new SolidColorBrush(Color.FromArgb("#FF7D00")),
            new SolidColorBrush(Color.FromArgb("#FF006D")),
            new SolidColorBrush(Color.FromArgb("#ADFF02")),
            new SolidColorBrush(Color.FromArgb("#8F00FF")),
        };

        List<SolidColorBrush> AlphaBrushes = new List<SolidColorBrush>
        {
            new SolidColorBrush(Color.FromArgb("#3501BEFE")),
            new SolidColorBrush(Color.FromArgb("#35FFDD00")),
            new SolidColorBrush(Color.FromArgb("#35FF7D00")),
            new SolidColorBrush(Color.FromArgb("#35FF006D")),
            new SolidColorBrush(Color.FromArgb("#35ADFF02")),
            new SolidColorBrush(Color.FromArgb("#358F00FF")),
        };

        private void SeriesSelectionBehavior_SelectionChanging(object sender, ChartSelectionChangingEventArgs e)
        {
            foreach (var index in e.NewIndexes)
            {
                if (!SelectedIndexes.Contains(index))
                {
                    SelectedIndexes.Add(index);
                } 
            }

            foreach (var index in e.OldIndexes)
            {
                if (SelectedIndexes.Contains(index))
                {
                    SelectedIndexes.Remove(index);
                }
                else if (e.NewIndexes.Count == 0)
                {
                    SelectedIndexes.Add(index);
                }
            }

            if (SelectedIndexes.Count == 0)
            {
                foreach (var series in myChart.Series)
                {
                    series.Fill = Brushes[myChart.Series.IndexOf(series)];
                }
            }
            else
            {
                foreach (var series in myChart.Series)
                {
                    series.Fill = AlphaBrushes[myChart.Series.IndexOf(series)];
                }

                foreach (var index in SelectedIndexes)
                {
                    myChart.Series[index].Fill = Brushes[index];
                }   
            }
        }
    }
    
}
