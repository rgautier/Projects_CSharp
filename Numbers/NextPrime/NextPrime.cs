using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrime
{
    class NextPrime
    {
        static void Main(string[] args)
        {
            UInt64 thisprime = 1;       //0 is not prime - start with 1
            string Entry="";
            
            while (Entry != "N")
            {
                while (is_prime(thisprime) != 1)
                {
                    thisprime += 1;
                }
                
                Console.Write("The next prime number is {0} - Enter \"N\" to exit: ", thisprime);    
                Entry = Console.ReadLine();
                thisprime += 1;
            }
        }

        //function that checks if a number is prime 
        //returns 1 or returns smallest prime it can be divided by
        public static UInt64 is_prime(UInt64 numToCheck)
        {
            //We count up toward the number to check divided by the current check number for divisors.
            //Holy shit, that's faster!
            for (UInt64 i = 2; i <= numToCheck / i; i++)
            {
                if (numToCheck % i == 0)
                {
                    return i;
                }
            }
            //If it wasn't divisible by any of the numbers under it, it's divisible by itself and 1
            return 1;
        }
    }
}
