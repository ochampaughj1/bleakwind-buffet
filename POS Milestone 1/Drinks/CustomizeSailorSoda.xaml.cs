/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeSailorSoda.cs
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

namespace POS_Milestone_1.Drinks
{
    /// <summary>
    /// Interaction logic for CustomizeSailorSoda.xaml
    /// </summary>
    public partial class CustomizeSailorSoda : UserControl
    {
        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeSailorSoda(MenuSelect menuItem)
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
        /// Small Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmallSizeChecked(object sender, RoutedEventArgs e) { mediumCheckBox.IsChecked = false; largeCheckBox.IsChecked = false; }

        /// <summary>
        /// Medium Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MediumSizeChecked(object sender, RoutedEventArgs e) { smallCheckBox.IsChecked = false; largeCheckBox.IsChecked = false; }

        /// <summary>
        /// Large Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LargeSizeChecked(object sender, RoutedEventArgs e) { smallCheckBox.IsChecked = false; mediumCheckBox.IsChecked = false; }
            
        /// <summary>
        /// Cherry Flavor Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CherryFlavorChecked(object sender, RoutedEventArgs e) 
        { 
            blackberryCheckBox.IsChecked = false; 
            grapefruitCheckBox.IsChecked = false; 
            lemonCheckBox.IsChecked = false; 
            peachCheckBox.IsChecked = false; 
            watermelonCheckBox.IsChecked = false; 
        }

        /// <summary>
        /// Blackberry Flavor Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BlackberryFlavorChecked(object sender, RoutedEventArgs e)
        {
            cherryCheckBox.IsChecked = false;
            grapefruitCheckBox.IsChecked = false;
            lemonCheckBox.IsChecked = false;
            peachCheckBox.IsChecked = false;
            watermelonCheckBox.IsChecked = false;
        }

        /// <summary>
        /// Grapefruit Flavor Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GrapefruitFlavorChecked(object sender, RoutedEventArgs e)
        {
            blackberryCheckBox.IsChecked = false;
            cherryCheckBox.IsChecked = false;
            lemonCheckBox.IsChecked = false;
            peachCheckBox.IsChecked = false;
            watermelonCheckBox.IsChecked = false;
        }

        /// <summary>
        /// Lemon Flavor Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void LemonFlavorChecked(object sender, RoutedEventArgs e)
        {
            blackberryCheckBox.IsChecked = false;
            grapefruitCheckBox.IsChecked = false;
            cherryCheckBox.IsChecked = false;
            peachCheckBox.IsChecked = false;
            watermelonCheckBox.IsChecked = false;
        }

        /// <summary>
        /// Peach Flavor Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PeachFlavorChecked(object sender, RoutedEventArgs e)
        {
            blackberryCheckBox.IsChecked = false;
            grapefruitCheckBox.IsChecked = false;
            lemonCheckBox.IsChecked = false;
            cherryCheckBox.IsChecked = false;
            watermelonCheckBox.IsChecked = false;
        }

        /// <summary>
        /// Watermelon Flavor Check Box Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WatermelonFlavorChecked(object sender, RoutedEventArgs e)
        {
            blackberryCheckBox.IsChecked = false;
            grapefruitCheckBox.IsChecked = false;
            lemonCheckBox.IsChecked = false;
            peachCheckBox.IsChecked = false;
            cherryCheckBox.IsChecked = false;
        }

    }
}
