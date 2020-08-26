/*
 * Author: Jonathan Ochampaugh
 * Class Name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {
        /// <summary>
        /// Stores the current size of the drink
        /// </summary>
        private Size currentSize = Size.Small;

        /// <summary>
        /// Stores the current flavor of the drink
        /// </summary>
        private SodaFlavor currentFlavor = SodaFlavor.Cherry;

        /// <summary>
        /// List to store instructions on holding ingredients
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Choice to hold items from the drink
        /// </summary>
        public bool ice;

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
                if(currentSize == Size.Small)
                {
                    Price = 1.42;
                }
                if(currentSize == Size.Medium)
                {
                    Price = 1.74;
                }
                if(currentSize == Size.Large)
                {
                    Price = 2.07;
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
                    Calories = 117;
                }
                if (currentSize == Size.Medium)
                {
                    Calories = 153;
                }
                if (currentSize == Size.Large)
                {
                    Calories = 205;
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
                if()
                {
                    currentSize = 
                }
            }
        }

        /// <summary>
        /// Property to get the flavor of the soda
        /// </summary>
        public SodaFlavor SodaFlavor
        {
            get
            {
                return currentFlavor;
            }
            set
            {
                if()
                {
                    currentFlavor = 
                }
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
                if(!ice)
                {
                    _instructions.Add("Hold ice");
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
            return "Sailor Soda";
        }
    }
}
