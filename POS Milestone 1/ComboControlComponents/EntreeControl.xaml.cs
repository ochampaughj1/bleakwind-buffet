/*
 * Author: Jonathan Ochampaugh
 * Class: EntreeControl.xaml.cs
 * Purpose: Controls manipulation of the entree in the current combo
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.Entrees;
using POS_Milestone_1.Sides;

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for EntreeControl.xaml
    /// </summary>
    public partial class EntreeControl : UserControl
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
        public EntreeControl(MenuSelect m, Combo c, Order o)
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
            if(DataContext is Order order)
            {
                menu.orderBorder.Child = new ComboControl(menu, combo, order);
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Briarheart Burger and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                BriarheartBurger bb = new BriarheartBurger();
                combo.Entree = bb;
                CustomizeBriarheartBurger temp = new CustomizeBriarheartBurger(menu, bb, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Double Draugr and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DoubleDraugr dd = new DoubleDraugr();
                combo.Entree = dd;
                CustomizeDoubleDraugr temp = new CustomizeDoubleDraugr(menu, dd, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Garden Orc Omelette and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                GardenOrcOmelette goo = new GardenOrcOmelette();
                combo.Entree = goo;
                CustomizeGardenOrcOmelette temp = new CustomizeGardenOrcOmelette(menu, goo, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Philly Poacher and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PhillyPoacher php = new PhillyPoacher();
                combo.Entree = php;
                CustomizePhillyPoacher temp = new CustomizePhillyPoacher(menu, php, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Smokehouse Skeleton and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SmokehouseSkeleton sks = new SmokehouseSkeleton();
                combo.Entree = sks;
                CustomizeSmokehouseSkeleton temp = new CustomizeSmokehouseSkeleton(menu, sks, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Thalmor Triple and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                ThalmorTriple tt = new ThalmorTriple();
                combo.Entree = tt;
                CustomizeThalmorTriple temp = new CustomizeThalmorTriple(menu, tt, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }

        /// <summary>
        /// Click Event for switching the entree of the combo to Thugs TBone and switches to its customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                ThugsTBone ttb = new ThugsTBone();
                combo.Entree = ttb;
                CustomizeThugsTBone temp = new CustomizeThugsTBone(menu, ttb, order, combo);
                temp.doneButton.IsEnabled = false;
                temp.cancelButton.IsEnabled = false;
                menu.orderBorder.Child = temp;
            }
        }
        

    }
}
