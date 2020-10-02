/* Author: Jonathan Ochampaugh
 * Class Name: CustomizeVokunSalad.cs
 * Purpose: Switches between screens based on buttons clicked
 */

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

using Size = BleakwindBuffet.Data.Enums.Size;

namespace POS_Milestone_1.Sides
{
    /// <summary>
    /// Interaction logic for CustomizeVokunSalad.xaml
    /// </summary>
    public partial class CustomizeVokunSalad : UserControl
    {
        /// <summary>
        /// Temporary object made available to help change the size
        /// </summary>
        VokunSalad temp;

        /// <summary>
        /// New Menu Select instance
        /// </summary>
        private MenuSelect ms = new MenuSelect();

        /// <summary>
        /// Constuctor to initialize Menu Select item
        /// </summary>
        /// <param name="menuItem">Menu Item being passed into this class</param>
        public CustomizeVokunSalad(MenuSelect menuItem, VokunSalad vs)
        {
            InitializeComponent();
            ms = menuItem;
            DataContext = vs;
            vs = temp;
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
                temp.Size = s;
            }
        }
    }
}
