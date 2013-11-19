using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileCost
{
    class TileCost
    {
        static void Main(string[] args)
        {
            uint height, width, tile_height, tile_width;
            float per_tile;

            width = get_input_uint("Enter the Width of the floor: ");
            height = get_input_uint("Enter the Height of the floor: ");
            tile_width = get_input_uint("Enter the Width of the tiles: ");
            tile_height = get_input_uint("Enter the Height of the tiles: ");
            per_tile = get_input_float("Enter the cost per tile: ");

            Console.WriteLine("The cost to tile this will be approximately: {0:C}",per_tile*((width*height)/(tile_width*tile_height)));
            Console.ReadLine();
        }

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
    }
}
