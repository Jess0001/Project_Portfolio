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
    /// Interaction logic for Semester_Info.xaml
    /// </summary>
    public partial class Semester_Info : Window
    {
        public Semester_Info()
        {
            InitializeComponent();
        }

        //Create variables
        public static DateTime beginDate;
        public static DateTime finishDate;
        public static int numWeeks;


        private void next3_Click(object sender, RoutedEventArgs e)
        {
            //start date can not after or the the same as end date for the semester 
            if (startDate.SelectedDate.Value.Date >= endDate.SelectedDate.Value.Date)
            {
                //Message warns user of this
                string messageBoxText = "The semester start date cannot occur after or at the same time as the end date of the semester.";
                string caption = "Insufficient date range!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            //Number of weeks can be less than or equal to 0
            else if (int.Parse(noWeeks.Text) <= 0)
            {
                //Message warns user of this
                string messageBoxText = "The number of weeks within the semester cannot be less than or equal to 0.";
                string caption = "Insufficient number of weeks!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            else
            {
                //Store selected dates in variables
                beginDate = startDate.SelectedDate.Value.Date;
                finishDate = endDate.SelectedDate.Value.Date;
                numWeeks = int.Parse(noWeeks.Text);

                //Sends user to Module Details window
                Module_Details module_Details = new Module_Details();
                module_Details.Show();
                Close();
            }
            
        }
    }
}
