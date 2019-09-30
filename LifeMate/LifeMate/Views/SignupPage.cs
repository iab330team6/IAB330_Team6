using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LifeMate.Views
{
    public class SignupPage : ContentPage
    {
        private Entry userEntry;
        private Entry passwordEntry;
        private Button createBtn;

        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "lifeMateDB.db");

        public SignupPage()
        {
            this.Title = "Create An Account!";

            StackLayout stackLayout = new StackLayout();

            userEntry = new Entry();
            userEntry.Keyboard = Keyboard.Text;
            userEntry.Placeholder = "Username";
            stackLayout.Children.Add(userEntry);

            passwordEntry = new Entry();
            passwordEntry.Keyboard = Keyboard.Text;
            passwordEntry.Placeholder = "Password";
            stackLayout.Children.Add(passwordEntry);

            createBtn = new Button();
            createBtn.Text = "Create Account";
            createBtn.Clicked += createBtn_Clicked;
            stackLayout.Children.Add(createBtn);
        }

        private void createBtn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}