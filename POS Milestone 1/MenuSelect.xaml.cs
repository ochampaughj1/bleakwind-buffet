/* Author: Jonathan Ochampaugh
 * Class Name: MenuSelect.cs
 * Purpose: Switches between screens based on buttons clicked
 */

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
using BleakwindBuffet.Data;

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for MenuSelect.xaml
    /// </summary>
    public partial class MenuSelect : UserControl
    {
        /// <summary>
        /// Button Control Component variable
        /// </summary>
        private ButtonControlComponent menu;

        private CurrentOrderControlComponent receipt;

        /// <summary>
        /// Constuctor to initialize values and click events
        /// </summary>
        public MenuSelect()
        {
            InitializeComponent();
            menu = new ButtonControlComponent(this);
            receipt = new CurrentOrderControlComponent(this);
            orderBorder.Child = menu;
            currentOrderBorder.Child = receipt;
        }

        /// <summary>
        /// Click Event for a new order that switches the windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NewOrderClick(object sender, SelectionEventHandler e)
        {
            if(DataContext is Order order)
            {
                if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entrees.Entree)))
                {
                    if (e.item is BriarheartBurger) orderBorder.Child = new CustomizeBriarheartBurger(this, new BriarheartBurger(), order);
                    else if (e.item is DoubleDraugr) orderBorder.Child = new CustomizeDoubleDraugr(this, new DoubleDraugr(), order);
                    else if (e.item is GardenOrcOmelette) orderBorder.Child = new CustomizeGardenOrcOmelette(this, new GardenOrcOmelette(), order);
                    else if (e.item is PhillyPoacher) orderBorder.Child = new CustomizePhillyPoacher(this, new PhillyPoacher(), order);
                    else if (e.item is SmokehouseSkeleton) orderBorder.Child = new CustomizeSmokehouseSkeleton(this, new SmokehouseSkeleton(), order);
                    else if (e.item is ThalmorTriple) orderBorder.Child = new CustomizeThalmorTriple(this, new ThalmorTriple(), order);
                    else if (e.item is ThugsTBone) orderBorder.Child = new CustomizeThugsTBone(this, new ThugsTBone(), order);
                }
                else if(e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
                {
                    if (e.item is AretinoAppleJuice) orderBorder.Child = new CustomizeAretinoAppleJuice(this, new AretinoAppleJuice(), order);
                    else if (e.item is CandlehearthCoffee) orderBorder.Child = new CustomizeCandlehearthCoffee(this, new CandlehearthCoffee(), order);
                    else if (e.item is MarkarthMilk) orderBorder.Child = new CustomizeMarkarthMilk(this, new MarkarthMilk(), order);
                    else if (e.item is SailorSoda) orderBorder.Child = new CustomizeSailorSoda(this, new SailorSoda(), order);
                    else if (e.item is WarriorWater) orderBorder.Child = new CustomizeWarriorWater(this, new WarriorWater(), order);
                }
                else if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Sides.Side)))
                {
                    if (e.item is VokunSalad) orderBorder.Child = new CustomizeVokunSalad(this, new VokunSalad(), order);
                    else if (e.item is FriedMiraak) orderBorder.Child = new CustomizeFriedMiraak(this, new FriedMiraak(), order);
                    else if (e.item is DragonbornWaffleFries) orderBorder.Child = new CustomizeDragonbornWaffleFries(this, new DragonbornWaffleFries(), order);
                    else if (e.item is MadOtarGrits) orderBorder.Child = new CustomizeMadOtarGrits(this, new MadOtarGrits(), order);
                }
            }
            orderBorder.DataContext = e.item;
        }
            



    }
}
