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
    public partial class Calendar : ContentPage
    {
        //SfSchedule schedule;
        public Calendar()
        {
            InitializeComponent();
            //schedule = new SfSchedule();

            //schedule.ScheduleView = ScheduleView.MonthView;
            ////view appointments in inline  
            //schedule.ShowAppointmentsInline = true;


            //this.Content = schedule;
        }

    }
}