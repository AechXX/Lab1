using System;
namespace HW2___Fibonacci
{
    class Program
    {

        static long fib(long n)
        {

            // Declare an array to store Fibonacci numbers. 
            // 1 extra to handle case, n = 0 
            long[] f = new long[n + 2];
            long i;

            // 0th and 1st number of the series are 0 and 1
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                //Add the previous 2 numbers in the series and store it
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        // Driver Code 
        static void Main(string[] args)
        {
            //Writes entire Fibonnaci sequence to the nth number
            long n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter number to see Fibonnaci sequence: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //print 0 and 1    
            for (i = 2; i < number; ++i) //loop starts at 2 since 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write(n3 + " \r\n");
            }

        }
    }
}