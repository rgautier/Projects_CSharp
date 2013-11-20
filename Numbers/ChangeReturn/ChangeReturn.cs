using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeReturn
{
    public struct Coin
    {
        public float value;
        public string single_name;
        public string multiple_name;

        public Coin(float Worth, string One, string Multiple)
        {
            this.value = Worth;
            this.single_name = One;
            this.multiple_name = Multiple;
        }
    }

    class ChangeReturn
    {
        static void Main(string[] args)
        {
            float cost = get_input_float("What did the item cost? ", 0);
            float given = get_input_float("How much did they give you? ", 0);
            float remain = given-cost;

             Coin[] myChange = new Coin[5];
             myChange[4] = new Coin(0.01F, "penny", "pennies");
             myChange[3] = new Coin(0.05F, "nickel", "nickels");
             myChange[2] = new Coin(0.10F, "dime","dimes");
             myChange[1] = new Coin(0.25F, "quarter","quarters");
             myChange[0] = new Coin(1.00F, "dollar", "dollars");

             string yourChange = ""; 
            foreach (Coin type in myChange)         //foreach index seems to follow the 0-length but this is not necessarily true
             {
                 uint count = 0;
                 while (remain > type.value)
                 {
                     count += 1;
                     remain -= type.value;
                 }
                 if (count != 0)
                 {
                     if (yourChange == "")
                     {
                         yourChange += string.Format("{0} {1}", count, count == 1 ? type.single_name : type.multiple_name);
                     }
                     else
                     {
                         yourChange += string.Format(", {0} {1}", count, count == 1 ? type.single_name : type.multiple_name);
                     }
                 }
             }
            if (yourChange == "")
            {
                yourChange = "Exact change, thank you!";
            }
            else
            {
                yourChange = "Your change is " + yourChange;
                //TODO: Replace the last , in yourChange with ', and'
            }
            Console.WriteLine(yourChange);
            Console.ReadLine();
        }

        

        /*Implement min,max to allow validation of same
         * 
         */
        public static float get_input_float(string prompt,float minimum = float.MinValue, float maximum=float.MaxValue)
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
                    if (num_answer > maximum || num_answer < minimum)
                    {
                        Console.Write("I need a positive floating point value from {0} to {1}\n{2}", minimum, maximum, prompt);
                        answer = Console.ReadLine();
                    }
                    else
                        test = false;
                }
                catch (Exception)
                {
                    Console.Write("I need a positive floating point value from {0} to {1}\n{2}", minimum, maximum, prompt);
                    answer = Console.ReadLine();
                }
            } while (test);

            return num_answer;
        }
    }
}
