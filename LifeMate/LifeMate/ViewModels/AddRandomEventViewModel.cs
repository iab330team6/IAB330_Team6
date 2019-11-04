using LifeMate.Models;
using LifeMate.Services;
using LifeMate.Views;
using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace LifeMate.ViewModels
{
    public class AddRandomEventViewModel
    {
        static private List<String> Random_subject = new List<string> { "Suggested Activity: \nExercise", "Suggested Activity: \nWatch A Movie", "Suggested Activity: \nPlay Games", 
                                                                        "Suggested Activity: \nWork", "Suggested Activity: \nRelax" };


        public Event NewMeeting { get; set; } = new Event(Random_subject[ItemsPage.number], "", "");

        public Command Submit { get; set; }

        public AddRandomEventViewModel()
        {
            var data = DataService.Instance.Data;

            Submit = new Command(() => { data.Add(NewMeeting); });
        }
    }
}
