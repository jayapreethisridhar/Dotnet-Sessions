using AccountTransferLapprogram.Model;
using System;


class Program
{
    static void Main()
    {
        var account1 = new Transferclass(70001, "Preethi", "preethi@rrd.com",100000);
        PrintDetails(account1);

        var account2 = new Transferclass(70002, "Shalini", "shalini@rrd.com", 50000);
        PrintDetails(account2);

        var account3 = new Transferclass(70003, "Venkat", "venkat@rrd.com", 60000);
        PrintDetails(account3);

        Transferclass transfer = account1.AmountTransfer(account2, 10000);
        PrintDetails(transfer);
        PrintDetails(account1);
    }
    private static void PrintDetails(Transferclass transfer)
    {
        Console.WriteLine($"Account Number: {transfer.AccountNumber}");
        Console.WriteLine($"Account Name: {transfer.AccountName}");
        Console.WriteLine($"Email: {transfer.Email}");
        Console.WriteLine($"Balance: {transfer.Balance}");
        Console.WriteLine();
    }
}