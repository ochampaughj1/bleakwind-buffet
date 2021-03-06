﻿/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeFriedMiraak.cs
 * Purpose: Switches between screens based on buttons clicked
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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

using Size = BleakwindBuffet.Data.Enums.Size;

namespace POS_Milestone_1.Sides
{
    /// <summary>
    /// Interaction logic for CustomizeFriedMiraak.xaml
    /// </summary>
    public partial class CustomizeFriedMiraak : UserControl
    {
        /// <summary>
        /// Backing variables for current drink, MenuSelect item, the potential current combo, and the current order
        /// </summary>
        private FriedMiraak currentItem;
        private Combo currentCombo;
        private Order currentOrder;
        private MenuSelect ms;

        /// <summary>
        /// Constuctor to initialize Menu Select item, current side item, current order, current combo
        /// </summary>
        /// <param name="menuItem">MenuSelect item to have access to the screens borders</param>
        /// <param name="fm">Side item to be customized</param>
        /// <param name="o">Order to add the side to</param>
        /// <param name="c">Combo to add the side to</param>
        public CustomizeFriedMiraak(MenuSelect menuItem, FriedMiraak fm, Order o, Combo c)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = fm;
            currentItem = fm;
            currentOrder = o;
            currentCombo = c;
        }

        /// <summary>
        /// Click Event for returning to the combo screen
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

        /// <summary>
        /// Check box event handler to make sure only one size is checked at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxChecked(object sender, RoutedEventArgs e)
        {
            Size s;
            if (sender is CheckBox cb)
            {
                switch (cb.Name)
                {
                    case "smallCheckBox":
                        smallCheckBox.IsChecked = true;
                        mediumCheckBox.IsChecked = false;
                        largeCheckBox.IsChecked = false;
                        s = Size.Small;
                        break;

                    case "mediumCheckBox":
                        mediumCheckBox.IsChecked = true;
                        smallCheckBox.IsChecked = false;
                        largeCheckBox.IsChecked = false;
                        s = Size.Medium;
                        break;

                    case "largeCheckBox":
                        largeCheckBox.IsChecked = true;
                        mediumCheckBox.IsChecked = false;
                        smallCheckBox.IsChecked = false;
                        s = Size.Large;
                        break;

                    default:
                        throw new NotImplementedException();
                }
                currentItem.Size = s;
            }
        }
    }
}
