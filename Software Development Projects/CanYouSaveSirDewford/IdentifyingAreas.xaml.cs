using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Threading;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace CanYouSaveSirDewford
{
    /// <summary>
    /// Interaction logic for IdentifyingAreas.xaml
    /// </summary>
    public partial class IdentifyingAreas : Window
    {
        public IdentifyingAreas()
        {
            InitializeComponent();

            matchItems = new List<Button> { matchItem1_btn, matchItem2_btn, matchItem3_btn, matchItem4_btn, matchItem5_btn, matchItem6_btn, matchItem7_btn, matchItem8_btn, matchItem9_btn, matchItem10_btn, matchItem11_btn, matchItem12_btn };

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            DeweyDictionary.PopulateDictionary();
            AssignValuesToGrid();
        }

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public static List<Button> matchItems;

        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // firstClicked points to the first Button the player clicks, but it will be null if player
        // hasn't clicked a TextBlock yet
        Button firstClicked;

        // secondClicked points to the second Button the player clicks
        Button secondClicked;

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            dispatcherTimer.Stop();

            // Hide both icons
            /*firstClicked.Foreground = firstClicked.Background;
            secondClicked.Foreground = secondClicked.Background;*/

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignValuesToGrid()
        {
            AssignMatchValues();

            const String charNumbers = "0123456789";

            for (int i = 0; i < 2; i++)
            {
                var callValue = (from m in Enumerable.Repeat(charNumbers, 3)
                                 select m[random.Next(m.Length)]).ToArray();

                int valueIndex = random.Next(0, 12);

                if (matchItems[valueIndex].Content != "")
                {
                    valueIndex = random.Next(0, 12);
                }

                matchItems[valueIndex].Content = new string(callValue);
            }
        }

        public void AssignMatchValues()
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (KeyValuePair<string, string> kvp in DeweyDictionary.deweyCategories)
                {
                    int valueIndex1 = random.Next(0, 12);
                    int valueIndex2 = random.Next(0, 12);

                    if (valueIndex1 == valueIndex2)
                    {
                        valueIndex2 = random.Next(0, 12);
                    }
                    else if (matchItems[valueIndex1].Content != "TextBlock")
                    {
                        valueIndex1 = random.Next(0, 12);
                    }
                    else if (matchItems[valueIndex2].Content != "TextBlock")
                    {
                        valueIndex2 = random.Next(0, 1);
                    }

                    matchItems[valueIndex1].Content = kvp.Key;
                    matchItems[valueIndex2].Content = kvp.Value;
                }
            }
        }

        public static String deweyInput;

        private void matchItem1_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem1_btn.Foreground == Brushes.Black && matchItem1_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem1_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem1_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem1_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem1_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }

            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem2_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem2_btn.Foreground == Brushes.Black && matchItem2_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem2_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem2_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem2_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem2_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem3_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem3_btn.Foreground == Brushes.Black && matchItem3_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem3_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem3_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem3_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem3_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }

            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem4_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem4_btn.Foreground == Brushes.Black && matchItem4_btn.Background == Brushes.White)
                {
                    return;
                }


                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem4_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem4_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem4_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem4_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem5_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem5_btn.Foreground == Brushes.Black && matchItem5_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem5_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem5_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem5_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem5_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem6_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem6_btn.Foreground == Brushes.Black && matchItem6_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem6_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem6_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem6_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem6_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");


            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem8_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem8_btn.Foreground == Brushes.Black && matchItem8_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem8_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem8_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem8_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem8_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");


            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem7_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem7_btn.Foreground == Brushes.Black && matchItem7_btn.Background == Brushes.White)
                {
                    return;
                }


                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem7_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem7_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem7_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem7_btn.Background = Brushes.White;
                    return;
                }

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //User can identify the dewey dewey call numbers and descriptions through prompt calls
            deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem9_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem9_btn.Foreground == Brushes.Black && matchItem9_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem9_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem9_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem9_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem9_btn.Background = Brushes.White;
                    return;
                }
                //User can identify the dewey dewey call numbers and descriptions through prompt calls
                deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem10_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem10_btn.Foreground == Brushes.Black && matchItem10_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem10_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem10_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem10_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem10_btn.Background = Brushes.White;
                    return;
                }
                //User can identify the dewey dewey call numbers and descriptions through prompt calls
                deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem11_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem11_btn.Foreground == Brushes.Black && matchItem11_btn.Background == Brushes.White)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem11_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem11_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem11_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem11_btn.Background = Brushes.White;
                    return;
                }
                //User can identify the dewey dewey call numbers and descriptions through prompt calls
                deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");


                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        private void matchItem12_btn_Click(object sender, RoutedEventArgs e)
        {
            // The timer is only on after two non-matching items have been shown to the player
            if (dispatcherTimer.IsEnabled == true)
                return;

            Button clicked = sender as Button;

            if (clicked != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (matchItem12_btn.Foreground == Brushes.Black && matchItem12_btn.Background == Brushes.White)
                {
                    return;
                }


                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = matchItem12_btn;
                    firstClicked.Foreground = Brushes.Black;
                    matchItem12_btn.Background = Brushes.White;
                    return;
                }

                // timer isn't running and firstClicked isn't null,
                // this is the second item the player clicks
                if (secondClicked == null)
                {
                    secondClicked = matchItem12_btn;
                    secondClicked.Foreground = Brushes.Black;
                    matchItem12_btn.Background = Brushes.White;
                    return;
                }

                //User can identify the dewey dewey call numbers and descriptions through prompt calls
                deweyInput = Interaction.InputBox("What is this dewey Partner?", "Identify the Dewey", "");

                // If player clicked two different items, start the timer
                // wait three quarters of a second, and then hide the items again
                dispatcherTimer.Start();
            }
            //Check Answers
            PointSystem.CheckIAAnswer();
        }

        //see rules
        private void rules_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rules are simple. \nMatch for more points! Mismatch is none to less points." +
                "\nLearning the system order of Dewey until the end. \nPlay well then!");
        }

        //go home
        private void home_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
