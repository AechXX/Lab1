using System;
using System.Collections.Generic;
using System.Text;

namespace Gambit
{
    class Card
    {
        string rank;
        string suit;
        int val;

        public int Value
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
        }

        public Card(string rank, string suit, int val)
        {
            this.rank = rank;
            this.suit = suit;
            this.val = val;
        }
    }
}
