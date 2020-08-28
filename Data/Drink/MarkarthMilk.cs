/*
 * Author: Jonathan Ochampaugh
 * Class Name: 
 * Purpose: Class used to represent the 
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class MarkarthMilk
    {
        /// <summary>
        /// Stores the current size of the drink
        /// </summary>
        private Size currentSize = Size.Small;

        /// <summary>
        /// List to store instructions on holding ingredients
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Choice to hold items from the drink
        /// </summary>
        public bool ice = false;

        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (currentSize == Size.Small)
                {
                    Price = 1.05;
                }
                if (currentSize == Size.Medium)
                {
                    Price = 1.11;
                }
                if (currentSize == Size.Large)
                {
                    Price = 1.22;
                }
            }
        }

        /// <summary>
        /// Property to get and set the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Calories;
            }
            set
            {
                if (currentSize == Size.Small)
                {
                    Calories = 56;
                }
                if (currentSize == Size.Medium)
                {
                    Calories = 72;
                }
                if (currentSize == Size.Large)
                {
                    Calories = 93;
                }
            }
        }

        /// <summary>
        /// Property to get the size of the drink
        /// </summary>
        public Size Size
        {
            get
            {
                return currentSize;
            }
            set
            {
                currentSize = value;
            }
        }

        /// <summary>
        /// List to store items to hold from the drink
        /// </summary>
        private List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if (ice == true)
                {
                    _instructions.Add("Add ice");
                }

                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string size;
            return "Markarth Milk";
        }
    }
}
