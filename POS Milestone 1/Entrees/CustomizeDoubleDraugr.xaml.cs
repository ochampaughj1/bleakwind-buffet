﻿/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeDoubleDraugr.cs
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

namespace POS_Milestone_1.Entrees
{
    /// <summary>
    /// Interaction logic for CustomizeDoubleDraugr.xaml
    /// </summary>
    public partial class CustomizeDoubleDraugr : UserControl
    {
        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeDoubleDraugr(MenuSelect menuItem, DoubleDraugr dd)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = dd;
        }

        /// <summary>
        /// Cancel Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            ms.orderBorder.Child = ms.menu;
        }
    }
}
