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
    /// Interaction logic for Weekly_Schedule.xaml
    /// </summary>
    public partial class Weekly_Schedule : Window
    {
        public Weekly_Schedule()
        {
            InitializeComponent();
        }


        private void exit_Click(object sender, RoutedEventArgs e)
        {
            //Exits application
            System.Environment.Exit(0);
        }
    }
}
