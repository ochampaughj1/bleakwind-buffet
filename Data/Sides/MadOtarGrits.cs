/*
 * Author: Jonathan Ochampaugh
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class MadOtarGrits
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
                    Price = 1.22;
                }
                if (currentSize == Size.Medium)
                {
                    Price = 1.58;
                }
                if (currentSize == Size.Large)
                {
                    Price = 1.93;
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
                    Calories = 105;
                }
                if (currentSize == Size.Medium)
                {
                    Calories = 142;
                }
                if (currentSize == Size.Large)
                {
                    Calories = 179;
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
            return "Mad Otar Grits";
        }
    }
}
