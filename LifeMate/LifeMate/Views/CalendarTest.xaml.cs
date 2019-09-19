using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.SfCalendar.XForms;

namespace LifeMate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarTest : ContentPage
    {
        public CalendarTest()
        {
            InitializeComponent();
            SfCalendar calendar = new SfCalendar();

            // Restrict Dates
            calendar.MoveToDate = new DateTime(2019, 12, 31);
            calendar.MinDate = new DateTime(2019, 10, 25);
            calendar.MaxDate = new DateTime(2019, 12, 31);

            // Set Blackout Dates
            List<DateTime> black_dates = new List<DateTime>();
            for (int i = 0; i < 5; i++)
            {
                DateTime date = new DateTime(2019, 12, 1 + i);
                black_dates.Add(date);
            }
            calendar.BlackoutDates = black_dates;

            // Enable Multiple Selection
            calendar.SelectionMode = Syncfusion.SfCalendar.XForms.SelectionMode.MultiSelection;



            this.Content = calendar;
        }

    }
}