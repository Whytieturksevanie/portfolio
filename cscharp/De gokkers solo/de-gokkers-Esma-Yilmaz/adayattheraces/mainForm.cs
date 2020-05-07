using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adayattheraces
{
    public partial class mainForm : Form
    {
        Greyhound DogOne;
        Greyhound DogTwo;
        Greyhound DogThree;
        Greyhound DogFour;

        Guy GuyOne;
        Guy GuyTwo;
        Guy GuyThree;

        public mainForm()
        {
            InitializeComponent();

            Random myRandom = new Random();

            DogOne = new Greyhound(dogOne);
            DogOne.Randomizer = myRandom;
            DogOne.RacetrackLength = racePictureBox.Width - dogOne.Width;
            DogOne.StartingPostion = dogOne.Left;

            DogTwo = new Greyhound(dogTwo);
            DogTwo.Randomizer = myRandom;
            DogTwo.RacetrackLength = racePictureBox.Width - dogTwo.Width;
            DogTwo.StartingPostion = dogTwo.Left;

            DogThree = new Greyhound(dogThree);
            DogThree.Randomizer = myRandom;
            DogThree.RacetrackLength = racePictureBox.Width - dogThree.Width;
            DogThree.StartingPostion = dogThree.Left;

            DogFour = new Greyhound(dogFour);
            DogFour.Randomizer = myRandom;
            DogFour.RacetrackLength = racePictureBox.Width - dogFour.Width;
            DogFour.StartingPostion = dogFour.Left;

            GuyOne = new Guy(guyOne);
            GuyOne.Name = "Joe";
            GuyOne.Cash = 50;
            GuyOne.MyBet = new Bet();
            GuyOne.MyLabel = JoeLabel;
            GuyOne.MyRadioButton = guyOne;

            GuyTwo = new Guy(guyTwo);
            GuyTwo.Name = "Bob";
            GuyTwo.Cash = 75;
            GuyTwo.MyBet = new Bet();
            GuyTwo.MyLabel = BobLabel;
            GuyTwo.MyRadioButton = guyTwo;

            GuyThree = new Guy(guyThree);
            GuyThree.Name = "Al";
            GuyThree.Cash = 45;
            GuyThree.MyBet = new Bet();
            GuyThree.MyLabel = AlLabel;
            GuyThree.MyRadioButton = guyThree;
        }

        private bool _enableRaceButtton = false;
        private int _flag = 0;

        private void raceButton_Click(object sender, EventArgs e)
        {
            if (betsNumericUpDown.Value >= 5 && betsNumericUpDown.Value <= 15)
            {
                speedTimer.Start();
            }
            else if (betsNumericUpDown.Value < 5)
            {
                MessageBox.Show("Je moet 5 dollar of meer bieden.");
            }
            else if (betsNumericUpDown.Value > 15)
            {
                MessageBox.Show("Je mag niet meer 15 dollar bieden");
            }
        }

        private void speedTimer_Tick(object sender, EventArgs e)
        {
            bool hasAnyDogWon = false;
            int winningDogNo;

            if (DogOne.Run())
            {
                speedTimer.Stop();
                MessageBox.Show("Hond een heeft gewonnen");
                hasAnyDogWon = true;
                winningDogNo = 0;

                GuyOne.Collect(winningDogNo + 1);
                GuyOne.ClearBet();

                GuyTwo.Collect(winningDogNo + 1);
                GuyTwo.ClearBet();

                GuyThree.Collect(winningDogNo + 1);
                GuyThree.ClearBet();
            }

            if (DogTwo.Run())
            {
                speedTimer.Stop();
                MessageBox.Show("Hond twee heeft gewonnen");
                hasAnyDogWon = true;
                winningDogNo = 1;

                GuyOne.Collect(winningDogNo + 1);
                GuyOne.ClearBet();

                GuyTwo.Collect(winningDogNo + 1);
                GuyTwo.ClearBet();

                GuyThree.Collect(winningDogNo + 1);
                GuyThree.ClearBet();
            }

            if (DogThree.Run())
            {
                speedTimer.Stop();
                MessageBox.Show("Hond drie heeft gewonnen");
                hasAnyDogWon = true;
                winningDogNo = 2;

                GuyOne.Collect(winningDogNo + 1);
                GuyOne.ClearBet();

                GuyTwo.Collect(winningDogNo + 1);
                GuyTwo.ClearBet();

                GuyThree.Collect(winningDogNo + 1);
                GuyThree.ClearBet();
            }

            if (DogFour.Run())
            {
                speedTimer.Stop();
                MessageBox.Show("Hond vier heeft gewonnen");
                hasAnyDogWon = true;
                winningDogNo = 3;

                GuyOne.Collect(winningDogNo + 1);
                GuyOne.ClearBet();

                GuyTwo.Collect(winningDogNo + 1);
                GuyTwo.ClearBet();

                GuyThree.Collect(winningDogNo + 1);
                GuyThree.ClearBet();
            }

            if (hasAnyDogWon == true)
            {
                DogOne.TakeStartingPosition();
                DogTwo.TakeStartingPosition();
                DogThree.TakeStartingPosition();
                DogFour.TakeStartingPosition();
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            try
            {
                BetsButtonWorking();

                if (this._enableRaceButtton)
                    raceButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (GuyOne.Cash < betsNumericUpDown.Value)
            {
                MessageBox.Show("Je heb niet genoeg geld");
            }
        }

        public void BetsButtonWorking()
        {
            int bucksNumber = 0;
            int dogNumber = 0;

            if (!guyOne.Checked && !guyTwo.Checked && !guyThree.Checked)
            {
                MessageBox.Show("Je moet ten minste één persoon kiezen om een weddenschap te plaatsen.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bucksNumber = Convert.ToInt32(betsNumericUpDown.Value);
            dogNumber = Convert.ToInt32(dogNumericUpDown.Value);

            _enableRaceButtton = true;

            if (this._flag == 1)
            {
                this.GuyOne.PlaceBet(bucksNumber, dogNumber);
            }
            else if (this._flag == 2)
            {
                this.GuyTwo.PlaceBet(bucksNumber, dogNumber);
            }
            else if (this._flag == 3)
            {
                this.GuyThree.PlaceBet(bucksNumber, dogNumber);
            }
        }

        private void oneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (guyOne.Checked)
            {
                this._flag = 1;
                guyLabel.Text = this.GuyOne.Name;
            }
        }

        private void twoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (guyTwo.Checked)
            {
                this._flag = 2;
                guyLabel.Text = this.GuyTwo.Name;
            }
        }

        private void threeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (guyThree.Checked)
            {
                this._flag = 3;
                guyLabel.Text = this.GuyThree.Name;
            }
        }

        private void betsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dogNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}