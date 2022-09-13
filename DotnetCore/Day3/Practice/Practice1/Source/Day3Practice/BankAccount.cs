using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Practice
{
     public class BankAccount
    {

        private static int accountNumberseed = 111122222;

        public string Number { get; }
        public string owner { get; set; }

        public decimal balance
        {
            get
            {

                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }



        public BankAccount(string name, decimal initialBalance)
        {

            this.owner = name;


            this.Number = accountNumberseed.ToString();
            accountNumberseed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");

            }

            if (balance - amount < 0)
            {
                throw new InvalidOperationException("NOT SUFFICIENT BALANCE");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public virtual void PerformMonthEndTransactions()
        {

        }
        }

}

