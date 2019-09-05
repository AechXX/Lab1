using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10___Five_Card_Draw
{
    class Card
    {
        string rank;
        string suit;
        int val;
        
        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }

        public int Val { get => val; set => val = value; }

        /// <summary>
        /// Displays the card rank and suit.
        /// </summary>
        /// <returns>Race and suit as a concatenated string.</returns>
        public override string ToString()
        {
            return string.Format("{0,2} {1}", rank, suit);
        }

        public Card(string rank, string suit, int val)
        {
            this.rank = rank;
            this.suit = suit;
            this.val = val;
        }

    }
}
