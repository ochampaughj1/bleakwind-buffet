/*
 * Author: Jonathan Ochampaugh
 * Class Name: Order.cs
 * Purpose: Class used to represent an order
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing an Order from the Bleakwind Buffet
    /// </summary>
    public class Order : INotifyPropertyChanged, ICollection<IOrderItem>, INotifyCollectionChanged
    {
        /// <summary>
        /// Public event handler for a property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Public event handler for a collection change
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Property Changed Invoke helper method
        /// </summary>
        /// <param name="name">Name of property being invoked</param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// List of all IOrderItems within the order
        /// </summary>
        public List<IOrderItem> order = new List<IOrderItem>();

        /// <summary>
        /// Backing variable with the initial order number
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// Backing variable with the initial sales tax
        /// </summary>
        private double salesTaxRate = 0.12;

        /// <summary>
        /// Gets and sets the current order number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Constructor that initializes the number property
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Gets and sets the sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if(salesTaxRate != value)
                {
                    salesTaxRate = value;
                    OnPropertyChanged("SalesTaxRate");
                }
            }
        }

        /// <summary>
        /// Gets the subtotal(total of all items in the order)
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Gets the tax of the order
        /// </summary>
        public double Tax
        {
            get
            {
                double tax;
                tax = Subtotal * salesTaxRate;
                return tax;
            }
        }

        /// <summary>
        /// Gets the final total of the order
        /// </summary>
        public double Total
        {
            get
            {
                double total;
                total = Subtotal + Tax;
                return total;
            }
        }

        /// <summary>
        /// Gets the total calories of the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint totalCalories = 0;
                foreach(IOrderItem item in order)
                {
                    totalCalories += item.Calories;
                }
                return totalCalories;
            }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        public void Add(IOrderItem item)
        {
            order.Add(item);
            item.PropertyChanged += CollectionItemChangedListener;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        public bool Remove(IOrderItem item)
        {
            int index = order.FindIndex(i => i == item);
            var remove = order.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
            return remove;
        }

        /// <summary>
        /// Event listener that updates subtotal, tax, total, and calories when price and calorie properties of the order change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged("Subtotal");
                OnPropertyChanged("Tax");
                OnPropertyChanged("Total");
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// The number of items within the order
        /// </summary>
        public int Count => order.Count;

        /// <summary>
        /// Allows order to be manipulated
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Clears all items in the order
        /// </summary>
        public void Clear()
        {
            //remove all items within collection;
            //use clear method within list;
            foreach(IOrderItem item in order)
            {
                item.PropertyChanged -= CollectionItemChangedListener;
            }
            order.Clear();
        }

        /// <summary>
        /// Determines whether a specified item is within the order
        /// </summary>
        /// <param name="item">IOrderItem to be checked for</param>
        /// <returns>Whether or not the Order contains the given item</returns>
        public bool Contains(IOrderItem item)
        {
            return order.Contains(item);
        }

        /// <summary>
        /// Copies an item to the given array index
        /// </summary>
        /// <param name="array">Array of items to be copied to</param>
        /// <param name="arrayIndex">Index of current copy</param>
        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            order.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Iterates over the collection/order
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return order.GetEnumerator();
        }

        /// <summary>
        /// Retrieves an Enumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return order.GetEnumerator();
        }
    }
}
