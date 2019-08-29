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

        public override string ToString()
        {
            return Rank + " " + Suit;
        }

        public Card(string rank, string suit, int val)
        {
            this.rank = rank;
            this.suit = suit;
            this.val = val;
        }
    }
}
