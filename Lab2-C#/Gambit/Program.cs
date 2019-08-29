using System;

namespace Gambit
{
    class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card("A", "Heart", 10);
            myCard.Value = 15;
            Console.WriteLine(myCard.Value);
        }
    }
}
