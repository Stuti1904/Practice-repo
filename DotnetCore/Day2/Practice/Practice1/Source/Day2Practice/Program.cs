using System;

namespace Day2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("stuti", 1000);
            Console.WriteLine($"Account{account.Number} was create for{account.owner} with balance {account.balance}");
            account.MakeWithdrawal(500, DateTime.Now, "rent payment");
            Console.WriteLine(account.balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.balance);

        }
    }
}
