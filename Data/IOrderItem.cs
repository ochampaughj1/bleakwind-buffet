/* Author: Jonathan Ochampaugh
 * Class: IOrderItem.cs
 * Purpose: Interface to get the Price, Calories, and Special Instructions for menu items.
 */


using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface to get the Price, Calories, and Special Instructions for menu items.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
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

        /// <summary>
        /// Returns the description of the current menu item
        /// </summary>
        string Description { get; }
    }
}
