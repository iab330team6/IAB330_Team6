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

        private List<String> months = new List<String>() { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

        

        private void CreateGrid()
        {
            // Tried Assigning strings from list into the created labels from grid. Not sure how to call it exactly

            //for (int i = 0; i < months.Count; i++)
            //{
            //    for (int rowindex = 0; rowindex < 3; rowindex++)
            //    {
            //        grid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
            //        for (int columnindex = 0; columnindex < 4; columnindex++)
            //        {
            //            foreach (string v in months)
            //            {
            //                Label label = new Label()
            //                {
            //                    Text = months[i],
            //                    BackgroundColor = Color.WhiteSmoke,
            //                    HorizontalOptions = LayoutOptions.FillAndExpand,
            //                    VerticalOptions = LayoutOptions.FillAndExpand,
            //                    VerticalTextAlignment = TextAlignment.Start,
            //                    HorizontalTextAlignment = TextAlignment.Start
            //                };
            //                grid.Children.Add(label, columnindex, rowindex);
            //            }

            //        }
            //    }

            //}


            // Defining Grids
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.RowDefinitions.Add(new RowDefinition { Height = 50 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 50 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 50 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 50 });

            // Months Labels
            var january = new Label
            { Text = "JAN",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var february = new Label
            { Text = "FEB",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var march = new Label
            { Text = "MAR",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var april = new Label
            { Text = "APR",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var may = new Label
            { Text = "MAY",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var june = new Label
            { Text = "JUN",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var july = new Label
            { Text = "JUL",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var august = new Label
            { Text = "AUG",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var september = new Label
            { Text = "SEP",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var october = new Label
            { Text = "OCT",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var november = new Label
            { Text = "NOV",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            var december = new Label
            { Text = "DEC",
            BackgroundColor = Color.WhiteSmoke,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            VerticalTextAlignment = TextAlignment.Start,
            HorizontalTextAlignment = TextAlignment.Start};

            Button profilePicHolder = new Button()
            {
                Text = "PP",
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center,
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke};


            Button birthdays = new Button()
            {
                Text = "Birthdays",
                WidthRequest = 120,
                HeightRequest = 50,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center,
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke};

            Button exercise = new Button()
            {
                Text = "Exercise",
                WidthRequest = 90,
                HeightRequest = 50,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center,
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke};

            Button alarm = new Button()
            {
                Text = "Alarm",
                WidthRequest = 70,
                HeightRequest = 50,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center,
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke};

            Button work = new Button()
            {
                Text = "Work",
                WidthRequest = 70,
                HeightRequest = 50,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center,
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke};

            Label viewer = new Label()
            {
                Text = "User1234\nEvents",
                BackgroundColor = Color.WhiteSmoke,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Start,
                HorizontalTextAlignment = TextAlignment.Start};

            // Months into grid
            grid.Children.Add(january, 0, 0);
            grid.Children.Add(february, 1, 0);
            grid.Children.Add(march, 2, 0);
            grid.Children.Add(april, 3, 0);
            grid.Children.Add(may, 0, 1);
            grid.Children.Add(june, 1, 1);
            grid.Children.Add(july, 2, 1);
            grid.Children.Add(august, 3, 1);
            grid.Children.Add(september, 0, 2);
            grid.Children.Add(october, 1, 2);
            grid.Children.Add(november, 2, 2);
            grid.Children.Add(december, 3, 2);
            grid.Children.Add(profilePicHolder, 0, 3);
            grid.Children.Add(viewer, 1, 3, 3, 4);
            grid.Children.Add(birthdays, 0, 4);
            grid.Children.Add(exercise, 0, 5);
            grid.Children.Add(alarm, 0, 6);
            grid.Children.Add(work, 0, 7);


            // Grid ScrollView
            calendarScrollView.Content = grid;
        }
    }
}