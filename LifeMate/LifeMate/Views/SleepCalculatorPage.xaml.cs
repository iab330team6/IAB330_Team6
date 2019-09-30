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
    public partial class SleepCalculatorPage : ContentPage
    {
        public SleepCalculatorPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //open picker dialog
            date.IsOpen = !date.IsOpen;
        }
    }
}