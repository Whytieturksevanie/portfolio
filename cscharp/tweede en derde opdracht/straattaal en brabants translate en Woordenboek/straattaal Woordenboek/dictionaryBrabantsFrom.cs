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
    public partial class dictionaryBrabantsFrom : Form
    {
        string[] answersbrabants;

        public dictionaryBrabantsFrom()
        {
            InitializeComponent();
        }

        public void giveanswers(string[] b)
        {
            this.answersbrabants = b;
        }

        private void dictionaryBrabantsFrom_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < answersbrabants.Length; i++)
            {
                translateBrabantsListBox.Items.Add(answersbrabants[i]);
            }
        }
    }
}
