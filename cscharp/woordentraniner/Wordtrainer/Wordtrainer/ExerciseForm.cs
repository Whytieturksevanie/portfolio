using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordtrainer
{
    public partial class ExerciseForm : Form
    {
        public ListBox.ObjectCollection alltranslates;
        int count;

        public ExerciseForm()
        {
            InitializeComponent();
        }

        private void exerciseLabel_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)           
        {
            // controleren of invoer goed is.
            // zo ja naar de volgende woord.
            

            try
            {
                Translates listboxitem = (Translates)alltranslates[count];

                if (exerciseTextBox.Text == listboxitem.German)
                {
                    MessageBox.Show("Het antwoord is goed");
                    count++;

                    Translates listboxitemtwo = (Translates)alltranslates[count];
                    exerciseLabel.Text = listboxitemtwo.Dutch;
                }
                else
                {
                    MessageBox.Show("Het antwoord is niet goed");
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Je bent klaar met oefenen.");
            }
            
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            Translates listboxitem = (Translates) alltranslates[count];

            exerciseLabel.Text = listboxitem.Dutch;
        }
    }
}
