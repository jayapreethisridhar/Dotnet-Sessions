using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransferLapprogram.Model
{
    internal class Transferclass
    {
        private int accountnumber;
        private string accountname;
        private string email;
        private double balance;
        private const int MIN_BALANCE = 5000;

        public Transferclass(int accountnumber, string accountname, string email, int balance)
        {
            this.accountnumber = accountnumber;
            this.accountname = accountname;
            this.email = email;
            this.balance = balance;
        }
        public Transferclass AmountTransfer(Transferclass account, double amount)
        {
            if(this.balance - amount > MIN_BALANCE)
            {
                balance -= amount;
                account.balance += amount;
                return account;
            }
            return this;
        }
        public string AccountName
        {
            get { return this.accountname; }
        }
        public string Email
        {
            get { return this.email; }
        }
        public int AccountNumber
        {
            get { return this.accountnumber; }
        }
        public double Balance
        {
            get { return this.balance; }
        }
    }
}
