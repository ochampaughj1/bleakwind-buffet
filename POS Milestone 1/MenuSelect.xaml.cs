using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.Drinks;
using POS_Milestone_1.Entrees;
using POS_Milestone_1.Sides;
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

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for MenuSelect.xaml
    /// </summary>
    public partial class MenuSelect : UserControl
    {
        public ButtonControlComponent menu = new ButtonControlComponent();

        public MenuSelect()
        {
            InitializeComponent();
            menu.SelectedItem += NewOrderClick;
            orderBorder.Child = menu;
        }

        void NewOrderClick(object sender, SelectionEventHandler e)
        {

            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entrees.Entree)))
            {
                if (e.item is BriarheartBurger) orderBorder.Child = new CustomizeBriarheartBurger(this);
                else if (e.item is DoubleDraugr) orderBorder.Child = new CustomizeDoubleDraugr(this);
                else if (e.item is GardenOrcOmelette) orderBorder.Child = new CustomizeGardenOrcOmelette(this);
                else if (e.item is PhillyPoacher) orderBorder.Child = new CustomizePhillyPoacher(this);
                else if (e.item is SmokehouseSkeleton) orderBorder.Child = new CustomizeSmokehouseSkeleton(this);
                else if (e.item is ThalmorTriple) orderBorder.Child = new CustomizeThalmorTriple(this);
                else if (e.item is ThugsTBone) orderBorder.Child = new CustomizeThugsTBone(this);
            }
            else if(e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
            {
                if (e.item is AretinoAppleJuice) orderBorder.Child = new CustomizeAretinoAppleJuice(this);
                else if (e.item is CandlehearthCoffee) orderBorder.Child = new CustomizeCandlehearthCoffee(this);
                else if (e.item is MarkarthMilk) orderBorder.Child = new CustomizeMarkarthMilk(this);
                else if (e.item is SailorSoda) orderBorder.Child = new CustomizeSailorSoda(this);
                else if (e.item is WarriorWater) orderBorder.Child = new CustomizeWarriorWater(this);
            }
            else if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Sides.Side)))
            {
                if (e.item is VokunSalad) orderBorder.Child = new CustomizeVokunSalad(this);
                else if (e.item is FriedMiraak) orderBorder.Child = new CustomizeFriedMiraak(this);
                else if (e.item is DragonbornWaffleFries) orderBorder.Child = new CustomizeDragonbornWaffleFries(this);
                else if (e.item is MadOtarGrits) orderBorder.Child = new CustomizeMadOtarGrits(this);
            }
        }
            



    }
}
