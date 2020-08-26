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
    class SmokehouseSkeleton
    {
        /// <summary>
        /// List to store instructions on holding food.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Food available with the Smokehouse Skeleton breakfast combo.
        /// </summary>
        private bool sausageLink, egg, hashBrowns, pancake;

        /// <summary>
        /// Price property to get and set the breakfast combo price.
        /// </summary>
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = 5.62;
            }
        }

        /// <summary>
        /// Calories property to get and set the breakfast combo calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Calories;
            }
            set
            {
                Calories = 602;
            }
        }

        /// <summary>
        /// List property to get or set whether a food comes with the Smokehouse Skeleton breakfast combo.
        /// </summary>
        private List<String> SpecialInstructions
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
