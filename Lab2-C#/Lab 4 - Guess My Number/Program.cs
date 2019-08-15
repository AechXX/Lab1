using System;

namespace Lab_4___Guess_My_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            int nGuess;

            while (true)
            {
                hidden = rand.Next(100);
                Console.WriteLine(hidden);
                
                while (true)
                {                     
                    Console.WriteLine("Guess a number between 0 and 100: ");
                while (!int.TryParse(Console.ReadLine(), out nGuess))
                {
                    Console.WriteLine("Guess a number between 0 and 100: ");
                }

                if (nGuess == hidden)
                {
                    Console.WriteLine("Ding, ding, ding! We have a winner!");
                    Console.WriteLine("");
                        break;
                }

                else if (nGuess < hidden)
                {
                    Console.WriteLine("Too low. Try again.");
                    Console.WriteLine("");
                    }

                else if (nGuess > hidden)
                {
                    Console.WriteLine("Too high. Guess again.");
                    Console.WriteLine("");
                    }
                }
            }

        }
    }
}
