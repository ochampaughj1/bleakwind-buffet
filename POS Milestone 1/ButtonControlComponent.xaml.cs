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
        public event EventHandler<SelectionEventHandler> SelectedItem;

        public ButtonControlComponent()
        {
            InitializeComponent();
        }

        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = bb });
        }
        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = dd });
        }
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = goo });
        }
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = pp });
        }
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton sks = new SmokehouseSkeleton();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = sks });
        }
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = tt });
        }
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = ttb });
        }

        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = aj });
        }

        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = chc });
        }

        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = mm });
        }

        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = ss });
        }

        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = ww });
        }

        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = vs });
        }

        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fmc = new FriedMiraak();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = fmc });
        }

        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = dwf });
        }

        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            SelectedItem?.Invoke(this, new SelectionEventHandler() { item = mog });
        }
    }
}
