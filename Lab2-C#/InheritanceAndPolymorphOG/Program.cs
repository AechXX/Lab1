using System;

namespace InheritanceAndPolymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myChkAccount = new CheckingAccount(1000);
            Console.WriteLine("Initiate withdrawal of $250.");
            myChkAccount.Withdrawal(250);
            Console.WriteLine("Balance is: $" + myChkAccount.Balance);

            Console.ReadLine();
            Console.WriteLine("Initiate withdrawal of $850.");
            Console.WriteLine("Balance is: $" + myChkAccount.Balance);
            myChkAccount.Withdrawal(850);

            Console.ReadLine();


        }
    }
}
