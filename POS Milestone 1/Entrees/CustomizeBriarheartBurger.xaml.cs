/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeBriarheartBurger.cs
 * Purpose: Switches between screens based on buttons clicked
 */

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
using BleakwindBuffet.Data;
using POS_Milestone_1.ComboControlComponents;

namespace POS_Milestone_1.Entrees
{
    /// <summary>
    /// Interaction logic for CustomizeBriarheartBurger.xaml
    /// </summary>
    public partial class CustomizeBriarheartBurger : UserControl
    {
        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        private Order currentOrder;

        private BriarheartBurger currentBurger;

        private Combo currentCombo;

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeBriarheartBurger(MenuSelect menuItem, BriarheartBurger bb, Order o, Combo c)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = bb;
            currentOrder = o;
            currentBurger = bb;
            currentCombo = c;
        }

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
                var itemBeingRemoved = currentBurger;
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
