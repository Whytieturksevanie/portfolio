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
    public partial class dictionaryForm : Form
    {
        string[] answers;

        public dictionaryForm()
        {
            InitializeComponent();
        }

        public void giveanswers(string[] a)
        {
            this.answers = a;
        }

        private void dictionary_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < answers.Length; i++)
            {
                translateListBox.Items.Add(answers[i]);
            }
        }

        private void translateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
