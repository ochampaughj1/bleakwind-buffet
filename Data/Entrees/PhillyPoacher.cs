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
    public class PhillyPoacher
    {
        /// <summary>
        /// List to store instructions on holding ingredients.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variables for ingredients available on the Philly Poacher.
        /// </summary>
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// Getters and setters for backing variables
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }


        /// <summary>
        /// Price property to get and set the sandwich price.
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Calories property to get and set the sandwich calories.
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// List property to get or set whether a ingredients are on the sandwich.
        /// </summary>
        public List<String> SpecialInstructions
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
                    _instructions.Add("Hold onions");
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
