﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifeMate.Models
{
    public enum MenuItemType
    {
        Main,
        SleepCalculator,
        Calendar,
        Login
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Source_name { get; set; }
    }
}
