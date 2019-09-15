﻿using System;
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
        int i = 0;

        private void CreateGrid()
        {
            // Tried Assigning strings from list into the created labels from grid. Not sure how to call it exactly

            Label yearViewer = new Label()
            {
                Text = "2019",
                BackgroundColor = Color.WhiteSmoke,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Button profilePicHolder = new Button() // This will be changed to a profile pic rather than a button?
            {
                Text = "PP",
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke
            };


            Button birthdays = new Button()
            {
                Text = "Birthdays",
                WidthRequest = 120,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke
            };

            Button exercise = new Button()
            {
                Text = "Exercise",
                WidthRequest = 90,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke
            };

            Button alarm = new Button()
            {
                Text = "Alarm",
                WidthRequest = 70,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke
            };

            Button work = new Button()
            {
                Text = "Work",
                WidthRequest = 70,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.WhiteSmoke
            };

            Label viewer = new Label()
            {
                Text = "User1234\nEvents",
                BackgroundColor = Color.WhiteSmoke,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Start,
                HorizontalTextAlignment = TextAlignment.Start
            };

            grid.Children.Add(yearViewer, 0, 4, 0, 1);

            for (int rowindex = 0; rowindex < 3; rowindex++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
                for (int columnindex = 0; columnindex < 4; columnindex++)
                {
                    Label label = new Label()
                    {
                        Text = months[i],
                        BackgroundColor = Color.WhiteSmoke,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        VerticalTextAlignment = TextAlignment.Start,
                        HorizontalTextAlignment = TextAlignment.Start
                    };
                    grid.Children.Add(label, columnindex, rowindex + 1);
                    i++;
                }
            }

            grid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
            grid.Children.Add(profilePicHolder, 0, 5);
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            grid.Children.Add(viewer, 1, 4, 3, 9); // column, row, width?, height?
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            grid.Children.Add(birthdays, 0, 6);
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            grid.Children.Add(exercise, 0, 7);
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            grid.Children.Add(alarm, 0, 8);
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            grid.Children.Add(work, 0, 9);
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });

            // Grid ScrollView
            calendarScrollView.Content = grid;
        }
    }
}