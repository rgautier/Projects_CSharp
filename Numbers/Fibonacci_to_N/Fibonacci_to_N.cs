using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_to_N
{
    class Fibonacci_to_N
    {
        static void Main(string[] args)
        {
            int digits;
            //Determine the length of the sequence to display based on Command Line Argument or input
            if (args.Length == 0)
            {
                Console.Write("How long of a Fibonacci sequence to display? ");

                //Never trust a user provided input
                try
                {
                    digits = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("I accept only an integer count - no decimals or strings");
                    digits = 0;
                }

            }
            else
            {
                //Never trust a user provided input
                try
                {
                    digits = int.Parse(args[0]);
                }
                catch (Exception)
                {
                    Console.WriteLine("I accept only an integer count - no decimals or strings");
                    digits = 0;
                } 
            }

            //If the sequence requested is >0, then start a loop to generate them, else print an error message
            if (digits<1)
            {
                Console.WriteLine("I can only generate a positive number (more than 0) length sequence");
            }
            else
            {
                //Store the Fibonacci sequence counters
                
                uint fibCurrent = 0;
                uint fibNext = 1;
                
                //Loop through and create the sequence and output it for us.
                for (int i = 0; i < digits; i++)
                {
                    Console.Write("{0} ",fibCurrent);
                    
                    fibNext = fibNext + fibCurrent;
                    fibCurrent = fibNext - fibCurrent;
                }
                Console.WriteLine();                    //end of line
            }

            //Wait for user input so that executing the code from Windows will keep window open.
            Console.ReadLine();
        }
    }
}
