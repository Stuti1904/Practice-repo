using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Practice
{
    class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (balance < 0)
            {
                decimal interest = -balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "charge amount");
            }
        }
    }
}
