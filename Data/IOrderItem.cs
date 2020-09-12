/* Author: Jonathan Ochampaugh
 * Class: IOrderItem.cs
 * Purpose: 
 */


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the drink/entree/side
        /// </summary>
        ///<value> 
        /// In US dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the drink/entree/side
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink/entree/side
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
