using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{
    public static class Useful
    {
        public static uint get_input_uint(string prompt)
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
                    test = false;
                }
                catch (Exception)
                {
                    Console.Write("I need a positive integer value\n{0}", prompt);
                    answer = Console.ReadLine();
                }
            } while (test);

            return num_answer;
        }

        public static float get_input_float(string prompt)
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
                    test = false;
                }
                catch (Exception)
                {
                    Console.Write("I need a positive floating point value\n{0}", prompt);
                    answer = Console.ReadLine();
                }
            } while (test);

            return num_answer;
        }
        public static string get_input_string(string prompt)
        {
            string answer = "";

            do {
                Console.Write(prompt);
                answer = Console.ReadLine();
            } while (answer == "");

            return answer;
        }
    }
}
