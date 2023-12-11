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
    /// Interaction logic for Studied_Hours.xaml
    /// </summary>
    public partial class Studied_Hours : Window
    {
        public Studied_Hours()
        {
            InitializeComponent();
        }

        
        private void next5_Click(object sender, RoutedEventArgs e)
        {
            //negative numbers are not allowed
            if (int.Parse(hoursStudied.Text) < 0)
            {
                //warning message shows
                string messageBoxText1 = "The hours studied cannot be less than 0.";
                string caption1 = "Insufficient amount!";
                MessageBoxButton button1 = MessageBoxButton.OK;
                MessageBoxImage icon1 = MessageBoxImage.Warning;
                MessageBoxResult result1;

                result1 = MessageBox.Show(messageBoxText1, caption1, button1, icon1, MessageBoxResult.OK);
            }
            else
            {
                //Calculating self-study hours
                int ssHours = ((Module_Details.numCredits * 10) / Semester_Info.numWeeks) - Module_Details.classHours;
                //Storing values in variable
                int finishedHours = int.Parse(hoursStudied.Text);
                DateTime ssDate = sDate.SelectedDate.Value.Date;
                int remainHours = ssHours - finishedHours;
                //Storing values in SetHours set
                Module.SetHours.Add(new Module { Code = Module_Details.mod_Code, Name = Module_Details.mod_Name, NoCredits = Module_Details.numCredits, WeeklyClassHrs = Module_Details.classHours, WeeklyStudyHours = ssHours, CompleteHours = finishedHours, studDate = sDate.DisplayDate, AvailableHours = remainHours });
                
                //Asks user if they would like to add another module
                string messageBoxText = "Would you like to add another module?";
                string caption = "Add Module?";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Question;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                //if yes
                if (result == MessageBoxResult.Yes)
                {
                    //Send user to Module Details window
                    Module_Details module_Details = new Module_Details();
                    module_Details.Show();
                    Close();
                }
                //if no
                else if (result == MessageBoxResult.No)
                {
                    //Refers to Weekly Schedule window
                    Weekly_Schedule weekly_Schedule = new Weekly_Schedule();
                    //Sets data for weekly schedule
                    weekly_Schedule.semesterStart.Text = Semester_Info.beginDate.ToString("dd MMMM yyyy");
                    weekly_Schedule.endSemester.Text = Semester_Info.finishDate.ToString("dd MMMM yyyy");
                    foreach (Module i in Module.SetHours)
                    {
                        if(i.AvailableHours < 0)
                        {
                            i.AvailableHours = 0;
                        }
                        else
                        {
                            weekly_Schedule.schedule.Content += i.ToString() + "\n";
                        }
                    }
                    //Sends user to weekly schedule window 
                    weekly_Schedule.Show();
                    Close();
                }
            }
        }

    }
}
