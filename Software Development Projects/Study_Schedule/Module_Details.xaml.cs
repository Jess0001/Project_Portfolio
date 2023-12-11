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
    /// Interaction logic for Module_Details.xaml
    /// </summary>
    public partial class Module_Details : Window
    {
        public Module_Details()
        {
            InitializeComponent();
        }

        //Create variables
        public static string mod_Code;
        public static string mod_Name;
        public static int numCredits;
        public static int classHours;

        private void next4_Click(object sender, RoutedEventArgs e)
        {
            //no negative values for number of credits
            if (int.Parse(noCredits.Text) < 0)
            {
                //Message warns user of this
                string messageBoxText = "The number of credits cannot be less than 0.";
                string caption = "Insufficient credits!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            //no negative values for number of class hours
            else if (int.Parse(classHrs.Text) < 0)
            {
                //Message warns user of this
                string messageBoxText = "The class hours cannot be less than 0.";
                string caption = "Insufficient hours!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            else
            {
                //Storing values in variables
                mod_Code = moduleCode.Text;
                mod_Name = moduleName.Text;
                numCredits = int.Parse(noCredits.Text);
                classHours = int.Parse(classHrs.Text);

                //References study hours window
                Studied_Hours studied = new Studied_Hours();

                //Change text output
                string sQuery = "Have you studied for " + moduleCode.Text + " yet?";
                studied.studyQuery.Text = sQuery;

                //Sends user to study hours window
                studied.Show();
                Close();
            }

        }
    }
}
