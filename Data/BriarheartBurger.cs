using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Author: Jonathan Ochampaugh
/// Class name: BriarheartBurger.cs
/// Purpose: Class used to represent the Briarheart Burger
/// </summary>

namespace BleakwindBuffet.Data.Entrees
{
    class BriarheartBurger
    {
        private List<string> _instructions;
        private bool bun, ketchup, mustard, pickle, cheese;
        
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = 6.32; 
            }
        }
        public uint Calories
        {
            get
            {
                return Calories;
            }
            set
            {
                Calories = 743;
            }
        }
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

                return _instructions;
            }

        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
