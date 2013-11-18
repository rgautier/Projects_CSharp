using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorization
{
    class PrimeFactorization
    {
        static void Main(string[] args)
        {
            //Changed to handle even larger numbers
            UInt64 to_factor;

            //Figure out how many digits base on first argument, or ask..
            if (args.Length == 0)
            {
                Console.WriteLine("Give me a positive integer to factor:");
                try
                {
                    to_factor = UInt64.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You need to provide a positive integer under 18,446,744,073,709,551,615");
                    to_factor = 0;
                }
            }
            else
            {
                try
                {
                    to_factor = UInt64.Parse(args[0]);
                    Console.WriteLine("Now factoring {0}", to_factor);
                }
                catch (Exception)
                {
                    Console.WriteLine("Usage:\n{0} <number>\n", Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location));
                    Console.WriteLine("number = a positive integer from 1 to 18,446,744,073,709,551,615");
                    to_factor = 0;
                }
                
            }

            //We now need to find the prime factors of to_factor, and print them out.
            //Recursive function is probably called for here.
            UInt64 z = is_prime(to_factor);

            if (to_factor == 0)
            {
                
            } 
            else if (z == 1)
            {
                Console.Write("{0} is a prime number.", to_factor);
            }
            else
            {
                //We've found the first prime, so we output it.
                //Then divide the number to factor by that prime to get the remaining quotient to factor
                Console.Write(z);
                to_factor = to_factor / z;
                z = is_prime(to_factor);

                //Until we get down to a prime number divided by itself (leaving 1)
                //We keep dividing the number by the next prime it is divisible by.
                //TODO: This loop could be refactored to not need the if statement at the end.
                while (z != 1)
                {
                    Console.Write(", {0}",z);
                    to_factor = to_factor / z;
                    z = is_prime(to_factor);
                }
                //If we're left with a remaining prime number, print it out.
                if (to_factor != 1)
                {
                    Console.Write(", {0}",to_factor);
                }
                Console.Write(" are the prime factors.");
            }
            Console.WriteLine();
            
            //Wait for user input so that executing the code from Windows will keep window open.
            Console.ReadLine();
        }

        //function that checks if a number is prime 
        //returns 1 or returns smallest prime it can be divided by
        public static UInt64 is_prime(UInt64 numToCheck)
        {
            //We count up toward the number to check divided by the current check number for divisors.
            //Holy shit, that's faster!
            for (UInt64 i = 2; i <= numToCheck/i; i++)
            {
                if (numToCheck %i == 0)
                {
                    return i;
                }
            }
            //If it wasn't divisible by any of the numbers under it, it's divisible by itself and 1
            return 1;
        }

    }
}
