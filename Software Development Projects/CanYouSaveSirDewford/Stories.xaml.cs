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
    /// Interaction logic for Stories.xaml
    /// </summary>
    public partial class Stories : Window
    {
        public Stories()
        {
            InitializeComponent();
        }

        private void sos_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Day 1, 21h00" +
                "\nJust your local news anchor reporting for research on a lovely rainy night to an antic neighbourhood." +
                "I was fulfilled. The night was calm. Or at least, that was what I thought" +
                "\n\nDay 2, 01h00" +
                "\nI finished up my research ready to leave for an early nights rest. Little did I know, the doors were trapped shut." +
                "My team will eventually look for me, I will be found. It's a pity I can't access any of the devices here. It seems to be " +
                "loadshedding." +
                "\n23h00" +
                "\nThe power has not recovered, its dark and there are echoes... How will I survive? What is taking my team so long" +
                "\n\nDay17, lost track of time" +
                "\nI'm starving. Feeding of knowledge cannot be my only option, especially if I can't have enough power to use my braincells" +
                ". I passed out for a week, can't believe I'm still living." +
                "\n\nDay18, probably midnight" +
                "\nI couldn't take the hunger anymore, I'm becoming a madman. I found some mice and made use of a computer circuit to heat" +
                "them. The closest thing I have to water is those bits of rain dripping from the roof. Or so is what I think is water." +
                "\n\nDay24" +
                "\nThose voices... I can't take anymore. Please find me!" +
                "\n\nDay36" +
                "\nI'm completely blocked from the world. This is what ease feels like. It's dark, this is for the best" +
                "\n\nDay39" +
                "\nRelease me! Let me go! What have I done to deserver this. S.O.S" +
                "\n\nDay49" +
                "\nI got hold of light source however can't establish what it is due to its weakness and damage. I liked" +
                "the darkness better. I must have reached a different universe. Oh uneased souls, please spare your " +
                "vengeance towards me. They won't let me leave until I learn to put every book back in place. Most of these" +
                "are not even from my doings. So why me? The spirits seem angered so I should figure out the dewey decimal system. Please save me..." +
                "\n\nDay91" +
                "\nThe spirits are delightful people. They have graced me with the end to my hunger. Over the years, many" +
                "souls have been trapped in this library due to curiousity. the war however started once humans refused to keep " +
                "things organised and in place. I have tried to reason with them and think its working. " +
                "\n\nDay92" +
                "\nThey have claim that by tomorrow I shall be on my way and sent on route." +
                "\n\nDay93" +
                "\n\nThe trail is a far. Why does this journey seem further than I remember. I trust the spirits, I shall " +
                "continue on path" +
                "\n\nDay94" +
                "\nThe spirits lied. It's scorching. The books are burning out, the labeling is jumbled and I'm tired. There" +
                "are way too much books to go through please help me." +
                "\n\nDay100" +
                "\nI am officially lost. Can you find me? Can you save Sir Dewford?"
                , "Please Save The Daily Dewford!");

        }

        private void spirits_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We are the spirits of the library. We are disgusted by the slothiness and disorganisation of these humans." +
                "To organise knowledge, you shall organise your brain.");
        }

        private void more_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void returnHome_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
