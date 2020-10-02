/*
 * Author: Jonathan Ochampaugh
 * Class Name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Arentino Apple Juice
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Implements the interface of INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List to store instructions on holding ingredients
        /// </summary>
        private List<string> _instructions;

        /// <summary>
        /// Variable to hold ice from the drink
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// Getter and setter for backing variable
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));

                }
            }
        }

        /// <summary>
        /// Property to get and set the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Property to get and set the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// List to store items to hold from the drink
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                _instructions = new List<string>();
                if(ice == true)
                {
                    _instructions.Add("Add ice");
                }

                return _instructions;
            }
        }

        /// <summary>
        /// Override string method to return the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
