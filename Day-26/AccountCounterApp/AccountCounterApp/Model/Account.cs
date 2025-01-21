using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp.Model
{
    internal class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private static int _instanceCounter;

        static Account()
        {
            Console.WriteLine("Static Constructor");
            Console.WriteLine("Called only once in entired project");
            _instanceCounter = 1000;
        }
        public Account(int accountNumber, string name, double balance)
        {
            Console.WriteLine("Inside Constructor");
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
            _instanceCounter++;
        }
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
        public void Withdraw(double amount)
        {
            if(_balance - amount > MIN_BALANCE)
                _balance = _balance - amount;
        }
        public int InstanceCounter
        { 
            get { return _instanceCounter; } 
        }
        public double Balance
        {
            get { return _balance; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int AccountNumber
        {
            get { return _accountNumber; }
        }
        public static int HeadCount
        {
            get { return _instanceCounter;  }
        }
    }
}
