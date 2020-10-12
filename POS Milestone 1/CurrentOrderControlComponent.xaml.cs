/* Author: Jonathan Ochampaugh
 * Class Name: CurrentOrderControlComponent.cs
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.ComboControlComponents;
using POS_Milestone_1.Drinks;
using POS_Milestone_1.Entrees;
using POS_Milestone_1.Sides;

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for CurrentOrderControlComponent.xaml
    /// </summary>
    public partial class CurrentOrderControlComponent : UserControl
    {
        /// <summary>
        /// Backing variable for MenuSelect item
        /// </summary>
        private MenuSelect menu;

        /// <summary>
        /// Initializes MenuSelect 
        /// </summary>
        /// <param name="m">MenuSelect item to access MenuSelect borders</param>
        public CurrentOrderControlComponent(MenuSelect m)
        {
            InitializeComponent();
            menu = m;
        }

        /// <summary>
        /// Click event to delete an item from the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DeleteItemFromOrder(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var itemBeingRemoved = (IOrderItem)currentOrder.SelectedItem;
                order.Remove(itemBeingRemoved);
            }
        }

        /// <summary>
        /// Click event to edit an existing item in the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditExistingItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                Combo temp = new Combo(null, null, null);
                var currentItem = ((Button)sender).DataContext;
                if (currentItem is BriarheartBurger bb) menu.orderBorder.Child = new CustomizeBriarheartBurger(menu, bb, order, temp);
                else if (currentItem is DoubleDraugr dd) menu.orderBorder.Child = new CustomizeDoubleDraugr(menu, dd, order, temp);
                else if (currentItem is GardenOrcOmelette goo) menu.orderBorder.Child = new CustomizeGardenOrcOmelette(menu, goo, order, temp);
                else if (currentItem is PhillyPoacher php) menu.orderBorder.Child = new CustomizePhillyPoacher(menu, php, order, temp);
                else if (currentItem is SmokehouseSkeleton sks) menu.orderBorder.Child = new CustomizeSmokehouseSkeleton(menu, sks, order, temp);
                else if (currentItem is ThalmorTriple tt) menu.orderBorder.Child = new CustomizeThalmorTriple(menu, tt, order, temp);
                else if (currentItem is ThugsTBone ttb) menu.orderBorder.Child = new CustomizeThugsTBone(menu, ttb, order, temp);
                else if (currentItem is AretinoAppleJuice aj) menu.orderBorder.Child = new CustomizeAretinoAppleJuice(menu, aj, order, temp);
                else if (currentItem is CandlehearthCoffee chc) menu.orderBorder.Child = new CustomizeCandlehearthCoffee(menu, chc, order, temp);
                else if (currentItem is MarkarthMilk mm) menu.orderBorder.Child = new CustomizeMarkarthMilk(menu, mm, order, temp);
                else if (currentItem is SailorSoda ss) menu.orderBorder.Child = new CustomizeSailorSoda(menu, ss, order, temp);
                else if (currentItem is WarriorWater ww) menu.orderBorder.Child = new CustomizeWarriorWater(menu, ww, order, temp);
                else if (currentItem is DragonbornWaffleFries dwf) menu.orderBorder.Child = new CustomizeDragonbornWaffleFries(menu, dwf, order, temp);
                else if (currentItem is FriedMiraak fm) menu.orderBorder.Child = new CustomizeFriedMiraak(menu, fm, order, temp);
                else if (currentItem is MadOtarGrits mog) menu.orderBorder.Child = new CustomizeMadOtarGrits(menu, mog, order, temp);
                else if (currentItem is VokunSalad vs) menu.orderBorder.Child = new CustomizeVokunSalad(menu, vs, order, temp);

                //Combo
                else if (currentItem is Combo c) menu.orderBorder.Child = new ComboControl(menu, c, order);
            }
            
        }
    }
}
