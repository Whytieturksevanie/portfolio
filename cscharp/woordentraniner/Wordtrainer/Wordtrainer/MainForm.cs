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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Translates translate = new Translates();
            translate.Dutch = DutchTextBox.Text;
            translate.German = GermanTextBox.Text;

            translateListBox.Items.Add(translate);
        }

        private void exerciseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exerciseform = new ExerciseForm();
            exerciseform.alltranslates = translateListBox.Items;
            exerciseform.ShowDialog();
        }
       

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void GermanLabel_Click(object sender, EventArgs e)
        {

        }

        private void DutchLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
