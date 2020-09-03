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
    public class ThalmorTriple
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
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool eggs = true;

        /// <summary>
        /// Getters and setters for backing variables
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        public bool Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }

        /// <summary>
        /// Price property to get and set the burger price.
        /// </summary>
        public double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// Calories property to get and set the burger calories.
        /// </summary>
        public uint Calories
        {
            get { return 943; }
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
                    _instructions.Add("Hold bun");
                }
                if (!ketchup)
                {
                    _instructions.Add("Hold ketchup");
                }
                if (!mustard)
                {
                    _instructions.Add("Hold mustard");
                }
                if (!pickle)
                {
                    _instructions.Add("Hold pickle");
                }
                if (!cheese)
                {
                    _instructions.Add("Hold cheese");
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
