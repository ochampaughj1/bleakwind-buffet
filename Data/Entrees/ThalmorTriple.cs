/*
 * Author: Jonathan Ochampaugh
 * Class Name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree
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
        private bool egg = true;

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
                    OnPropertyChanged("SpecialInstructions");
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
                    OnPropertyChanged("SpecialInstructions");
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
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                if (bacon != value)
                {
                    bacon = value;
                    OnPropertyChanged("Bacon");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (egg != value)
                {
                    egg = value;
                    OnPropertyChanged("Egg");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Price property to get and set the burger price.
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// Calories property to get and set the burger calories.
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
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
                if(!egg)
                {
                    _instructions.Add("Hold egg");
                }

                return _instructions;
            }
        }

        public override string Description
        {
            get
            {
                return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
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
