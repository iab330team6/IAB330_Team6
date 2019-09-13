using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeMate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        private Grid grid = new Grid();
        public CalendarPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CreateGrid();
        }

        List<String> months = new List<String>() { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

        private void CreateGrid()
        {
            // Tried Assigning strings from list into the created labels from grid. Not sure how to call it exactly

            for (int rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
                for (int columnIndex = 0; columnIndex  < 4; columnIndex++)
                {
                    var label = new Label()
                    {
                        BackgroundColor = Color.WhiteSmoke,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        VerticalTextAlignment = TextAlignment.Start,
                        HorizontalTextAlignment = TextAlignment.Start
                    };

                    foreach (string i in months)
                    {
                        label.Text = i;
                    }
                    grid.Children.Add(label, columnIndex, rowIndex);
                }
            }
            calendarScrollView.Content = grid;
        }
    }
}