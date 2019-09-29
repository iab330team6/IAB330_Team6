using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeMate.Models;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeMate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewEvent : ContentPage
    {
        public AddNewEvent()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}