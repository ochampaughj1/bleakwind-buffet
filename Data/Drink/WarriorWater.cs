﻿/*
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
    public class WarriorWater
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
        /// Variable to hold ice from the drink
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Variable to add lemon to the drink
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// Getter and setter for the backing variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Getter and setter for the backing variable
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public double Price
        {
            get { return 0.00; }
        }

        /// <summary>
        /// Property to get and set the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get { return 0; }
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
                if (!ice)
                {
                    _instructions.Add("Hold ice");
                }
                if(lemon == true)
                {
                    _instructions.Add("Add lemon");
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
            return size.ToString() + "Warrior Water";
        }
    }
}