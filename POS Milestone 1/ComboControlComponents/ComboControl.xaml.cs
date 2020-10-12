/*
 * Author: Jonathan Ochampaugh
 * Class: ComboControl.xaml.cs
 * Purpose: Controls manipulation of a combo
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for ComboControl.xaml
    /// </summary>
    public partial class ComboControl : UserControl
    {
        /// <summary>
        /// Backing variables for the MenuSelect and Combo Items
        /// </summary>
        private MenuSelect menu;
        private Combo combo;

        /// <summary>
        /// Initializes the MenuSelect and combo items, also sets the current DataContext to the current order
        /// </summary>
        /// <param name="m">MenuSelect item kept to access the borders of the screen</param>
        /// <param name="c">Combo currently being manipulated</param>
        /// <param name="o">Order combo is being added to</param>
        public ComboControl(MenuSelect m, Combo c, Order o)
        {
            InitializeComponent();
            DataContext = o;
            menu = m;
            combo = c;
        }

        /// <summary>
        /// Switches to a screen that manipulates the entree of the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeEntreeControlClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                menu.orderBorder.Child = new EntreeControl(menu, combo, order);
            }
        }

        /// <summary>
        /// Switches to a screen that manipulates the drink of the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeDrinkControlClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menu.orderBorder.Child = new DrinkComboControlComponent(menu, combo, order);
            }
        }

        /// <summary>
        /// Switches to a screen that manipulates the side of the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeSideControlClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menu.orderBorder.Child = new SideComboControlComponent(menu, combo, order);
            }
        }

        /// <summary>
        /// Cancel Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            menu.orderBorder.Child = new ButtonControlComponent(menu);
            if (DataContext is Order order)
            {
                var itemBeingRemoved = combo;
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
            menu.orderBorder.Child = new ButtonControlComponent(menu);
        }
    }
}
