/*
 * Author: Jonathan Ochampaugh
 * Class Name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
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
            set
            {
                if (sirloin != value)
                {
                    sirloin = value;
                    OnPropertyChanged("Sirloin");
                }
            }
        }
        public bool Onion
        {
            get { return onion; }
            set
            {
                if (onion != value)
                {
                    onion = value;
                    OnPropertyChanged("Onion");
                }
            }
        }
        public bool Roll
        {
            get { return roll; }
            set
            {
                if (roll != value)
                {
                    roll = value;
                    OnPropertyChanged("Roll");
                }
            }
        }


        /// <summary>
        /// Price property to get and set the sandwich price.
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Calories property to get and set the sandwich calories.
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// List property to get or set whether a ingredients are on the sandwich.
        /// </summary>
        public override List<String> SpecialInstructions
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
