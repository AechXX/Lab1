using System;

namespace HW_2___Greatest_Common_Divisor
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n1, n2, n3;
                int nMin = 0;
                int nMax = 0;


                Console.WriteLine("Enter an integer: ");
                while (Int32.TryParse(Console.ReadLine(), out n1) == false)
                {
                    Console.WriteLine("Not Valid. Must be a Positive rational number");
                }

                Console.WriteLine("Enter an integer: ");
                while (Int32.TryParse(Console.ReadLine(), out n2) == false)
                {
                    Console.WriteLine("Not Valid. Must be a Positive rational number");
                }

                if (n1 < n2)
                {
                   nMin = n1;
                   nMax = n2;
                }
                else
                {
                    nMax = n1;
                    nMin = n2;
                }

                Console.WriteLine("The greatest common divisor between " + n1 + " and " + n2);
                do
                {

                n3 = nMax % nMin;

                if (n3 == 0)
                 {
                    Console.WriteLine("is " + nMin + ".");
                    break;
                 }
                 else
                 {
                    nMax = nMin;
                    nMin = n3;
                 }

                }
                while (n3 >= 0);

            Console.ReadLine();

        }
    }
}