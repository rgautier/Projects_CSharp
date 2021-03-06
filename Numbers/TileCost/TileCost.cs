﻿using System;
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
            uint height;
            uint width;
            uint tile_height;
            uint tile_width;
            float per_tile;

            width = get_input_uint("Enter the Width of the floor: ");
            height = get_input_uint("Enter the Height of the floor: ");
            tile_width = get_input_uint("Enter the Width of the tiles: ");
            tile_height = get_input_uint("Enter the Height of the tiles: ");
            per_tile = get_input_float("Enter the cost per tile: ");

            Console.WriteLine("The cost to tile this will be approximately: {0:C}",per_tile*((width*height)/(tile_width*tile_height)));

            uint rows, cols;
            uint altrows, altcols;

            //Simpler solution - compute both ways and take the lesser of the evils on fit
            rows = (width % tile_width == 0) ? (width / tile_width) : (width / tile_width) + 1;
            cols = (height % tile_height == 0) ? (height / tile_height) : (height / tile_height) + 1;

            altrows = (height % tile_width == 0) ? (height / tile_width) : (height / tile_width) + 1;
            altcols = (width % tile_height == 0) ? (width / tile_height) : (width / tile_height) + 1;
            
            if (altrows * altcols < rows * cols)
            {
                rows = altrows;
                cols = altcols;
            }

            /*

            //TODO: Potentially, picking the evenly divisible dimension COULD result in a large waste product and therefore not be 'best fit'
            //TODO: To do it right, should think about the logic a bit more (e.g. how would a human solve it given extremes)
            //First, check the width and make sure it's divisible by tile width or height evenly
            if (width % tile_height == 0)
            {
                cols = width / tile_height;
                //The tiles fit the room width to height
                if (height % tile_width == 0)
                {
                    //The tiles fit the room evenly
                    rows = height / tile_width;
                }
                else
                {
                    //The tiles width does not evenly fit the room (but the height does)
                    rows = (height / tile_width) + 1;
                }

            }
            else if (width % tile_width == 0)
            {
                cols = width / tile_width;
                //The tiles fit the room width to width
                if (height % tile_height == 0)
                {
                    //The tiles fit the room evenly
                    rows = height / tile_height;
                }
                else
                {
                    //The tiles height does not evenly fit the room (but the width does)
                    rows = (height / tile_height) + 1;
                }
            }
            else
            {
                //The room width doesn't evenly fit to the tiles in either dimension so extra column
                  //Reserve judgement on this until we know whether height fits tiles evenly
                //The tiles fit the room width to width
                if (height % tile_height == 0)
                {
                    //The tiles fit the room evenly height to height
                    rows = height / tile_height;
                    cols = (width / tile_width) + 1;
                }
                else if (height % tile_width == 0)
                {
                    ////The tiles fit the room evenly height to width
                    rows = height / tile_width;
                    cols = (width / tile_height) + 1;
                }
                else
                {
                    //We will need both an extra row and column of tiles to compensate
                    //Finally, optimize purchase even more here to determine which size BEST fits the row/column
                    uint altrows, altcols;
                    rows = (height / tile_height) + 1;
                    cols = (width / tile_width) + 1;
                    altrows = (width / tile_height) + 1;
                    altcols = (height / tile_width) + 1;

                    if (altrows*altcols < rows*cols)    
                    {
                        rows = altrows;
                        cols = altcols;
                    }
                }
            }*/
            Console.WriteLine("To make sure you have enough tiles ({0}) you need to spend {1:C}", rows * cols, per_tile * (rows * cols));
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
