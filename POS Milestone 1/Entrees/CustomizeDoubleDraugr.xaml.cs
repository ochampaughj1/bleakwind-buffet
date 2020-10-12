/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeDoubleDraugr.cs
 * Purpose: Switches between screens based on buttons clicked
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
using POS_Milestone_1.ComboControlComponents;

namespace POS_Milestone_1.Entrees
{
    /// <summary>
    /// Interaction logic for CustomizeDoubleDraugr.xaml
    /// </summary>
    public partial class CustomizeDoubleDraugr : UserControl
    {
        /// <summary>
        /// Backing variables for current drink, MenuSelect item, the potential current combo, and the current order
        /// </summary>
        private MenuSelect ms;
        private Order currentOrder;
        private DoubleDraugr currentItem;
        private Combo currentCombo;


        /// <summary>
        /// Constuctor to initialize Menu Select item, current entree item, current order, current combo
        /// </summary>
        /// <param name="menuItem">MenuSelect item to have access to the screens borders</param>
        /// <param name="dd">Entree item to be customized</param>
        /// <param name="o">Order to add the entree to</param>
        /// <param name="c">Combo to add the entree to</param>
        public CustomizeDoubleDraugr(MenuSelect menuItem, DoubleDraugr dd, Order o, Combo c)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = dd;
            currentItem = dd;
            currentOrder = o;
            currentCombo = c;
        }

        /// <summary>
        /// Click Event for returning to the menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            ms.orderBorder.Child = new ComboControl(ms, currentCombo, currentOrder);
        }

        /// <summary>
        /// Cancel Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            ms.orderBorder.Child = new ButtonControlComponent(ms);
            DataContext = currentOrder;
            if (DataContext is Order order)
            {
                var itemBeingRemoved = currentItem;
                order.Remove(itemBeingRemoved);
            }
        }

        /// <summary>
        /// Done Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            ms.orderBorder.Child = new ButtonControlComponent(ms);
        }
    }
}
