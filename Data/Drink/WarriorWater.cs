/*
 * Author: Jonathan Ochampaugh
 * Class Name: WarriorWater
 * Purpose: Class used to represent Warrior Water
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink
    {
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
            set
            {
                if (ice != value)
                {
                    ice = value;
                    OnPropertyChanged("Ice");
                }
            }
        }

        /// <summary>
        /// Getter and setter for the backing variable
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                if (lemon != value)
                {
                    lemon = value;
                    OnPropertyChanged("Lemon");
                }
            }
        }

        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.00;
                    case Size.Medium:
                        return 0.00;
                    case Size.Large:
                        return 0.00;
                    default: throw new NotImplementedException("Should never be reached");
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
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default: throw new NotImplementedException("Should never be reached");
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
            return size.ToString() + " Warrior Water";
        }
    }
}
