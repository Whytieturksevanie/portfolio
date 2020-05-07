using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adayattheraces
{
    class Guy
    {
        public string Name { get; set; }
        public Bet MyBet { get; set; }
        public int Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }

        public Guy(string Name, Bet MyBet, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyLabel = MyLabel;
        }

        public Guy(RadioButton MyRadioButton)
        {
            this.MyRadioButton = MyRadioButton;
        }

        public void UpdateLabels()
        {
            this.MyRadioButton.Text = this.Name + " heeft " + this.Cash.ToString() + " dollars";
            this.MyLabel.Text = this.MyBet.GetDescription();
        }

        public void ClearBet()
        {
            this.MyBet.Amount = 0;
            this.MyRadioButton.Text = this.Name + " heeft " + this.Cash + " dollars";
            this.MyLabel.Text = this.Name + " heeft geen weddenschap geplaatst";
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount < this.Cash)
            {
                this.MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
                UpdateLabels();
                return true;
            }

            return false;
        }

        public void Collect(int Winner)
        {
            if (this.Cash > 0)
                this.Cash += this.MyBet.Payout(Winner);
        }
    }
}



