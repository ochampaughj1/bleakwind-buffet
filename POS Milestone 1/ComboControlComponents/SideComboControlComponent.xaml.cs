/*
 * Author: Jonathan Ochampaugh
 * Class: SideComboControlComponent.xaml.cs
 * Purpose: Controls manipulation of the side in the current combo
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.Sides;

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for SideComboControlComponent.xaml
    /// </summary>
    public partial class SideComboControlComponent : UserControl
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
        public SideComboControlComponent(MenuSelect m, Combo c, Order o)
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
        /// Click Event for switching the side of the combo to Dragonborn Waffle Fries and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                combo.Side = dwf;
                CustomizeDragonbornWaffleFries temp = new CustomizeDragonbornWaffleFries(menu, dwf, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the side of the combo to Fried Miraak and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                FriedMiraak fm = new FriedMiraak();
                combo.Side = fm;
                CustomizeFriedMiraak temp = new CustomizeFriedMiraak(menu, fm, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the side of the combo to Mad Otar Grits and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MadOtarGrits mog = new MadOtarGrits();
                combo.Side = mog;
                CustomizeMadOtarGrits temp = new CustomizeMadOtarGrits(menu, mog, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the side of the combo to Vokun Salad and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VokunSalad vs = new VokunSalad();
                combo.Side = vs;
                CustomizeVokunSalad temp = new CustomizeVokunSalad(menu, vs, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }
    }
}
