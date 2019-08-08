using System;

namespace HW2_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int nAttack, nArmor;
            int nInit1, nInit2, nInit3;

            //prompt for attack message
            Console.WriteLine("~This program calculates whether a an attack will land on its intended target.~");
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine("");

            //prompt for attack and AC
            Console.WriteLine("Enter the total attack: ");
            nAttack = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the armor class: ");
            nArmor = Convert.ToInt32(Console.ReadLine());

            //issue result and message
            if (nAttack < nArmor)
            {
                Console.WriteLine("Your oppenent has an AC of " + nArmor + " so your attack misses.");
            }

            else
            {
                Console.WriteLine("With an attack of " + nAttack + " you hit. How do you want to do this?...");
            }

            Console.ReadLine();

            //prompt for initiatives
            Console.WriteLine("Roll for initiative... ");
            nInit1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Roll for initiative... ");
            nInit2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Roll for initiative... ");
            nInit3 = Convert.ToInt32(Console.ReadLine());

            //issue result and message
            if (nInit1 > nInit2 && nInit1 > nInit3)
            {
                Console.WriteLine("The highest initiative is " + nInit1 + ".");
            }

            // highest initiative roll
            else if (nInit2 > nInit1 && nInit2 > nInit3)
            {
                Console.WriteLine("The highest initiative is " + nInit2 + ".");
            }

            else if (nInit3 > nInit1 && nInit3 > nInit2)
            {
                Console.WriteLine("The highest initiative is " + nInit3 + ".");
            }

            // lowest initiative roll
            if (nInit1 < nInit2 && nInit1 < nInit3)
            {
                Console.WriteLine("The lowest initiative is " + nInit1 + ".");
            }

            else if (nInit2 < nInit1 && nInit2 < nInit3)
            {
                Console.WriteLine("The lowest initiative is " + nInit2 + ".");
            }

            else if (nInit3 < nInit1 && nInit3 < nInit2)
            {
                Console.WriteLine("The lowest initiative is " + nInit3 + ".");
            }
            Console.ReadLine();
        }
    }
}
