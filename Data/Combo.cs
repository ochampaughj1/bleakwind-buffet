/*
 * Author: Jonathan Ochampaugh
 * Class Name: Combo.cs
 * Purpose: Class used to represent a combo making up an order
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing a combo of items from the menu
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Implements the interface of INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed Invoke helper method
        /// </summary>
        /// <param name="name">Name of property being invoked</param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Private instances of Entree, Drink, and Side to be initialized within the combo
        /// </summary>
        private Drink drink = null;
        private Entree entree = null;
        private Side side = null;

        /// <summary>
        /// Constructor initializing the entree, side, and drink contained within the combo 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <param name="s"></param>
        public Combo(Entree e, Drink d, Side s)
        {
            entree = e;
            drink = d;
            side = s;
        }

        /// <summary>
        /// Entree Property to get the entree and check check to make sure all properties are updated and invoked.
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if(entree != value)
                {
                    if (entree != null) entree.PropertyChanged -= ItemPropertyChangedListener;
                    entree = value;
                    entree.PropertyChanged += ItemPropertyChangedListener;
                    OnPropertyChanged("Entree");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Drink Property to get the drink and check check to make sure all properties are updated and invoked.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != value)
                {
                    if (drink != null) drink.PropertyChanged -= ItemPropertyChangedListener;
                    drink = value;
                    drink.PropertyChanged += ItemPropertyChangedListener;
                    OnPropertyChanged("Drink");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Side Property to get the side and check check to make sure all properties are updated and invoked.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != value)
                {
                    if (side != null) side.PropertyChanged -= ItemPropertyChangedListener;
                    side = value;
                    side.PropertyChanged += ItemPropertyChangedListener;
                    OnPropertyChanged("Side");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Price of all items in the combo
        /// </summary>
        public double Price
        {
            get
            {
                double price = 0;
                price += entree.Price + drink.Price + side.Price - 1.00;
                return price;
            }
            set
            {
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Calories of all items in the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                calories += entree.Calories + drink.Calories + side.Calories;
                return calories;
            }
            set
            {
                OnPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Special Instructions for all items in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(entree.ToString() + ":");
                foreach(string e in entree.SpecialInstructions)
                {
                    instructions.Add(e + ", ");
                }
                instructions.Add(drink.ToString() + ":");
                foreach (string d in drink.SpecialInstructions)
                {
                    instructions.Add(d + ", ");
                }
                instructions.Add(side.ToString() + ":");
                foreach (string s in side.SpecialInstructions)
                {
                    instructions.Add(s + ", ");
                }
                return instructions;
            }
            set
            {
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Event listener for properties being changed within the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemPropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Price":
                    OnPropertyChanged("Price");
                    break;
                case "Calories":
                    OnPropertyChanged("Calories");
                    break;
                case "SpecialInstructions":
                    OnPropertyChanged("SpecialInstructions");
                    break;
            }
        }
    }
}
