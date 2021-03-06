﻿/*
 * Author: Jonathan Ochampaugh
 * Class Name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink
    {
        /// <summary>
        /// Stores the current flavor of the drink
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Choice to hold items from the drink
        /// </summary>
        private bool ice = true;
        
        /// <summary>
        /// List to store instructions on holding ingredients
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
        /// Getter and setter for backing variable
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
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Property to get the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                if (flavor != value)
                {
                    flavor = value;
                    OnPropertyChanged("Flavor");
                    OnPropertyChanged("SpecialInstructions");
                    OnPropertyChanged("Name");
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
                if(!ice)
                {
                    _instructions.Add("Hold ice");
                }

                return _instructions;
            }
        }

        public override string Description
        {
            get { return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice."; }
        }

        /// <summary>
        /// Override string method to return the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            return Size.ToString() + " " + Flavor.ToString() + " Sailor Soda";
        }
    }
}
