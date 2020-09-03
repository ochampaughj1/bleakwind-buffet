/*
 * Author: Jonathan Ochampaugh
 * Class Name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Stores the current size of the drink
        /// </summary>
        private Size size = Size.Small;

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
        /// Getter and setter for backing variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    return 1.42;
                }
                else if(size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
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
                if(size == Size.Small)
                {
                    return 117;
                }
                else if(size == Size.Medium)
                {
                    return 153;
                }
                else 
                {
                    return 205;
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
        /// Property to get the flavor of the soda
        /// </summary>
        public SodaFlavor SodaFlavor
        {
            get { return flavor;}
            set { flavor = value; }
        }

        /// <summary>
        /// List to store items to hold from the drink
        /// </summary>
        public List<String> SpecialInstructions
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

        /// <summary>
        /// Override string method to return the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            return Size.ToString() + SodaFlavor.ToString() + "Sailor Soda";
        }
    }
}
