/*
 * Author: Jonathan Ochampaugh
 * Class Name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
        /// <summary>
        /// List to store instructions on holding toppings.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Toppings available on the Thalmor Triple.
        /// </summary>
        private bool bun, ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, eggs;

        /// <summary>
        /// Price property to get and set the burger price.
        /// </summary>
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = 8.32;
            }
        }

        /// <summary>
        /// Calories property to get and set the burger calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Calories;
            }
            set
            {
                Calories = 943;
            }
        }

        /// <summary>
        /// List property to get or set whether a topping is on the burger.
        /// </summary>
        private List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if (!bun)
                {
                    _instructions.Add("Hold Bun");
                }
                if (!ketchup)
                {
                    _instructions.Add("Hold Ketchup");
                }
                if (!mustard)
                {
                    _instructions.Add("Hold Mustard");
                }
                if (!pickle)
                {
                    _instructions.Add("Hold Pickle");
                }
                if (!cheese)
                {
                    _instructions.Add("Hold Cheese");
                }
                if (!tomato)
                {
                    _instructions.Add("Hold tomato");
                }
                if (!lettuce)
                {
                    _instructions.Add("Hold lettuce");
                }
                if (!mayo)
                {
                    _instructions.Add("Hold mayo");
                }
                if(!bacon)
                {
                    _instructions.Add("Hold bacon");
                }
                if(!eggs)
                {
                    _instructions.Add("Hold egg");
                }

                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the burger.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
