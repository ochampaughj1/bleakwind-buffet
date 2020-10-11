/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeSmokehouseSkeleton.cs
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

namespace POS_Milestone_1.Entrees
{
    /// <summary>
    /// Interaction logic for CustomizeSmokehouseSkeleton.xaml
    /// </summary>
    public partial class CustomizeSmokehouseSkeleton : UserControl
    {
        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        private Order currentOrder;

        private SmokehouseSkeleton currentItem = new SmokehouseSkeleton();

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeSmokehouseSkeleton(MenuSelect menuItem, SmokehouseSkeleton sks, Order o)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = sks;
            currentItem = sks;
            currentOrder = o;
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
