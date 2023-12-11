using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Study_Planner
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void next2_Click(object sender, RoutedEventArgs e)
        {
            //References semester info window
            Semester_Info semester_Info = new Semester_Info();
            
            //Add blackout dates
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 1, 1)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 3, 21)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 4, 27)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 5, 1)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 6, 16)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 8, 9)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 9, 24)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 16)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 24)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 25)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 26)));
            semester_Info.startDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 31)));
            
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 1, 1)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 3, 21)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 4, 27)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 5, 1)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 6, 16)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 8, 9)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 9, 24)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 16)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 24)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 25)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 26)));
            semester_Info.endDate.BlackoutDates.Add(new CalendarDateRange(new DateTime(DateTime.Now.Year, 12, 31)));

            //sends user to semester info window
            semester_Info.Show();
            Close();
        }
    }
}
