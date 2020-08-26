/*
 * Author: Jonathan Ochampaugh
 * Class Name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        /// <summary>
        /// List to store instructions on holding ingredients.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Ingredients available on the Philly Poacher.
        /// </summary>
        private bool sirloin, onion, roll;

        /// <summary>
        /// Price property to get and set the sandwich price.
        /// </summary>
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = 7.23;
            }
        }

        /// <summary>
        /// Calories property to get and set the sandwich calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Calories;
            }
            set
            {
                Calories = 784;
            }
        }

        /// <summary>
        /// List property to get or set whether a ingredients are on the sandwich.
        /// </summary>
        private List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if (!sirloin)
                {
                    _instructions.Add("Hold sirloin");
                }
                if(!onion)
                {
                    _instructions.Add("Hold Onions");
                }
                if(!roll)
                {
                    _instructions.Add("Hold roll");
                }

                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the sandwich.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
