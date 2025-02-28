﻿
using AccountTransactionApp.Models;
using AccountTrasnactionApp.Models;

namespace AccountTrasnactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();

        }
        private static void CaseStudy1()
        {
            Account acc1 = new Account(1001, "Minu", 5000);
            acc1.Deposit(1000);
            acc1.Deposit(1000);
            acc1.Withdraw(2000);
            acc1.Deposit(5000);


            PrintDetails(acc1);

        }

        private static void PrintDetails(Account account)
        {
            Console.WriteLine($"name is {account.Name} balance is {account.Balance} and acconot is {account.AccountNumber}");

            //display txn summary

            List<Transaction> allTxns = account.Transactions;

            foreach (Transaction txn in allTxns)
            {
                Console.WriteLine($"type is :{txn.Type} amount  {txn.Amount} date is  {txn.Date}");
            }

        }

    }
}

