using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorph
{
    class CheckingAccount : Account
    {
        public CheckingAccount(decimal initialBalance) : base(initialBalance)
        {

        }

        public override Transaction Withdrawal(decimal amount)
        {
            // Create Transaction Object
            Transaction thisTransaction = new Transaction();
            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.isSuccessful = false;
            thisTransaction.TimeStamp = DateTime.Now;

            // Try to process the transaction
            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction Failed: Insufficient funds.";
                Console.WriteLine("Transaction Failed: Insufficient funds.");
            }
            else
            {
                Balance -= amount; // Balance = Balance - amount
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = String.Format("Account#: {0} was debited {1}", thisTransaction.AccountNumber, thisTransaction.Amount);
                Console.WriteLine("Successfully withdrew from " + thisTransaction.AccountNumber + " debited amount of " + thisTransaction.Amount);
            }

            return thisTransaction;

        }
    }
}
