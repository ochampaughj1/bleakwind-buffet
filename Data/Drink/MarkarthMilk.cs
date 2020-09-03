/*
 * Author: Jonathan Ochampaugh
 * Class Name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk 
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// Stores the current size of the drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// List to store instructions on holding ingredients
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variable to hold ice from the drink
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.05;
                }
                else if (size == Size.Medium)
                {
                    return 1.11;
                }
                else 
                {
                    return 1.22;
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
                if (size == Size.Small)
                {
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else 
                {
                    return 93;
                }
            }
        }

        /// <summary>
        /// Property to get the size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// List to store items to hold from the drink
        /// </summary>
        public List<String> SpecialInstructions
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
            return size.ToString() + "Markarth Milk";
        }
    }
}
