using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitwerkingToetsFundamentals
{
    public partial class CashRegisterForm : Form
    {
        decimal balance;

        decimal totalPrice;
        decimal change;

        string[] gamesToBeSold; // Games in de bestelling
        decimal[] pricesForGamesToBeSold; // De prijzen van die games

        public CashRegisterForm()
        {
            InitializeComponent();

            receiptListBox.HorizontalScrollbar = true;

            balance = 2000;

            UpdateBalanceLabel();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            totalPrice = 0;

            // Check if any games have been given to us by the inventory
            if (gamesToBeSold != null)
            {
                for (int i = 0; i < pricesForGamesToBeSold.Length; i++)
                {
                    // Opdracht 4: Tel hier de prijs van de game bij het totaalbedrag op
                    totalPrice = pricesForGamesToBeSold.Length;
                }

                // Round the price to two decimals
                totalPrice = RoundToTwoDecimals(totalPrice);

                // Set the price without taxes on the label
                priceNoTaxResultLabel.Text = totalPrice.ToString();

                // Add taxes (BTW) to the price
                decimal withTax = GetPriceWithTax(totalPrice);

                totalPriceResultLabel.Text = withTax.ToString();
                
                UpdateChangeLabel();
            }
            else
            {
                MessageBox.Show("Voeg spellen toe aan de bestelling!");
            }

            change = GetChange(paidAmountNumericUpDown.Value, GetPriceWithTax(totalPrice));

            UpdateChangeLabel();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            GameInventoryForm form = new GameInventoryForm();
            form.ShowDialog();

            gamesToBeSold = form.GamesToSell;
            pricesForGamesToBeSold = form.PricesOfGamesToSell;

            // Show the games in the receipt listbox, with their prices
            for (int i = 0; i < gamesToBeSold.Length; i++)
            {
                // Opdracht 3: Laat in de receiptListBox de game incl prijs zien op deze manier: 1 keer GAME_NAAM_HIER voor €PRIJS_HIER
                receiptListBox.Items.Add(string.Format("1 keer {0} voor {1}", gamesToBeSold[i],pricesForGamesToBeSold[i]));
                //decimal amount;
                //decimal.TryParse(paidAmountNumericUpDown.Text, out amount);
                //amount = amount / 100;
                //decimal money;
                //decimal.TryParse(paidAmountNumericUpDown.Text, out money);
                //money = money * 21;
                //decimal answer = amount + money;
                //totalPriceResultLabel.Text = answer.ToString();
                //receiptListBox.Text = answer.ToString();
            }

            inventoryButton.Enabled = false;
        }

        private void completeSaleButton_Click(object sender, EventArgs e)
        {
            decimal priceWithTax = GetPriceWithTax(totalPrice);

            // Add the total price to the history
            calculateTotalNumber.Items.Add(string.Format("€{0}", priceWithTax));

            // Add the money to our balance
            balance += priceWithTax;
            UpdateBalanceLabel();

            // Reset all controls and values
            receiptListBox.Items.Clear();

            totalPrice = 0;
            change = 0;

            paidAmountNumericUpDown.Value = 0;
            totalPriceResultLabel.Text = "0.00";
            priceNoTaxResultLabel.Text = "0.00";
            changeResultLabel.Text = "0.00";
            inventoryButton.Enabled = true;
        }

        private decimal RoundToTwoDecimals(decimal amount)
        {
            // The decimal.Round method with amount, 2 and MidpointRounding.AwayFromZero as parameters makes the number appear like:
            // 1.00 even if it's 1.
            return decimal.Round(amount, 2, MidpointRounding.AwayFromZero);
        }

        // 21% on top of the price (100%)
        private decimal GetPriceWithTax(decimal price)
        {
            // Opdracht 2: Schrijf hier een berekening die het bedrag teruggeeft + 21% BTW.
            decimal amount;
            decimal.TryParse(paidAmountNumericUpDown.Text, out amount);
            amount = amount / 100;
            decimal money;
            decimal.TryParse(paidAmountNumericUpDown.Text, out money);
            money = money * 21;
            decimal answer = amount + money;
            totalPriceResultLabel.Text = answer.ToString();
            // Opdracht 2a: Rond dat bedrag af op 2 decimalen met de RoundToTwoDecimals methode
            return decimal.Round(answer, 2, MidpointRounding.AwayFromZero);
        }

        private decimal GetChange(decimal paid, decimal cost)
        {
            // Opdracht 1: Schrijf hier de berekening die de juiste hoeveelheid wisselgeld teruggeeft.
            int number;
            int.TryParse(paidAmountNumericUpDown.Text, out number);
            number = number - number;
            changeResultLabel.Text = number.ToString();
            return number;
        }

        private void UpdateChangeLabel()
        {
            changeResultLabel.Text = change.ToString();
        }

        private void UpdateBalanceLabel()
        {
            // Opdracht 8: De hoeveelheid balans wordt niet geupdatet! Zorg dat dit wel gebeurt en maak gebruik van de RoundToTwoDecimals methode om het getal af te ronden.
            decimal balance;
            decimal.TryParse(paidAmountNumericUpDown.Text, out balance);
            decimal.Round(balance, 2, MidpointRounding.AwayFromZero);
        }

        private void completeBuyInButton_Click(object sender, EventArgs e)
        {
            // Opdracht 9: Wanneer bij het inkopen geen getal ingevoerd wordt crasht de applicatie! Vang dit probleem op.
            try
            {
                decimal buyInAmount = decimal.Parse(buyInAmountTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Voer een getal in");
            }

            // Opdracht 10: Als het inkopen van een spel zou resulteren in een negatieve balans moet dit voorkomen worden
            UpdateBalanceLabel();
            
            
        }

        private void paidAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            change = GetChange(paidAmountNumericUpDown.Value, GetPriceWithTax(totalPrice));
            UpdateChangeLabel();
        }

        private void receiptListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculateTotalNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CashRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
