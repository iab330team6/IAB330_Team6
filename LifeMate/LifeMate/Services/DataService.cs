using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LifeMate.Models;

namespace LifeMate.Services
{
    public class DataService
    {
        public ObservableCollection<Event> Data { get; set; }

        private static DataService dataService;

        public static DataService Instance => dataService ?? (dataService = new DataService());

        private DataService()
        {
            Data = new ObservableCollection<Event>
            {
                new Event("General Meeting", "Online", new DateTime(2019, 4, 1, 10, 0, 0)),
                new Event("Release Retrospective", "Office", new DateTime(2019, 4, 6, 9, 0, 0)),
                new Event("Sprint Meeting", "Online", new DateTime(2019, 4, 3, 10, 0, 0)),
                new Event("Release Planning", "Online", new DateTime(2019, 4, 10, 16, 0, 0)),
                new Event("General Meeting", "Office", new DateTime(2019, 4, 25, 11, 0, 0)),
                new Event("Customer Meeting", "Online", new DateTime(2019, 5, 3, 12, 0, 0)),
                new Event("Sprint Meeting", "Office", new DateTime(2019, 5, 6, 15, 0, 0)),
                new Event("Sprint Meeting", "Online", new DateTime(2019, 5, 21, 13, 0, 0)),
                new Event("General Meeting", "Office", new DateTime(2019, 6, 8, 16, 0, 0)),
                new Event("General Meeting", "Online", new DateTime(2019, 6, 29, 11, 0, 0))
            };

        }
    }
}
