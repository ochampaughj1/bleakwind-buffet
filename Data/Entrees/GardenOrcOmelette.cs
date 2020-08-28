/*
 * Author: Jonathan Ochampaugh
 * Class Name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        /// <summary>
        /// List to store instructions on holding ingredients.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variables for toppings available with the Garden Orc Omelette.
        /// </summary>
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// Getters and setters for backing variables
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Price property to get and set the omelette price.
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// Calories property to get and set the omelette calories.
        /// </summary>
        public uint Calories
        {
            get { return 404; }
        }

        /// <summary>
        /// List property to get or set whether a topping is on the omelette.
        /// </summary>
        private List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if (!broccoli)
                {
                    _instructions.Add("Hold broccoli");
                }
                if (!mushrooms)
                {
                    _instructions.Add("Hold mushrooms");
                }
                if (!tomato)
                {
                    _instructions.Add("Hold tomato");
                }
                if (!cheddar)
                {
                    _instructions.Add("Hold cheddar");
                }

                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the omelette.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
