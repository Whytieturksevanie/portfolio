using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adayattheraces
{
    class Bet
    {
        public int Amount { get; set; }
        public int Dog { get; set; }
        public Guy Bettor { get; set; }

        public string GetDescription()
        {
            if (this.Amount == 0)
            {
                return this.Bettor.Name + " heeft geen weddenschap geplaatst";
            }
            else
            {
                return this.Bettor.Name + " heeft " + this.Bettor.MyBet.Amount.ToString() + " dollars op hond " + this.Bettor.MyBet.Dog.ToString() + " geplaatst";
            }  
        }

        public int Payout(int Winner)
        {
            if (this.Bettor.MyBet.Dog == Winner)
            {
                int amount = Amount;
                MessageBox.Show(Bettor.Name + " neemt het geld!!");
                return Bettor.Cash += amount * 4;
            }
            else
            {
                return -this.Amount;
            }
        }
    }
}
