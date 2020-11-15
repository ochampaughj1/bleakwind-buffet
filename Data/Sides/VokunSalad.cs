/*
 * Author: Jonathan Ochampaugh
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side
    {
        /// <summary>
        /// List to store instructions on holding toppings.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Gets the current name of the item
        /// </summary>
        public string Name
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Property to get and set the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    case Size.Large:
                        return 1.82;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Property to get and set the calories of the side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 41;
                    case Size.Medium:
                        return 52;
                    case Size.Large:
                        return 73;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// List of items being returned
        /// </summary>
        /// <return>Nothing since there are no special instructions to add</return>
        public override List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                return _instructions;
            }
        }

        public override string Description
        {
            get { return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges."; }
        }

        /// <summary>
        /// Override string method to return the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Vokun Salad";
        }
    }
}
