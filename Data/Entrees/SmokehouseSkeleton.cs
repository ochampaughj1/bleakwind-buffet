/*
 * Author: Jonathan Ochampaugh
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;

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
        /// Getters and setters for backing variables
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
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
