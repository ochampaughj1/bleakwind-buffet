/* Author: Jonathan Ochampaugh
 * Class: Side.cs
 * Purpose: Establish a base class representing the common properties of  a side.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Allows base class to access the earlier defined size variable to default small as the size.
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// The price of the side
        /// </summary>
        ///<value> 
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
