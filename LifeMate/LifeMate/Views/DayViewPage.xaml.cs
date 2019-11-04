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
    public partial class DayViewPage : ContentPage
    {
        public DayViewPage()
        {
            InitializeComponent();

            schedule.CellDoubleTapped += CellTappedEventHandler;
        }

        private void AddItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddNewEvent(), true);
        }

        private void Handle_HeaderTapped(object sender, HeaderTappedEventArgs e)
        {
            Navigation.PushModalAsync(new CalendarPage(), true);
        }

        private void CellTappedEventHandler(object sender, CellTappedEventArgs e)
        {
            Navigation.PushModalAsync(new AddNewEvent(), true);
        }
    }
}