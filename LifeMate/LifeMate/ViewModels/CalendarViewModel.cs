using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using LifeMate.Views;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace LifeMate.ViewModels
{
    public class CalendarViewModel : ContentPage
    {
        public ObservableCollection<Meeting> Meetings { get; set; }
        List<string> eventNameCollection;
        List<Color> colorCollection;
        public ICommand ScheduleCellLongPressed { get; set; }

        public CalendarViewModel()
        {
            Title = "Calendar";
            Meetings = new ObservableCollection<Meeting>();
            CreateEventNameCollection();
            CreateColorCollection();
            CreateAppointments();
            ScheduleCellLongPressed = new Command<CellTappedEventArgs>(LongPressed);
        }

        /// <summary>
        /// Creates meetings and stores in a collection.  
        /// </summary>
        private void CreateAppointments()
        {
            Random randomTime = new Random();
            List<Point> randomTimeCollection = GettingTimeRanges();
            DateTime date;
            DateTime DateFrom = DateTime.Now.AddDays(-10);
            DateTime DateTo = DateTime.Now.AddDays(10);
            DateTime dataRangeStart = DateTime.Now.AddDays(-3);
            DateTime dataRangeEnd = DateTime.Now.AddDays(3);

            for (date = DateFrom; date < DateTo; date = date.AddDays(1))
            {
                if ((DateTime.Compare(date, dataRangeStart) > 0) && (DateTime.Compare(date, dataRangeEnd) < 0))
                {
                    for (int AdditionalAppointmentIndex = 0; AdditionalAppointmentIndex < 3; AdditionalAppointmentIndex++)
                    {
                        Meeting meeting = new Meeting();
                        int hour = (randomTime.Next((int)randomTimeCollection[AdditionalAppointmentIndex].X, (int)randomTimeCollection[AdditionalAppointmentIndex].Y));
                        meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                        meeting.To = (meeting.From.AddHours(1));
                        meeting.EventName = eventNameCollection[randomTime.Next(3)];
                        meeting.color = colorCollection[randomTime.Next(3)];
                        if (AdditionalAppointmentIndex % 3 == 0)
                            meeting.AllDay = true;
                        Meetings.Add(meeting);
                    }
                }
                else
                {
                    Meeting meeting = new Meeting();
                    meeting.From = new DateTime(date.Year, date.Month, date.Day, randomTime.Next(3, 11), 0, 0);
                    meeting.To = (meeting.From.AddHours(1));
                    meeting.EventName = eventNameCollection[randomTime.Next(3)];
                    meeting.color = colorCollection[randomTime.Next(3)];
                    Meetings.Add(meeting);
                }
            }
        }

        /// <summary>  
        /// Creates event names collection.  
        /// </summary>  
        private void CreateEventNameCollection()
        {
            eventNameCollection = new List<string>();
            eventNameCollection.Add("General Meeting");
            eventNameCollection.Add("Work");
            eventNameCollection.Add("Exercise");
            eventNameCollection.Add("Wake Up");
            //eventNameCollection.Add("Performance Check");
            //eventNameCollection.Add("Yoga Therapy");
            //eventNameCollection.Add("Plan Execution");
            //eventNameCollection.Add("Project Plan");
            //eventNameCollection.Add("Consulting");
            //eventNameCollection.Add("Performance Check");
        }

        /// <summary>  
        /// Creates color collection.  
        /// </summary>  
        private void CreateColorCollection()
        {
            colorCollection = new List<Color>();
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF1BA1E2"));
            //colorCollection.Add(Color.FromHex("#FFD80073"));
            //colorCollection.Add(Color.FromHex("#FFA2C139"));
            //colorCollection.Add(Color.FromHex("#FFA2C139"));
            //colorCollection.Add(Color.FromHex("#FFD80073"));
            //colorCollection.Add(Color.FromHex("#FF339933"));
            //colorCollection.Add(Color.FromHex("#FFE671B8"));
            //colorCollection.Add(Color.FromHex("#FF00ABA9"));
        }

        private void LongPressed(CellTappedEventArgs args)
        {
            var selectedDateTime = args.Datetime;
        }

        /// <summary>
        /// Gets the time ranges.
        /// </summary>
        private List<Point> GettingTimeRanges()
        {
            List<Point> randomTimeCollection = new List<Point>();
            randomTimeCollection.Add(new Point(9, 11));
            randomTimeCollection.Add(new Point(12, 14));
            randomTimeCollection.Add(new Point(15, 17));
            return randomTimeCollection;
        }
    }
}
