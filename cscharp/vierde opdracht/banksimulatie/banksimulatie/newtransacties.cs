using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banksimulatie
{
    public partial class NewTransactiesForm : Form
    {
        public string whose;
        public string forwhom;
        public decimal balancestatus;

        public NewTransactiesForm()
        {
            InitializeComponent();
        }

        private void newTransactiesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            whose = ofNameTextBox.Text;
            forwhom = forWhomTextBox.Text;
            balancestatus = balansStatusNumericUpDown.Value;
            this.Close();
        }
    }
}
