using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banksimulatie
{
    class account
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public int accountnumber { get; set; }
        public int cardnumber { get; set; }
        public decimal balance { get; set; }

        public account(string firstname, string surname, decimal balance)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.balance = balance;
        }
    }
}
