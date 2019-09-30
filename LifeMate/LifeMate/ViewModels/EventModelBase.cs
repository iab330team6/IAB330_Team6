using System;
using System.Collections.Generic;
using System.Text;
using LifeMate.Models;
using LifeMate.Services;
using Xamarin.Forms;

namespace LifeMate.ViewModels
{
    public class EventModelBase
    {
        public IList<Event> Event { get; set; }

        public EventModelBase()
        {
            Event = DataService.Instance.Data;
        }
    }
}
