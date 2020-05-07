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
    public partial class GameInventoryForm : Form
    {
        public string[] GamesToSell;
        public decimal[] PricesOfGamesToSell;

        string[] inventoryGames;
        decimal[] inventoryPrices;

        public GameInventoryForm()
        {
            InitializeComponent();

            gamesListView.View = View.List;

            LoadInventory();
        }
        
        public void LoadInventory()
        {
            // Plaats alle spellen in de array
            inventoryGames = new string[]
            {
                "Mario Kart - Double Dash (GameCube)",
                "Rollercoaster Tycoon 2 (PC)",
                "Crash Bandicoot (Playstation)",
                "Grand Theft Auto: Vice City Stories (Playstation Portable)",
                "Tekken 4 (Playstation 2)",
                "Doom 2016 (Xbox One)",
                "Pirates! (NES)",
            };

            // Plaats de bijbehorende prijzen in deze andere array
            inventoryPrices = new decimal[]
            {
                19.75M, // Mario Kart
                5.45M, // Rollercoaster Tycoon 2
                1.25M,
                12.45M,
                4.55M,
                14.85M,
                1.00M,
            };

            // There need to be the same amount of games as prices or an exception should be thrown.
            ValidateGamesAndPrices(inventoryGames, inventoryPrices);

            // Laat in eerste instantie alle games zien
            int[] allIndexes = new int[inventoryGames.Length];

            for (int i = 0; i < inventoryGames.Length; i++)
            {
                allIndexes[i] = i;
            }

            ShowGamesInListBox(allIndexes);
        }

        private void ValidateGamesAndPrices(string[] games, decimal[] prices)
        {
            if(games.Length != prices.Length)
            {
                throw new Exception("The amount of games do not match the amount of prices!");
            }
        }

        private void ShowGamesInListBox(int[] indexesToShow)
        {
            gamesListView.Items.Clear();

            for (int i = 0; i < indexesToShow.Length; i++)
            {
                int indexToShow = indexesToShow[i];
                
                ListViewItem newItem = new ListViewItem();
                newItem.Text = string.Format("{0} (€{1})", inventoryGames[indexToShow], inventoryPrices[indexToShow]);
                newItem.Tag = indexToShow;

                gamesListView.Items.Add(newItem);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            int numberOfGamesFound = 0;

            // Tel het aantal resultaten
            for (int i = 0; i < inventoryGames.Length; i++)
            {
                string game = inventoryGames[i];

                if (game.ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    numberOfGamesFound++;
                }
            }

            // Stop de indexen van deze resultaten in de array
            int[] indexesToShow = new int[numberOfGamesFound];
            int indexCounter = 0;

            for (int i = 0; i < inventoryGames.Length; i++)
            {
                string game = inventoryGames[i];

                if (game.Contains(searchTextBox.Text))
                {
                    indexesToShow[indexCounter++] = i;
                }
            }

            ShowGamesInListBox(indexesToShow);
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            int totalSelected = gamesListView.SelectedItems.Count;

            GamesToSell = new string[totalSelected];
            PricesOfGamesToSell = new decimal[totalSelected];

            for (int i = 0; i < totalSelected; i++)
            {
                ListViewItem item = gamesListView.SelectedItems[i];
                int index = (int) item.Tag;

                GamesToSell[i] = inventoryGames[index];
                PricesOfGamesToSell[i] = inventoryPrices[index];
            }

            this.Close();
        }

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
