using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LifeMate.Views;
using Syncfusion.XForms.DataForm;
using Xamarin.Forms;
namespace LifeMate.Models
{
    public class Event : INotifyPropertyChanged
    {
        private string _subject;
        private string _location;
        private string _description;
        private DateTime _startTime;
        private DateTime _endTime;
        private Color _color;

        private List<Color> GetColors = new List<Color> { Color.Red, Color.Blue, Color.Black, Color.Green };

        


        public string Subject
        {
            get => _subject;
            set
            {
                if (value == _subject) return;
                _subject = value;

                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (value == _description) return;
                _description = value;

                OnPropertyChanged();
            }
        }

        public string Location
        {
            get => _location;
            set
            {
                if (value == _location) return;
                _location = value;
                OnPropertyChanged();
            }
        }

        [Display(AutoGenerateField = false)]
        public Color col
        {
            get => _color;
            set
            {
                if (value == _color) return;
                _color = value;
                OnPropertyChanged();
            }
        }


        #region DataFormSource
        private DateTime _date;
        [DataType(DataType.Date), Display(Name = "Date")]
        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Equals(_date)) return;

                _date = value;
                StartTime = new DateTime(_date.Year, _date.Month, _date.Day,
                    StartTime.Hour, StartTime.Minute, StartTime.Second);
            }
        }

        private DateTime _inputStartTime;
        [DataType(DataType.Time), Display(Name = "Start Time")]
        public DateTime InputStartTime
        {
            get => _inputStartTime;
            set
            {
                if (value.Equals(_inputStartTime)) return;

                _inputStartTime = value;
                StartTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, _inputStartTime.Hour,
                    _inputStartTime.Minute, _inputStartTime.Second);
            }
        }

        private DateTime _inputEndTime;
        [DataType(DataType.Time), Display(Name = "End Time")]
        public DateTime InputEndTime
        {
            get => _inputEndTime;
            set
            {
                if (value.Equals(_inputEndTime)) return;

                _inputEndTime = value;
                EndTime = new DateTime(EndTime.Year, EndTime.Month, EndTime.Day, _inputEndTime.Hour,
                    _inputEndTime.Minute, _inputEndTime.Second);
            }
        }
        #endregion

        [Display(AutoGenerateField = false)]
        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                if (value.Equals(_startTime)) return;
                _startTime = value;
                EndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour + 1, StartTime.Minute,
                    StartTime
                        .Second);
                OnPropertyChanged();
            }
        }

        [Display(AutoGenerateField = false)]
        public DateTime EndTime
        {
            get => _endTime;
            set
            {
                if (value.Equals(_endTime)) return;
                _endTime = value;
                OnPropertyChanged();
            }
        }

        public Event(string subject, string location, string description)
        {
            Subject = subject;
            Location = location;
            Description = description;
            Date = DateTime.Now;
            InputStartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour + ItemsPage.number, DateTime.Now.Minute,
                DateTime.Now
                    .Second);
            InputEndTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour + 2, StartTime.Minute,
                StartTime
                    .Second);


        }

        public Event()
        {
            Date = DateTime.Now;
            InputStartTime = DateTime.Now;
            InputEndTime = DateTime.Now;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Random random = new Random();
            int number = random.Next(0, 4);
            col = GetColors[number];
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
