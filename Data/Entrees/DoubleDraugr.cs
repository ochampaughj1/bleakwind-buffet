/*
 * Author: Jonathan Ochampaugh
 * Class Name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr burger
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem
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

        /// <summary>
        /// Gets the current name of the item
        /// </summary>
        public string Name
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Getters and setters for backing variables
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                if (bun != value)
                {
                    bun = value;
                    OnPropertyChanged("Bun");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    OnPropertyChanged("Ketchup");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    OnPropertyChanged("Mustard");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    OnPropertyChanged("Pickle");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    OnPropertyChanged("Cheese");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    OnPropertyChanged("Tomato");
                }
            }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    OnPropertyChanged("Lettuce");
                }
            }
        }
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    OnPropertyChanged("Mayo");
                }
            }
        }

        /// <summary>
        /// Price property to get and set the burger price.
        /// </summary>
        public override double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// Calories property to get and set the burger calories.
        /// </summary>
        public override uint Calories
        {
            get { return 843; }
        }

        /// <summary>
        /// List property to get or set whether a topping is on the burger.
        /// </summary>
        public override List<String> SpecialInstructions
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
                if(!lettuce)
                {
                    _instructions.Add("Hold lettuce");
                }
                if(!mayo)
                {
                    _instructions.Add("Hold mayo");
                }

                return _instructions;
            }
        }
        public override string Description
        {
            get
            {
                return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            }
        }

        /// <summary>
        /// Override string method to return the name of the burger.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
