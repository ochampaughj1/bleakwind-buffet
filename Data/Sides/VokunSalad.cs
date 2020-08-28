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
        private Size size = Size.Small;

        /// <summary>
        /// Property to get and set the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else 
                {
                    return 1.82;
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
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else 
                {
                    return 73;
                }
            }
        }

        /// <summary>
        /// Property to get the size of the side
        /// </summary>
        public Size Size
        {
            get { return size;}
            set { size = value;}
        }

        /// <summary>
        /// Override string method to return the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + "Vokun Salad";
        }
    }
}
