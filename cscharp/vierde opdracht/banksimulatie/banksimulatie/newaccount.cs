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
    public partial class NewAccountForm : Form
    {
        public string firstname;
        public string surname;
        public decimal balance;

        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void newaccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstname = firstNameTextBox.Text;
            surname = surNameTextBox.Text;
            balance = newAccountBalansNumericUpDown.Value;
            this.Close();
        }
    }
}
