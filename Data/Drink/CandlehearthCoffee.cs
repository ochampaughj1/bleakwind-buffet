﻿/*
 * Author: Jonathan Ochampaugh
 * Class Name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee 
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink
    {
        /// <summary>
        /// List to store instructions on holding ingredients
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variable to add ice to the drink
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Variable to add cream to the drink
        /// </summary>
        private bool roomForCream = false;


        /// <summary>
        /// Variable to make the drink decaf
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }


        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else 
                {
                    return 1.75;
                }
            }
        }

        /// <summary>
        /// Property to get and set the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else 
                {
                    return 20;
                }
            }
        }

        /// <summary>
        /// List to store items to hold from the drink
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if (ice)
                {
                    _instructions.Add("Add ice");
                }
                if(roomForCream)
                {
                    _instructions.Add("Add cream");
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
            if(!decaf)
            {
                return size.ToString() + " Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + " Decaf Candlehearth Coffee";
            }
        }
    }
}
