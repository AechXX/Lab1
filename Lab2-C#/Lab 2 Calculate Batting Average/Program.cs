/*
Project:    Lab 2 Calculate Batting Average
Date:       08/08/2019
Author:     Halley Davenport
Notes:      This program reads in a baseball player's name
            number of hits, and number of at bats.
            The player's batting average is calculated and displayed.
*/

using System;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            double ndblHits, ndblAtBats;
            double dblBattingAverage;

            //prompt for name and receive
            Console.WriteLine("~This program calculates a baseball player's batting average.~");
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine("");//we will learn other ways to do this in console programs
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();

            //prompt for hits, walks, and at bats
            Console.WriteLine("Enter the player's # of hits: ");
            ndblHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats: ");
            ndblAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = ndblHits / ndblAtBats;

            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();

        }
    }
}
