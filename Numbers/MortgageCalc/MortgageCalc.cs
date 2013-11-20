using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalc
{
    class MortgageCalc
    {
        //**Mortgage Calculator** – 
        //Calculate the monthly payments of a fixed term mortgage over given Nth terms at a given interest rate. 
        //Also figure out how long it will take the user to pay back the loan.

        static void Main(string[] args)
        {
            float to_borrow = get_input_float("How much to borrow? ",0);
            uint months = get_input_uint("How many months to pay it back [360 max]? ",1,360);
            float rate = get_input_float("What interest rate? ",0);
        }

        public static uint get_input_uint(string prompt,uint minimum = uint.MinValue,uint maximum = uint.MaxValue)
        {
            string answer;
            uint num_answer = 0;

            Console.Write(prompt);
            answer = Console.ReadLine();
            bool test = true;

            do
            {
                try
                {
                    num_answer = uint.Parse(answer);
                    if (num_answer <= maximum && num_answer >= minimum)
                    {
                        test = false;
                    }
                    else
                    {
                        Console.Write("I need a positive integer value ({0} to {1}\n{2}", minimum, maximum, prompt);
                        answer = Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.Write("I need a positive integer value ({0} to {1})\n{2}", minimum, maximum, prompt);
                    answer = Console.ReadLine();
                }
            } while (test);

            return num_answer;
        }

        public static float get_input_float(string prompt,float minimum=float.MinValue,float maximum=float.MaxValue)
        {
            string answer;
            float num_answer = 0;

            Console.Write(prompt);
            answer = Console.ReadLine();
            bool test = true;

            do
            {
                try
                {
                    num_answer = float.Parse(answer);
                    if (num_answer <= maximum && num_answer >= minimum)
                    {
                        test = false;
                    }
                    else
                    {
                        Console.Write("I need a positive floating point value ({0} to {1})\n{2}", minimum, maximum, prompt);
                        answer = Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.Write("I need a positive floating point value ({0} to {1})\n{2}",minimum, maximum, prompt);
                    answer = Console.ReadLine();
                }
            } while (test);

            return num_answer;
        }
    }
}
