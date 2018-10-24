using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        int coinNumber = 10;
        int imageOne;
        int imageTwo;
        int imageThree;




        public Form1()
        {
            InitializeComponent();
        }
         
        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            imageOne = randGen.Next(1, 4);
            imageTwo = randGen.Next(1, 4);
            imageThree = randGen.Next(1, 4);

            switch (imageOne)
            {
                case 1:
                    reel1.Image = OneArmedBandit.Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel1.Image = OneArmedBandit.Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel1.Image = OneArmedBandit.Properties.Resources.diamond_100x125;
                    break;
            }
            switch (imageTwo)
            {
                case 1:
                    reel2.Image = OneArmedBandit.Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel2.Image = OneArmedBandit.Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel2.Image = OneArmedBandit.Properties.Resources.diamond_100x125;
                    break;
            }

            switch (imageThree)
            {
                case 1:
                    reel3.Image = OneArmedBandit.Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel3.Image = OneArmedBandit.Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel3.Image = OneArmedBandit.Properties.Resources.diamond_100x125;
                    break;
            }

            if ((imageOne == 1) && (imageTwo == 1) && (imageThree == 1))
            {
                outputLabel.Text = "Winner";
                coinNumber += 3;
            }
            else if ((imageOne == 2) && (imageTwo == 2) && (imageThree == 2))
            {
                outputLabel.Text = "Winner";
                coinNumber += 3;
            }
            else if ((imageOne == 3) && (imageTwo == 3) && (imageThree == 3))
            {
                outputLabel.Text = "Winner";
                coinNumber += 3;
            }
            else
            {
                outputLabel.Text = "Loser";
                coinNumber = coinNumber - 1;
            }

            if (coinNumber == 0)
            {
                outputLabel.Text = "You Lost";
                spinButton.Enabled = false;
            }

            scoreDisplay.Text = coinNumber + "";
            // 

                 


            // if score has reached 0 display "lose" message and set button enabled property to false


            // display updated score

        }

        private void reel1_Click(object sender, EventArgs e)
        {

        }
    }
}
