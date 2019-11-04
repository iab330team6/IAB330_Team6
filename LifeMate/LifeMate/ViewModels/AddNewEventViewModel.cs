using LifeMate.Models;
using LifeMate.Services;
using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace LifeMate.ViewModels
{
    public class AddNewEventViewModel
    {

        public Event NewMeeting { get; set; } = new Event();

        public Command Submit { get; set; }

        public AddNewEventViewModel()
        {
            var data = DataService.Instance.Data;

            Submit = new Command(() => { data.Add(NewMeeting); });
        }
    }
}
