using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorph
{

    /// <summary>
    /// Parent Class
    /// </summary>
    abstract class Account
    {
        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        // Set out account balance, initial balance value using constructor
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;

        }

        // Child class can implement its own Withdrawal method with custom logic

        public abstract Transaction Withdrawal(decimal amount);



    }
}
