using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.SfSchedule.XForms;

namespace LifeMate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        //SfSchedule schedule;
        public CalendarPage()
        {
            InitializeComponent();

            DateTime currentDate = DateTime.Now;
            //setting minimum display date
            DateTime minDate = new DateTime(currentDate.Year - 1, currentDate.Month, currentDate.Day, 10, 0, 0);
            schedule.MinDisplayDate = minDate;

            //setting maximum display date
            DateTime maxDate = new DateTime(currentDate.Year + 1, currentDate.Month, currentDate.Day, 10, 0, 0);
            schedule.MaxDisplayDate = maxDate;

            schedule.CellTapped += CellTappedEventHandler;

        }

        private void CellTappedEventHandler(object sender, CellTappedEventArgs e)
        {
            schedule.ScheduleView = ScheduleView.DayView;
        }

    }
}