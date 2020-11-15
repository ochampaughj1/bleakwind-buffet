/*
 * Author: Jonathan Ochampaugh
 * Class Name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// Gets the current name of the item
        /// </summary>
        public string Name
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                if(ice != value)
                {
                    ice = value;
                    OnPropertyChanged("Ice");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    OnPropertyChanged("Decaf");
                    OnPropertyChanged("SpecialInstructions");
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if (roomForCream != value)
                {
                    roomForCream = value;
                    OnPropertyChanged("RoomForCream");
                    OnPropertyChanged("SpecialInstructions");
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
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
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

        public override string Description
        {
            get { return "Fair trade, fresh ground dark roast coffee."; }
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
