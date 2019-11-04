using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LifeMate.Models;
using LifeMate.Views;
using LifeMate.ViewModels;

namespace LifeMate.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {

        public static int number;
        public ItemsPage()
        {
            InitializeComponent();

            DateTime currentDate = DateTime.Now;
            //setting minimum display date
            DateTime minDate = new DateTime(currentDate.Year - 1, currentDate.Month, currentDate.Day, 10, 0, 0);
            schedule.MinDisplayDate = minDate;

            //setting maximum display date
            DateTime maxDate = new DateTime(currentDate.Year + 1, currentDate.Month, currentDate.Day, 10, 0, 0);
            schedule.MaxDisplayDate = maxDate;


        }
        private void AddItem_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            number = random.Next(0, 5);
            Navigation.PushModalAsync(new AddRandomEvent(), true);
        }
    }
}