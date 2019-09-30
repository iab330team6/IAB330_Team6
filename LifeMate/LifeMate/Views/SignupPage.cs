using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SQLitePCL;
using SQLite;

using Xamarin.Forms;
using CoreData;
using System.Data.SQLite;
using LifeMate.Models;

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

            Content = stackLayout;
        }

        private async void createBtn_Clicked(object sender, EventArgs e)
        {
            var db = new SQLite.SQLiteConnection(dbPath);
            db.CreateTable<LoginInfo>();

            var maxPK = db.Table<LoginInfo>().OrderByDescending(c => c.username).FirstOrDefault();

            LoginInfo loginInfo = new LoginInfo()
            {
                username = userEntry.Text,
                password = passwordEntry.Text
            };
            db.Insert(loginInfo);
            await DisplayAlert(null, "Account: " + loginInfo.username + "created.", "Ok");
            await Navigation.PopAsync();
        }
    }
}