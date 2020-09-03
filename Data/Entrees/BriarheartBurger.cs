/*
 * Author: Jonathan Ochampaugh
 * Class Name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// List to store instructions on holding toppings.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variables for topping available on the Briarheart Burger.
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// Getters and setters for backing variables
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun= value; }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup= value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard= value; }
        }
        public bool Pickle
        {
            get { return pickle; }
            set { pickle= value; }
        }
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Price property to get and set the burger price.
        /// </summary>
        public double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// Calories property to get and set the burger calories.
        /// </summary>
        public uint Calories
        {
            get { return 743; }
        }

        /// <summary>
        /// List property to get or set whether a topping is on the burger.
        /// </summary>
        public List<String> SpecialInstructions
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

                return _instructions;
            }

        }

        /// <summary>
        /// Override string method to return the name of the burger.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
