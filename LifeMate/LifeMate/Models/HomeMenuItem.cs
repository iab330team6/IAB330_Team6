using System;
using System.Collections.Generic;
using System.Text;

namespace LifeMate.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Calendar,
        Profile,
        CalendarTest
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
