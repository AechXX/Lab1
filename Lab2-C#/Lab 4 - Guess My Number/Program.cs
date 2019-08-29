using System;

namespace Lab_4___Guess_My_Number
{
    class Program
    {

        static int playerNum, hiddenNum, totalGuesses;
        static bool playAgain, correct;
        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            hiddenNum = random.Next(min, max);
            return hiddenNum;
        }

        private static int GuessNumber()
        {
            int req;
            bool valid = false;
            do
            {
                Console.Write("Pick a number between 1 and 100: ");
                if (Int32.TryParse(Console.ReadLine(), out req))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input Detected. Please pick a number between 1 and 100.");
                }
            } while (!valid);
            playerNum = req;
            return req;
        }

        private static void CompareGuess()
        {
            if (playerNum == hiddenNum)
            {
                Console.WriteLine("Ding, ding, ding! You guessed the hidden number " + hiddenNum + " correctly! It took you " + totalGuesses + " attempts to guess correctly.");
                Console.WriteLine("");
                Console.Write("Would you like to try again? Enter 'Y' or 'YES' to continue playing: ");
                string ans = Console.ReadLine().Trim().ToUpper();
                correct = true;
                playAgain = (ans == "Y" || ans == "YES");
            }
            else if (playerNum < hiddenNum)
            {
                Console.WriteLine("Sorry! " + playerNum + " is too low.");
            }
            else if (playerNum > hiddenNum)
            {
                Console.WriteLine("Nope! " + playerNum + " is too high.");
            }
        }

        static void Main(string[] args)
        {
            int hiddenNum;
            int playerNum;


            do
            {

                Console.WriteLine("~~~ GUESS THE HIDDEN NUMBER ~~~");
                playAgain = false;
                correct = false;
                totalGuesses = 0;
                playerNum = RandomNumber(0, 100);

                while (!correct)
                {
                    playerNum = GuessNumber();
                    totalGuesses++;
                    CompareGuess();
                    Console.WriteLine("");
                }

            } while (playAgain);
        }
    }
}