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

            //btnSignup.Clicked += btnSignup_Clicked();

            Content = stackLayout;

        }

        /*private EventHandler btnSignup_Clicked()
        {
           Navigation.PushModalAsync(new SignupPage());
        }*/
    }
}