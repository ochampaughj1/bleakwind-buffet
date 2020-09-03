/*
 * Author: Jonathan Ochampaugh
 * Class Name: 
 * Purpose: Class used to represent the 
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Stores the current size of the drink
        /// </summary>
        private Size size = Size.Small;

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
        public double Price
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
        public uint Calories
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
        /// Property to get the size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// List to store items to hold from the drink
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if (ice == true)
                {
                    _instructions.Add("Add ice");
                }
                if(roomForCream == true)
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
                return size.ToString() + "Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + "Decaf Candlehearth Coffee";
            }
        }
    }
}
