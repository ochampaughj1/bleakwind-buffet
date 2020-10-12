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

        public int Count => order.Count;

        public bool IsReadOnly => false;

        //DOUBLE CHECK THIS METHOD
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

        public bool Contains(IOrderItem item)
        {
            return order.Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            order.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return order.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return order.GetEnumerator();
        }
    }
}
