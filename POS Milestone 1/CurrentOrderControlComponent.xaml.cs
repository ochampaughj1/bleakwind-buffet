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
        /// Click event to complete the order and move to the payment screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrderClick(object sender, RoutedEventArgs e)
        {
            menu.orderBorder.Child = new PaymentOptionsScreen(menu, this);
        }

        /// <summary>
        /// Click Event to create a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrderClick(object sender, RoutedEventArgs e)
        {
            this.CompleteOrderButton.IsEnabled = true;
            if (DataContext is Order order)
            {
                order.Clear();
                menu.orderBorder.Child = new ButtonControlComponent(menu);
            }
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (parent != null && !(parent is MainWindow));
            ((MainWindow)parent).DataContext = new Order();
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

                if (currentItem is BriarheartBurger bb)
                {
                    CustomizeBriarheartBurger screen = new CustomizeBriarheartBurger(menu, bb, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }

                else if (currentItem is DoubleDraugr dd)
                {
                    CustomizeDoubleDraugr screen = new CustomizeDoubleDraugr(menu, dd, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is GardenOrcOmelette goo)
                {
                    CustomizeGardenOrcOmelette screen = new CustomizeGardenOrcOmelette(menu, goo, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is PhillyPoacher php)
                {
                    CustomizePhillyPoacher screen = new CustomizePhillyPoacher(menu, php, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is SmokehouseSkeleton sks)
                {
                    CustomizeSmokehouseSkeleton screen = new CustomizeSmokehouseSkeleton(menu, sks, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is ThalmorTriple tt)
                {
                    CustomizeThalmorTriple screen = new CustomizeThalmorTriple(menu, tt, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }

                else if (currentItem is ThugsTBone ttb)
                {
                    CustomizeThugsTBone screen = new CustomizeThugsTBone(menu, ttb, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is AretinoAppleJuice aj)
                {
                    CustomizeAretinoAppleJuice screen = new CustomizeAretinoAppleJuice(menu, aj, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is CandlehearthCoffee chc)
                {
                    CustomizeCandlehearthCoffee screen = new CustomizeCandlehearthCoffee(menu, chc, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is MarkarthMilk mm)
                {
                    CustomizeMarkarthMilk screen = new CustomizeMarkarthMilk(menu, mm, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is SailorSoda ss)
                {
                    CustomizeSailorSoda screen = new CustomizeSailorSoda(menu, ss, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is WarriorWater ww)
                {
                    CustomizeWarriorWater screen = new CustomizeWarriorWater(menu, ww, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is DragonbornWaffleFries dwf)
                {
                    CustomizeDragonbornWaffleFries screen = new CustomizeDragonbornWaffleFries(menu, dwf, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is FriedMiraak fm)
                {
                    CustomizeFriedMiraak screen = new CustomizeFriedMiraak(menu, fm, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is MadOtarGrits mog)
                {
                    CustomizeMadOtarGrits screen = new CustomizeMadOtarGrits(menu, mog, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }
                else if (currentItem is VokunSalad vs)
                {
                    CustomizeVokunSalad screen = new CustomizeVokunSalad(menu, vs, order, temp);
                    screen.returnToOrderbutton.IsEnabled = false;
                    menu.orderBorder.Child = screen;
                }

                //Combo
                else if (currentItem is Combo c) menu.orderBorder.Child = new ComboControl(menu, c, order);
            }
            
        }
    }
}
