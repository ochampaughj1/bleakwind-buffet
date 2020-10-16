/*
 * Author: Jonathan Ochampaugh
 * Class: DrinkComboControlComponent.xaml.cs
 * Purpose: Controls manipulation of the drink in the current combo
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using POS_Milestone_1.Drinks;
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

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for DrinkComboControlComponent.xaml
    /// </summary>
    public partial class DrinkComboControlComponent : UserControl
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
        public DrinkComboControlComponent(MenuSelect m, Combo c, Order o)
        {
            InitializeComponent();
            DataContext = o;
            menu = m;
            combo = c;
        }

        /// <summary>
        /// Click Event for returning to the combo customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToComboClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menu.orderBorder.Child = new ComboControl(menu, combo, order);
            }
        }

        /// <summary>
        /// Click Event for switching the drink of the combo to Aretino Apple Juice and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                combo.Drink = aj;
                CustomizeAretinoAppleJuice temp = new CustomizeAretinoAppleJuice(menu, aj, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the drink of the combo to Candlehearth Coffee and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CandlehearthCoffee chc = new CandlehearthCoffee();
                combo.Drink = chc;
                CustomizeCandlehearthCoffee temp = new CustomizeCandlehearthCoffee(menu, chc, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp; 
            }
        }

        /// <summary>
        /// Click Event for switching the drink of the combo to Markarth Milk and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MarkarthMilk mm = new MarkarthMilk();
                combo.Drink = mm;
                CustomizeMarkarthMilk temp = new CustomizeMarkarthMilk(menu, mm, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the drink of the combo to Sailor Soda and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SailorSoda ss = new SailorSoda();
                combo.Drink = ss;
                CustomizeSailorSoda temp = new CustomizeSailorSoda(menu, ss, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the drink of the combo to Warrior Water and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                WarriorWater ww = new WarriorWater();
                combo.Drink = ww;
                CustomizeWarriorWater temp = new CustomizeWarriorWater(menu, ww, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }
    }
}
