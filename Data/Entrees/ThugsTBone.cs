/*
 * Author: Jonathan Ochampaugh
 * Class Name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// List to store instructions on holding ingredients.
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Price property to get and set the steak price.
        /// </summary>
        public override double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// Calories property to get and set the steak calories.
        /// </summary>
        public override uint Calories
        {
            get { return 982; }
        }

        /// <summary>
        /// List property to get or set whether ingredients are included with the Thugs T-Bone.
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the steak.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
