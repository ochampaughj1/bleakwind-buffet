/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeFriedMiraak.cs
 * Purpose: Switches between screens based on buttons clicked
 */

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

namespace POS_Milestone_1.Sides
{
    /// <summary>
    /// Interaction logic for CustomizeFriedMiraak.xaml
    /// </summary>
    public partial class CustomizeFriedMiraak : UserControl
    {
        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeFriedMiraak(MenuSelect menuItem)
        {
            InitializeComponent();
            ms = menuItem;
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

        /// <summary>
        /// Small Check Box Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmallSizeChecked(object sender, RoutedEventArgs e) { mediumCheckBox.IsChecked = false; largeCheckBox.IsChecked = false; }

        /// <summary>
        /// Medium Check Box Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MediumSizeChecked(object sender, RoutedEventArgs e) { smallCheckBox.IsChecked = false; largeCheckBox.IsChecked = false; }

        /// <summary>
        /// Large Check Box Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LargeSizeChecked(object sender, RoutedEventArgs e) { smallCheckBox.IsChecked = false; mediumCheckBox.IsChecked = false; }
    }
}
