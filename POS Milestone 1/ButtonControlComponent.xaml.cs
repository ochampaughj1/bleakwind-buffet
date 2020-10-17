/* Author: Jonathan Ochampaugh
 * Class Name: ButtonOrderControlComponent.cs
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
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.ComboControlComponents;
using POS_Milestone_1.Drinks;
using POS_Milestone_1.Entrees;
using POS_Milestone_1.Sides;

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for ButtonControlComponent.xaml
    /// </summary>
    public partial class ButtonControlComponent : UserControl
    {
        /// <summary>
        /// Backing variable for MenuSelect 
        /// </summary>
        private MenuSelect menu;

        /// <summary>
        /// Initializes MenuSelect item
        /// </summary>
        /// <param name="m">MenuSelect item to access MenuSelects borders</param>
        public ButtonControlComponent(MenuSelect m)
        {
            InitializeComponent();
            menu = m;
        }


        /// <summary>
        /// Click event to add a combo to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddComboToOrderClick(object sender, RoutedEventArgs e)
        {
            Combo combo = new Combo(new BriarheartBurger(), new SailorSoda(), new DragonbornWaffleFries());
            if(DataContext is Order order)
            {
                order.Add(combo);
                menu.orderBorder.Child = new ComboControl(menu, combo, order);
            }
        }

        /// <summary>
        /// Click event to add a Briarheart Burger to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo temp = new Combo(null, null, null);
            if(DataContext is Order order)
            {
                order.Add(bb);
                CustomizeBriarheartBurger newScreen = new CustomizeBriarheartBurger(menu, bb, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Double Draugr to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(dd);
                CustomizeDoubleDraugr newScreen = new CustomizeDoubleDraugr(menu, dd, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Garden Orc Omelette to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(goo);
                CustomizeGardenOrcOmelette newScreen = new CustomizeGardenOrcOmelette(menu, goo, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Philly Poacher to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(pp);
                CustomizePhillyPoacher newScreen = new CustomizePhillyPoacher(menu, pp, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Smokehouse Skeleton to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton sks = new SmokehouseSkeleton();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(sks);
                CustomizeSmokehouseSkeleton newScreen = new CustomizeSmokehouseSkeleton(menu, sks, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Thalmor Triple to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(tt);
                CustomizeThalmorTriple newScreen = new CustomizeThalmorTriple(menu, tt, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Thugs TBone to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(ttb);
                CustomizeThugsTBone newScreen = new CustomizeThugsTBone(menu, ttb, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Aretino Apple Juice to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(aj);
                CustomizeAretinoAppleJuice newScreen = new CustomizeAretinoAppleJuice(menu, aj, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Candlehearth Coffee to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(chc);
                CustomizeCandlehearthCoffee newScreen = new CustomizeCandlehearthCoffee(menu, chc, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Markarth Milk to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(mm);
                CustomizeMarkarthMilk newScreen = new CustomizeMarkarthMilk(menu, mm, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;

            }
        }

        /// <summary>
        /// Click event to add a Sailor Soda to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(ss);
                CustomizeSailorSoda newScreen = new CustomizeSailorSoda(menu, ss, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Warrior Water to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(ww);
                CustomizeWarriorWater newScreen = new CustomizeWarriorWater(menu, ww, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Vokun Salad to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(vs);
                CustomizeVokunSalad newScreen = new CustomizeVokunSalad(menu, vs, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Fried Miraak to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fmc = new FriedMiraak();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(fmc);
                CustomizeFriedMiraak newScreen = new CustomizeFriedMiraak(menu, fmc, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Dragonborn Waffle Fries to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(dwf);
                CustomizeDragonbornWaffleFries newScreen = new CustomizeDragonbornWaffleFries(menu, dwf, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }

        /// <summary>
        /// Click event to add a Mad Otar Grits to the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            Combo temp = new Combo(null, null, null);
            if (DataContext is Order order)
            {
                order.Add(mog);
                CustomizeMadOtarGrits newScreen = new CustomizeMadOtarGrits(menu, mog, order, temp);
                newScreen.returnToOrderbutton.IsEnabled = false;
                menu.orderBorder.Child = newScreen;
            }
        }
    }
}
