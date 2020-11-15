/*
 * Author: Jonathan Ochampaugh
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// List to store instructions on holding food.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variables for food available with the Smokehouse Skeleton breakfast combo.
        /// </summary>
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

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
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                if (sausageLink != value)
                {
                    sausageLink = value;
                    OnPropertyChanged("SausageLink");
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
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                if (hashBrowns != value)
                {
                    hashBrowns = value;
                    OnPropertyChanged("HashBrowns");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                if (pancake != value)
                {
                    pancake = value;
                    OnPropertyChanged("Pancake");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Price property to get and set the breakfast combo price.
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Calories property to get and set the breakfast combo calories.
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }

        /// <summary>
        /// List property to get or set whether a food comes with the Smokehouse Skeleton breakfast combo.
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if(!sausageLink)
                {
                    _instructions.Add("Hold sausage");
                }
                if (!egg)
                {
                    _instructions.Add("Hold eggs");
                }
                if(!hashBrowns)
                {
                    _instructions.Add("Hold hash browns");
                }
                if(!pancake)
                {
                    _instructions.Add("Hold pancakes");
                }

                return _instructions;
            }
        }

        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }

        /// <summary>
        /// Override string method to return the name of the Smokehouse Skeleton.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
