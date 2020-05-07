using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace straattaal_Woordenboek
{
    public partial class MainFrom : Form
    {
        string[] answers = new string[5]
        {
            "Ruzie = fittie",
            "Opscheppen = flexen",
            "Vriend = mattie",
            "Hand = Anoe",
            "geld = doekoe"
        };

        string[] answersbrabants = new string[3]
        {
            "aardappel = êrêppel",
            "aardbeien = errebeesjes",
            "tot ziens = houdoe",
        };

        public MainFrom()
        {
            InitializeComponent();
        }

        private void translateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string[] word = new string[4]
            {
                "Ruzie",
                "Opscheppen",
                "Vriend",
                "geld"
            };

            string[] translate = new string[4]
            {
                "Fittie",
                "Flexen",
                "Mattie",
                "doekoe"
            };

            int location = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == translateTextBox.Text)
                {
                    location = i;
                }
            }

            try
            {
                if (location >= 0)
                {
                    translateLabel.Text = translate[location].ToString();
                }
                else
                {
                    MessageBox.Show("Typt een woord uit het woordenboek");
                }

            }
            catch
            {
                MessageBox.Show("Typt een woord uit het woordenboek");
            }
        }

        private void translateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dictionaryButton_Click(object sender, EventArgs e)
        {
            dictionaryForm popup = new dictionaryForm();
            popup.giveanswers(answers);
            popup.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalWordLabel.Text = answers.Length.ToString();
            totalWordBrabantsLabel.Text = answersbrabants.Length.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] wordbrabants = new string[3]
            {
                "Aardappel",
                "Aardbeien",
                "Tot ziens"
            };

            string[] translatebrabants = new string[3]
            {
                "Êrêppel",
                "Errebeesjes",
                "Houdoe"
            };

            int result = -1;

            for (int i = 0; i < wordbrabants.Length; i++)
            {
                if (wordbrabants[i] == translateBrabantsTextBox.Text)
                {
                    result = i;
                }
            }

            try
            {
                if (result >= 0)
                {
                    translateBrabantsLabel.Text = translatebrabants[result].ToString();
                }
                else
                {
                    MessageBox.Show("Typt een woord uit het woordenboek");
                }

            }
            catch
            {
                MessageBox.Show("Typt een woord uit het woordenboek");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dictionaryBrabantsFrom popup = new dictionaryBrabantsFrom();
            popup.giveanswers(answersbrabants);
            popup.ShowDialog();
        }
    }
}
