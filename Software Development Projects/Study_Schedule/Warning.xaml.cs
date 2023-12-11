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
    /// Interaction logic for Warning.xaml
    /// </summary>
    public partial class Warning : Window
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void terms_Click(object sender, RoutedEventArgs e)
        {
            //message displays terms and condition to user
            string messageBoxText = "When agreeing to use Time Planner, the user agrees that time planner will not be " +
                "responsible for them sticking to their planned schedule.Time Planner outputs information based off the " +
                "estimated calculations as well as user inputs.Time Planner's data is made as realistically acurate as " +
                "possible however, 100 % accuracy for the user's planner cannot be guaranteed. Once the schedule is made, " +
                "user will be liable to sticking to that schedule as well as managing his / her own daily lifestyle needs." +
                "Time Planner cannot and will not be liable for you not being able to manage your personal schedule as well " +
                "as study schedule." +
                "\nStudy Planner also pledges not to share user information on its accountability, as in accordance with the " +
                "POPI Act. User is liable to the protection his/her information else wise";
            string caption = "Terms and Conditions";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

        private void exit1_Click(object sender, RoutedEventArgs e)
        {
            //exits application
            System.Environment.Exit(0);
        }

        private void next1_Click(object sender, RoutedEventArgs e)
        {
            //if user does not agree to terms and conditions
            if (agree.IsChecked != true)
            {
                //Message prompts user to agree to continue using application
                string messageBoxText = "Inaccurrate data! \nTo continue using this application, the Terms and Conditions must be accepted." +
                    "\nAgree to the Terms and conditions or exit.";
                string caption = "Data Inaccurate!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            //When user agrees
            else
            {
                //Sends user to welcome window
                Welcome welcome = new Welcome();
                welcome.Show();
                Close();
            }
        }
    }
}
