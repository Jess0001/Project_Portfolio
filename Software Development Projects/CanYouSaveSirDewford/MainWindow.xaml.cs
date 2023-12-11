using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CanYouSaveSirDewford
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //display total points
            totalPoints.Content = "Points:\t" + PointSystem.total.ToString();
        }

        //exit
        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        //go to replace books
        private void replaceBooks_btn_Click(object sender, RoutedEventArgs e)
        {
            ReplacingBooks replacingBooks = new ReplacingBooks();
            replacingBooks.Show();
            Close();
        }

        //go to identifying areas
        private void identifyAreas_btn_Click(object sender, RoutedEventArgs e)
        {
            IdentifyingAreas identifyingAreas = new IdentifyingAreas();
            identifyingAreas.Show();
            Close();
        }

        //go to finding call numbers
        private void findingCallNumbers_btn_Click(object sender, RoutedEventArgs e)
        {
            CallTheNumber callTheNumber = new CallTheNumber();
            callTheNumber.Show();
            Close();
        }

        //go to story line
        private void storyline_btn_Click(object sender, RoutedEventArgs e)
        {
            Stories stories = new Stories();
            stories.Show();
            Close();
        }
    }
}
