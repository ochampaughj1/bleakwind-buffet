/*
 * Author: Jonathan Ochampaugh
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Stores the current size of the side
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// List to store instructions on holding toppings.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Property to get and set the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.78;
                }
                else if (size == Size.Medium)
                {
                    return 2.01;
                }
                else 
                {
                    return 2.88;
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
                    return 151;
                }
                else if (size == Size.Medium)
                {
                    return 236;
                }
                else 
                {
                    return 306;
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
        /// List of items being returned
        /// </summary>
        /// <return>Nothing since there are no special instructions to add</return>
        public List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + "Fried Miraak";
        }
    }
}
