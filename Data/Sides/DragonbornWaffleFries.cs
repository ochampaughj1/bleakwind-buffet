/*
 * Author: Jonathan Ochampaugh
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent DragonbornWaffleFries side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
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
                    return 0.42;
                }
                else if (size == Size.Medium)
                {
                    return 0.76;
                }
                else 
                {
                    return 0.96;
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
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else 
                {
                    return 100;
                }
            }
        }

        /// <summary>
        /// Property to get the size of the side
        /// </summary>
        public Size Size
        {
            get { return size; }
                
            set { size = value; }
                
        }

        /// <summary>
        /// Override string method to return the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            return size.ToString() + "Dragonborn Waffle Fries";
        }
    }
}
