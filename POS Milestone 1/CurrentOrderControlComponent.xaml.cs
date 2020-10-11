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
        private MenuSelect menu;

        public CurrentOrderControlComponent(MenuSelect m)
        {
            InitializeComponent();
            menu = m;
        }

        void DeleteItemFromOrder(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var itemBeingRemoved = (IOrderItem)currentOrder.SelectedItem;
                order.Remove(itemBeingRemoved);
            }
        }

        private void EditExistingItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                var currentItem = ((Button)sender).DataContext;
                if(currentItem is BriarheartBurger bb) menu.orderBorder.Child = new CustomizeBriarheartBurger(menu, bb, order);
                else if (currentItem is DoubleDraugr dd) menu.orderBorder.Child = new CustomizeDoubleDraugr(menu, dd, order);
                else if (currentItem is GardenOrcOmelette goo) menu.orderBorder.Child = new CustomizeGardenOrcOmelette(menu, goo, order);
                else if (currentItem is PhillyPoacher php) menu.orderBorder.Child = new CustomizePhillyPoacher(menu, php, order);
                else if (currentItem is SmokehouseSkeleton sks) menu.orderBorder.Child = new CustomizeSmokehouseSkeleton(menu, sks, order);
                else if (currentItem is ThalmorTriple tt) menu.orderBorder.Child = new CustomizeThalmorTriple(menu, tt, order);
                else if (currentItem is ThugsTBone ttb) menu.orderBorder.Child = new CustomizeThugsTBone(menu, ttb, order);
                else if (currentItem is AretinoAppleJuice aj) menu.orderBorder.Child = new CustomizeAretinoAppleJuice(menu, aj, order);
                else if (currentItem is CandlehearthCoffee chc) menu.orderBorder.Child = new CustomizeCandlehearthCoffee(menu, chc, order);
                else if (currentItem is MarkarthMilk mm) menu.orderBorder.Child = new CustomizeMarkarthMilk(menu, mm, order);
                else if (currentItem is SailorSoda ss) menu.orderBorder.Child = new CustomizeSailorSoda(menu, ss, order);
                else if (currentItem is WarriorWater ww) menu.orderBorder.Child = new CustomizeWarriorWater(menu, ww, order);
                else if (currentItem is DragonbornWaffleFries dwf) menu.orderBorder.Child = new CustomizeDragonbornWaffleFries(menu, dwf, order);
                else if (currentItem is FriedMiraak fm) menu.orderBorder.Child = new CustomizeFriedMiraak(menu, fm, order);
                else if (currentItem is MadOtarGrits mog) menu.orderBorder.Child = new CustomizeMadOtarGrits(menu, mog, order);
                else if (currentItem is VokunSalad vs) menu.orderBorder.Child = new CustomizeVokunSalad(menu, vs, order);
            }
        }
    }
}
