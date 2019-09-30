﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LifeMate.Models
{
    public enum MenuItemType
    {
        Main,
        About,
        SleepCalculator,
        Calendar
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
