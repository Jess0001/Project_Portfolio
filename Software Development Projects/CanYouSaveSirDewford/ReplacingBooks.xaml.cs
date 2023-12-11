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
using System.Windows.Shapes;

namespace CanYouSaveSirDewford
{
    /// <summary>
    /// Interaction logic for Replacing_Books.xaml
    /// </summary>
    public partial class ReplacingBooks : Window
    {
        public ReplacingBooks()
        {
            InitializeComponent();
            displayDeweyList = new TextBlock[10] { dValue1, dValue2, dValue3, dValue4, dValue5, dValue6, dValue7, dValue8, dValue9, dValue10 };
            GenerateDeweyCharacters.GenerateValues();
        }

        /// <summary>
        /// create variables
        /// </summary>
        public static TextBlock[] displayDeweyList;
        public static List<String> deweyList = new List<String>();
        public static List<String> deweyListAscend = new List<String>();

        private void swapLeft_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int moveBook = int.Parse(bookInputNo.Text);
                String tempValue;

                TextBlock[] displayDeweyList = new TextBlock[10] { dValue1, dValue2, dValue3, dValue4, dValue5, dValue6, dValue7, dValue8, dValue9, dValue10 };
                tempValue = displayDeweyList[moveBook - 1].Text;
                displayDeweyList[moveBook - 1].Text = displayDeweyList[moveBook - 2].Text;
                displayDeweyList[moveBook - 2].Text = tempValue;

                tempValue = deweyList[moveBook - 1];
                deweyList[moveBook - 1] = deweyList[moveBook - 2];
                deweyList[moveBook - 2] = tempValue;
            }
            catch (IndexOutOfRangeException)
            {
                /// <summary>
                /// give warning message and default value for exception
                /// </summary>
                MessageBox.Show("Invalid Input!");
                bookInputNo.Text = "10";
            }
        }

        private void swapRight_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int moveBook = int.Parse(bookInputNo.Text);
                String tempValue;

                TextBlock[] displayDeweyList = new TextBlock[10] { dValue1, dValue2, dValue3, dValue4, dValue5, dValue6, dValue7, dValue8, dValue9, dValue10 };

                tempValue = displayDeweyList[moveBook - 1].Text;
                displayDeweyList[moveBook - 1].Text = displayDeweyList[moveBook].Text;
                displayDeweyList[moveBook].Text = tempValue;

                tempValue = deweyList[moveBook - 1];
                deweyList[moveBook - 1] = deweyList[moveBook];
                deweyList[moveBook] = tempValue;

            }
            /// <summary>
            /// give warning an default value for exception
            /// </summary>
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Invalid Input!");
                bookInputNo.Text = "1";
            }
        }

        private void check_btn_Click(object sender, RoutedEventArgs e)
        {
            PointSystem.CalculateReplaceBooksPoints();

            String s1 = String.Join("\t", deweyList);
            String s2 = String.Join("\t", deweyListAscend);
            MessageBox.Show("You have Answered >> " + s1 + "\nThe correct answer is >> " + s2 + "\nPoints earned >> " + PointSystem.points);
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
