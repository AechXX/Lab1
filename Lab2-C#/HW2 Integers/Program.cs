using System;

namespace HW2_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int nHilt, nBlade;
            int nTotalLength;

            //prompt for sword stats
            Console.WriteLine("~This program calculates whether a sword should be wielded in 1 or 2 hands.~");
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine("");

            //prompt for hits, walks, and at bats
            Console.WriteLine("Enter the sword's hilt length in inches: ");
            nHilt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's blade length in inches: ");
            nBlade = Convert.ToInt32(Console.ReadLine());

            //calculation
            nTotalLength = nHilt + nBlade;

            //issue result and message
            Console.WriteLine("This weapon is " + nTotalLength + " inches long.");

            if (nTotalLength < 28)
            {
                Console.WriteLine("At less than 28 inches, this weapon can be wielded in one hand.");
            }

            else if (nTotalLength <= 50)
            {
                Console.WriteLine("Measured between 29 and 50 inches, this weapon can be wielded in either one or both hands.");
            }

            else
            {
                Console.WriteLine("At greater than 50 inches, this weapon should be wielded in both hands.");
            }

            Console.ReadLine();
        }
    }
}
