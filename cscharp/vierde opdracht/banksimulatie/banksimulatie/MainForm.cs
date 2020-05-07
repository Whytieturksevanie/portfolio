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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<account> Accountlist = new List<account>()
        {
            new account("Esma", "Yilmaz", 1000),
            new account("Piet", "Tiep" , 1500),
            new account("Jantje", "ejtnaj", 2000),
            new account("Klaas", "saalk", 100),
            new account("Emine", "Enime", 1000),
            new account("Isa", "asi", 500),
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAccount();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            NewAccountForm popup = new NewAccountForm();
            popup.ShowDialog();
            customersListBox.Items.Add(string.Format("{0} {1} ( € {2} )", popup.firstname, popup.surname, popup.balance));
        }

        private void newTransatieButton_Click(object sender, EventArgs e)
        {
            NewTransactiesForm popup = new NewTransactiesForm();
            popup.ShowDialog();
            totalTransactiesListBox.Items.Add(string.Format("{0} geeft {1} ( € {2} )", popup.whose, popup.forwhom, popup.balancestatus));

            for (int i = 0; i < Accountlist.Count; i++)
            {
                if (Accountlist[i].Firstname == popup.whose)
                {
                    Accountlist[i].balance = Accountlist[i].balance - popup.balancestatus;
                }
            }

            for (int i = 0; i < Accountlist.Count; i++)
            {
                if (Accountlist[i].Firstname == popup.forwhom)
                {
                    Accountlist[i].balance = Accountlist[i].balance + popup.balancestatus;
                }
            }

            updateAccount();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {

            string[] words = totalTransactiesListBox.SelectedItems.;
            totalTransactiesListBox.Items.RemoveAt(totalTransactiesListBox.SelectedIndex);

        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateAccount()
        {
            customersListBox.Items.Clear();

            for (int i = 0; i < Accountlist.Count; i++)
            {
                customersListBox.Items.Add(string.Format("{0} {1} ( € {2} )", Accountlist[i].Firstname, Accountlist[i].Surname, Accountlist[i].balance));
            }
        }
    }
}
