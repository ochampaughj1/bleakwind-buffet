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
        /// PrivMenuSelect item 
        /// </summary>
        private MenuSelect menu;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public ButtonControlComponent(MenuSelect m)
        {
            InitializeComponent();
            menu = m;
        }

        /// <summary>
        /// Creates a new order and sets the data context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NewOrderClick(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (parent != null && !(parent is MainWindow)) ;
            ((MainWindow)parent).DataContext = new Order();
        }

        /// <summary>
        /// Briarheart Burger Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            if(DataContext is Order temp)
            {
                temp.Add(bb);
                menu.orderBorder.Child = new CustomizeBriarheartBurger(menu, bb, temp);
            }
        }

        /// <summary>
        /// Double Draugr Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            if (DataContext is Order temp)
            {
                temp.Add(dd);
                menu.orderBorder.Child = new CustomizeDoubleDraugr(menu, dd, temp);
            }
        }

        /// <summary>
        /// GardenOrcOmelette Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            if (DataContext is Order temp)
            {
                temp.Add(goo);
                menu.orderBorder.Child = new CustomizeGardenOrcOmelette(menu, goo, temp);
            }
        }

        /// <summary>
        /// Philly Poacher Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            if (DataContext is Order temp)
            {
                temp.Add(pp);
                menu.orderBorder.Child = new CustomizePhillyPoacher(menu, pp, temp);
            }
        }

        /// <summary>
        /// Smokehouse Skeleton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton sks = new SmokehouseSkeleton();
            if (DataContext is Order temp)
            {
                temp.Add(sks);
                menu.orderBorder.Child = new CustomizeSmokehouseSkeleton(menu, sks, temp);
            }
        }

        /// <summary>
        /// Thalmor Triple Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            if (DataContext is Order temp)
            {
                temp.Add(tt);
                menu.orderBorder.Child = new CustomizeThalmorTriple(menu, tt, temp);
            }
        }

        /// <summary>
        /// Thugs T-Bone Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();
            if (DataContext is Order temp)
            {
                temp.Add(ttb);
                menu.orderBorder.Child = new CustomizeThugsTBone(menu, ttb, temp);
            }
        }

        /// <summary>
        /// Aretino Apple Juice Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            if (DataContext is Order temp)
            {
                temp.Add(aj);
                menu.orderBorder.Child = new CustomizeAretinoAppleJuice(menu, aj, temp);
            }
        }

        /// <summary>
        /// Candlehearth Coffee Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            if (DataContext is Order temp)
            {
                temp.Add(chc);
                menu.orderBorder.Child = new CustomizeCandlehearthCoffee(menu, chc, temp);
            }
        }

        /// <summary>
        /// Markarth Milk Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            if (DataContext is Order temp)
            {
                temp.Add(mm);
                menu.orderBorder.Child = new CustomizeMarkarthMilk(menu, mm, temp);
            }
        }

        /// <summary>
        /// Sailor Soda Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            if (DataContext is Order temp)
            {
                temp.Add(ss);
                menu.orderBorder.Child = new CustomizeSailorSoda(menu, ss, temp);
            }
        }

        /// <summary>
        /// Warrior Water Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            if (DataContext is Order temp)
            {
                temp.Add(ww);
                menu.orderBorder.Child = new CustomizeWarriorWater(menu, ww, temp);
            }
        }

        /// <summary>
        /// Vokun Salad Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            if (DataContext is Order temp)
            {
                temp.Add(vs);
                menu.orderBorder.Child = new CustomizeVokunSalad(menu, vs, temp);
            }
        }

        /// <summary>
        /// Fried Miraak Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fmc = new FriedMiraak();
            if (DataContext is Order temp)
            {
                temp.Add(fmc);
                menu.orderBorder.Child = new CustomizeFriedMiraak(menu, fmc, temp);
            }
        }

        /// <summary>
        /// Dragonborn Waffle Fries Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            if (DataContext is Order temp)
            {
                temp.Add(dwf);
                menu.orderBorder.Child = new CustomizeDragonbornWaffleFries(menu, dwf, temp);
            }
        }

        /// <summary>
        /// Mad Otar Grits Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            if (DataContext is Order temp)
            {
                temp.Add(mog);
                menu.orderBorder.Child = new CustomizeMadOtarGrits(menu, mog, temp);
            }
        }
    }
}
