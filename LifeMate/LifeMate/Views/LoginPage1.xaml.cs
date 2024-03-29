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
    public partial class LoginPage1 : ContentPage
    {
        private MainPage MainPage;

        public LoginPage1()
        {
            InitializeComponent();
        }

        private void btnSignup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignupPage(), true);
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}