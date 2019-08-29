using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorph
{
    class SavingsAccount : Account
    {

        private const int MONTHLY_WITHDRAWAL_LIMIT = 5;

        public decimal InterestRate { get; set; }
        public int WithdrawalThisMonth { get; set; }

        // Set the initial balance.
        public SavingsAccount(decimal initialBalance, int withdrawalsThisMonth): base(initialBalance)
        {
            WithdrawalThisMonth = withdrawalsThisMonth;

        }

        public override Transaction Withdrawal(decimal amount)
        {
            // Implement the withdrawal transaction logic here.
            Transaction thisTransaction = new Transaction();
            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.TimeStamp = DateTime.Now;
            thisTransaction.isSuccessful = false;

            // Perform withdrawal
            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction failed: Insufficient funds. Current balance: $" + Balance;
                Console.WriteLine("Transaction failed: Insufficient balance.");
            }

            else if(WithdrawalThisMonth > MONTHLY_WITHDRAWAL_LIMIT)
            {
                thisTransaction.Detail = "Transaction failed: Monthly withdrawal transaction limit reached.";
                Console.WriteLine("Transaction failed: Monthly withdrawal transaction limit reached.");
            }

            else
            {
                Balance -= amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = "Debit Transaction for account number #" + AccountNumber + "with the amount of $" + amount;
                Console.WriteLine(thisTransaction.Detail);
            }

            return thisTransaction;
        }

        public void ProcessProfit()
        {
            Balance += Balance * InterestRate;
        }
    }
}
