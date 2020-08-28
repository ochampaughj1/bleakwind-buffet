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
    class WarriorWater
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
        public bool ice;
        public bool lemon = false;

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
                    Price = 0.00;
                }
                if (currentSize == Size.Medium)
                {
                    Price = 0.00;
                }
                if (currentSize == Size.Large)
                {
                    Price = 0.00;
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
                    Calories = 0;
                }
                if (currentSize == Size.Medium)
                {
                    Calories = 0;
                }
                if (currentSize == Size.Large)
                {
                    Calories = 0;
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
                if (!ice)
                {
                    _instructions.Add("Hold ice");
                }
                if(lemon == true)
                {
                    _instructions.Add("Add lemon");
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
            return "Warrior Water";
        }
    }
}
