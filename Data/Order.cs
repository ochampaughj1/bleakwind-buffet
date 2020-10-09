/*
 * Author: Jonathan Ochampaugh
 * Class Name: Order.cs
 * Purpose: Class used to represent an order
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>
    {
        public Order()
        {

        }

        double SalesTaxRate
        {
            get { }
            set
            {

            }
        }

        double Subtotal
        {
            get
            {

            }
        }

        double Tax
        {
            get
            {

            }
        }

        double Total
        {
            get
            {

            }
        }
    }
}
