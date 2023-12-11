using Perfolizer.Mathematics.Randomization;
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
    /// Interaction logic for CallTheNumber.xaml
    /// </summary>
    public partial class CallTheNumber : Window
    {
        
        public CallTheNumber()
        {
            //Points system not implemented on test subjects
            MessageBox.Show("Do note that this game is not implemented within the point system yet as it is still in the beta testing phase.");
            //Populate text description on random values
            GetRandomValue();
            SearchExample(randomValue);
            //form button group and populate with random values
            buttonchoices = new Button[4] { choice1_btn, choice2_btn, choice3_btn, choice4_btn };
            PopulateButtons();
            InitializeComponent();
        }

        //variables
        public static string randomValue;
        public static Button[] buttonchoices;

        private void PopulateButtons()
        {
            //choose random button
            GetRandomButton();
            foreach (Button b in buttonchoices)
            {
                //for correct answer
                if (b == buttonchoices[randomButton])
                {
                    b.Content = randomValue;
                }
                //for wrong answer
                else
                {
                    GetRandomValue();
                    b.Content = randomValue;
                }
            }
        }

        public static int randomButton;

        //get random button number
        private void GetRandomButton()
        {
            Random random = new Random();
            String charNumbers = "0123";

            randomButton = int.Parse(charNumbers[random.Next(0, charNumbers.Length)].ToString());
        }

        //Get Random text value
        private void GetRandomValue()
        {
            Random random = new Random();
            String charNumbers = "0123456789";

            randomValue = charNumbers[random.Next(0, charNumbers.Length)].ToString();
        }

        //find tree
        public static DeweyTreeNode<string> found;

        //find value in tree
        private void SearchExample(string valueItem)
        {
            DeweyTreeNode<string> treeRoot = DeweyTreeData.GetTreeSet();
            found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains(valueItem));

            callNumber_txt.Content = found.ToString().Substring(8);
        }

        //for clicked button
        Button clicked;

        //check answer method
        private void CheckAnswer()
        {
            if(found.Contains(clicked.Content) && found.Contains(callNumber_txt.Content))
            {
                MessageBox.Show("Success! Yay!");
            }
            else
            {
                MessageBox.Show("Oh No Try Again!");

            }
        }

        //if buttons are clicked
        private void choice1_btn_Click(object sender, RoutedEventArgs e)
        {
            clicked = choice1_btn;
            CheckAnswer();
        }
        
        private void choice2_btn_Click(object sender, RoutedEventArgs e)
        {
            clicked = choice2_btn;
            CheckAnswer();
        }

        private void choice3_btn_Click(object sender, RoutedEventArgs e)
        {
            clicked = choice3_btn;
            CheckAnswer();
        }

        private void choice4_btn_Click(object sender, RoutedEventArgs e)
        {
            clicked = choice4_btn;
            CheckAnswer();
        }
    }
}
