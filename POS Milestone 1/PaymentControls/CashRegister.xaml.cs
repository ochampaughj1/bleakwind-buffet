/*
 * Author: Jonathan Ochampaugh
 * Class: CashRegister.xaml.cs
 * Purpose: Controls cash register payment controls
 */

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POS_Milestone_1.PaymentControls
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        /// <summary>
        /// Backing variables for current MenuSelect, Order, and CurrentOrderControlComponent
        /// </summary>
        private MenuSelect menu;
        private Order currentOrder;
        private CurrentOrderControlComponent receipt;

        /// <summary>
        /// Initializes menu, currentOrder, and receipt and sets data context.
        /// </summary>
        /// <param name="m">Current MenuSelect</param>
        /// <param name="order">Current Order</param>
        /// <param name="temp">Current CurrentOrderControlComponent(receipt)</param>
        public CashRegister(MenuSelect m, Order order, CurrentOrderControlComponent temp)
        {
            InitializeComponent();
            DataContext = order;
            TotalTextBlock.Text = String.Format("{0:0.00}", order.Total);
            menu = m;
            DataContext = new CashRegisterViewModel(order, this);
            currentOrder = order;
            receipt = temp;
        }

        /// <summary>
        /// Click event for returning to the order selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            menu.orderBorder.Child = new ButtonControlComponent(menu);
        }

        /// <summary>
        /// Click event for finalizing the current order sale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FinalizeSaleClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashRegisterViewModel crv)
            {
                crv.FinializeSale();
            }
            currentOrder.Clear();
            menu.orderBorder.Child = new ButtonControlComponent(menu);
            DependencyObject parent = menu;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (parent != null && !(parent is MainWindow));
            ((MainWindow)parent).DataContext = new Order();
            receipt.CompleteOrderButton.IsEnabled = true;
        }
    }
}
