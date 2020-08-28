/*
 * Author: Jonathan Ochampaugh
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
    {
        /// <summary>
        /// Stores the current size of the side
        /// </summary>
        private Size currentSize = Size.Small;

        /// <summary>
        /// Property to get and set the price of the side
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
                    Price = 0.93;
                }
                if (currentSize == Size.Medium)
                {
                    Price = 1.28;
                }
                if (currentSize == Size.Large)
                {
                    Price = 1.82;
                }
            }
        }

        /// <summary>
        /// Property to get and set the calories of the side.
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
                    Calories = 41;
                }
                if (currentSize == Size.Medium)
                {
                    Calories = 52;
                }
                if (currentSize == Size.Large)
                {
                    Calories = 73;
                }
            }
        }

        /// <summary>
        /// Property to get the size of the side
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
        /// Override string method to return the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string size;
            return "Vokun Sald";
        }
    }
}
