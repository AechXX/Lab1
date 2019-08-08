/*
Project:    HW1 - Variables and Arithmetic
Date:       08/08/2019
Author:     Halley Davenport
Notes:      This program reads a character's stats
            and determines their attack bonus.
*/

using System;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strCharacterName;
            int nAttackBonus, nStrOrDex;
            int nToHitTotal, nDifference, nProduct, nQuotient;

            //prompt for name and receive
            Console.WriteLine("~This program calculates a character's total attack bonus.~");
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine("");
            Console.WriteLine("Enter the character's name: ");
            strCharacterName = Console.ReadLine();

            //prompt for stats and attack bonus
            Console.WriteLine("Enter the character's base attack score: ");
            nAttackBonus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the character's Strength (melee) or Dexterity (ranged) bonus: ");
            nStrOrDex = Convert.ToInt32(Console.ReadLine());

            //calculation
            nToHitTotal = nAttackBonus + nStrOrDex;

            Console.WriteLine(strCharacterName + "'s total to hit bonus is " + nToHitTotal);
            Console.ReadLine();

            //difference, product, and quotient code because I'm lazy
            nDifference = nAttackBonus - nStrOrDex;

            Console.WriteLine("Difference: " + nDifference);
            Console.ReadLine();

            //difference, product, and quotient code because I'm lazy
            nProduct = nAttackBonus * nStrOrDex;

            Console.WriteLine("Product: " + nProduct);
            Console.ReadLine();

            //difference, product, and quotient code because I'm lazy
            nQuotient = nAttackBonus / nStrOrDex;

            Console.WriteLine("Quotient: " + nQuotient);
            Console.ReadLine();

        }
    }
}
