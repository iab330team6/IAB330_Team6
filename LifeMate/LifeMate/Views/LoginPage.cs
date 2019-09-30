using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LifeMate.Views
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {
            this.Title = "Welcome to LifeMate!";
            StackLayout stackLayout = new StackLayout();
            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            Button btnSignup = new Button();
            btnSignup.Text = "Signup";
            stackLayout.Children.Add(btnLogin);
            stackLayout.Children.Add(btnSignup);

            Content = stackLayout;

        }

        private async void btnSignup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }
    }
}