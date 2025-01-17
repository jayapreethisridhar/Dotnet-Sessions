
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLapprogram.Models
{
    internal class AccountObject
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private readonly string _email;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private const double HIGH_BALANCE = 50000;
        private const int LARGE_NAME = 5;

        public AccountObject(int accountNumber, string name, string email, double balance)
        {
            _accountNumber = accountNumber;
            _name = name;
            _email = email;
            _balance = balance;
        }

        public AccountObject(int accountNumber, string name)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = MIN_BALANCE;
        }

        public void Deposit(double amount)
        {

            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {

            if (_balance - amount > MIN_BALANCE)
                _balance = _balance - amount;

            //will throw exeception later,
            //throw new Exception("Insufficient balance");

        }
        public static void Transfer(AccountObject transferFrom, AccountObject transferTo, double amount)
        {
            transferFrom.Withdraw(amount);
            transferTo.Deposit(amount);
        }
        public bool CheckRichestAccount()
        {
            if (_balance > HIGH_BALANCE)
            {
                return true;
            }
            return false;
        }
        public bool CheckLargestNAme()
        {
            if (_name.Length > LARGE_NAME)
            {
                return true;
            }
            return false;
        }
        
        public double Balance
        {

            get { return _balance; }
        }

        public string Name
        {

            get { return _name; }
        }
        public string Email
        {
            get { return _email; }
        }
        public int AccountNumber
        {

            get { return _accountNumber; }
        }

    }
}
