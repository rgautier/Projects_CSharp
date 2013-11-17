using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_to_N
{
    class Pi_to_N
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int digits;
            string formatString = "{0:#.";

            //Figure out how many digits base on first argument, or ask..
            if (args.Length == 0)
            {
                Console.WriteLine("How many digits of pi to display (from 1 to max 15 for now):");
                try
                {
                    digits = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You're an ass");
                    digits = 0;
                }
                
            }
            else
            {
                digits = int.Parse(args[0]);
            }

            //TODO: Actually compute PI out to as many digits as asked.
            //Math.PI only provides pi to 15 digits
            if ((digits < 1) || (digits > 15))
            {
                //User did not follow directions
                Console.WriteLine("Minimum is 1 digit, max is 15");
            }
            else
            {
                //User followed directions
                //Set up the formatString for the output based on digit count
                //Starting with 1 digit displayed (counting from 1)
                for (int i = 1; i < digits; i++)
                {
                    formatString += "#";
                }
                formatString += "} is Pi to {1} digits.";

                //Output Math.PI based on the input
                Console.WriteLine(formatString, Math.PI, digits);
            }
            //Wait for user input so that executing the code from Windows will keep window open.
            Console.ReadLine();
        }
    }
}
