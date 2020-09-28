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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for ButtonControlComponent.xaml
    /// </summary>
    public partial class ButtonControlComponent : UserControl
    {
        /// <summary>
        /// Event handler for selected items
        /// </summary>
        public event EventHandler<SelectionEventHandler> SelectedItem;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public ButtonControlComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Briarheart Burger Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = bb });
        }

        /// <summary>
        /// Double Draugr Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = dd });
        }

        /// <summary>
        /// GardenOrcOmelette Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = goo });
        }

        /// <summary>
        /// Philly Poacher Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = pp });
        }

        /// <summary>
        /// Smokehouse Skeleton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton sks = new SmokehouseSkeleton();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = sks });
        }

        /// <summary>
        /// Thalmor Triple Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = tt });
        }

        /// <summary>
        /// Thugs T-Bone Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = ttb });
        }

        /// <summary>
        /// Aretino Apple Juice Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = aj });
        }

        /// <summary>
        /// Candlehearth Coffee Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = chc });
        }

        /// <summary>
        /// Markarth Milk Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = mm });
        }

        /// <summary>
        /// Sailor Soda Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = ss });
        }

        /// <summary>
        /// Warrior Water Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = ww });
        }

        /// <summary>
        /// Vokun Salad Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = vs });
        }

        /// <summary>
        /// Fried Miraak Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fmc = new FriedMiraak();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = fmc });
        }

        /// <summary>
        /// Dragonborn Waffle Fries Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = dwf });
        }

        /// <summary>
        /// Mad Otar Grits Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = mog });
        }
    }
}
