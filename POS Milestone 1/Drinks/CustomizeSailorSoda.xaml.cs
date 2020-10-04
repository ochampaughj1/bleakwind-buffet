/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeSailorSoda.cs
 * Purpose: Switches between screens based on buttons clicked
 */
using BleakwindBuffet.Data.Drinks;
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

using Size = BleakwindBuffet.Data.Enums.Size;
using Flavor = BleakwindBuffet.Data.Enums.SodaFlavor;

namespace POS_Milestone_1.Drinks
{
    /// <summary>
    /// Interaction logic for CustomizeSailorSoda.xaml
    /// </summary>
    public partial class CustomizeSailorSoda : UserControl
    {
        /// <summary>
        /// Temporary object made available to help change the size
        /// </summary>
        SailorSoda temp;

        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeSailorSoda(MenuSelect menuItem, SailorSoda ss)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = ss;
            ss = temp;
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
        /// Check box event handler to make sure only one size is checked at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sizeCheckBoxChecked(object sender, RoutedEventArgs e)
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
                temp.Size = s;
            }
        }

        /// <summary>
        /// Check box event handler to make sure only one flavor is checked at a time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flavorCheckboxChecked(object sender, RoutedEventArgs e)
        {
            Flavor f;
            if (sender is CheckBox cb)
            {
                switch (cb.Name)
                {
                    case "blackberryCheckBox":
                        blackberryCheckBox.IsChecked = true;
                        cherryCheckBox.IsChecked = false;
                        grapefruitCheckBox.IsChecked = false;
                        lemonCheckBox.IsChecked = false;
                        peachCheckBox.IsChecked = false;
                        watermelonCheckBox.IsChecked = false;
                        f = Flavor.Blackberry;
                        break;

                    case "cherryCheckBox":
                        blackberryCheckBox.IsChecked = false;
                        cherryCheckBox.IsChecked = true;
                        grapefruitCheckBox.IsChecked = false;
                        lemonCheckBox.IsChecked = false;
                        peachCheckBox.IsChecked = false;
                        watermelonCheckBox.IsChecked = false;
                        f = Flavor.Cherry;
                        break;

                    case "grapefruitCheckBox":
                        blackberryCheckBox.IsChecked = false;
                        cherryCheckBox.IsChecked = false;
                        grapefruitCheckBox.IsChecked = true;
                        lemonCheckBox.IsChecked = false;
                        peachCheckBox.IsChecked = false;
                        watermelonCheckBox.IsChecked = false;
                        f = Flavor.Grapefruit;
                        break;

                    case "lemonCheckBox":
                        blackberryCheckBox.IsChecked = false;
                        cherryCheckBox.IsChecked = false;
                        grapefruitCheckBox.IsChecked = false;
                        lemonCheckBox.IsChecked = true;
                        peachCheckBox.IsChecked = false;
                        watermelonCheckBox.IsChecked = false;
                        f = Flavor.Lemon;
                        break;

                    case "peachCheckBox":
                        blackberryCheckBox.IsChecked = false;
                        cherryCheckBox.IsChecked = false;
                        grapefruitCheckBox.IsChecked = false;
                        lemonCheckBox.IsChecked = false;
                        peachCheckBox.IsChecked = true;
                        watermelonCheckBox.IsChecked = false;
                        f = Flavor.Peach;
                        break;

                    case "watermelonCheckBox":
                        blackberryCheckBox.IsChecked = false;
                        cherryCheckBox.IsChecked = false;
                        grapefruitCheckBox.IsChecked = false;
                        lemonCheckBox.IsChecked = false;
                        peachCheckBox.IsChecked = false;
                        watermelonCheckBox.IsChecked = true;
                        f = Flavor.Watermelon;
                        break;

                    default:
                        throw new NotImplementedException();
                }
                temp.Flavor = f;
            }
        }
    }
}
