/* Author: Jonathan Ochampaugh
 * Class: Menu.cs
 * Purpose: A class with methods showing the menu.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class with methods showing the menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// All entrees on the menu.
        /// </summary>
        /// <returns>IEnumerable<IOrderItem> of all entrees on the menu.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// All sides on the menu.
        /// </summary>
        /// <returns>IEnumerable<IOrderItem> of all sides on the menu.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries() { Size = size});
                sides.Add(new FriedMiraak() { Size = size });
                sides.Add(new MadOtarGrits() { Size = size });
                sides.Add(new VokunSalad() { Size = size });
            }
            return sides;
        }

        /// <summary>
        /// All drinks on the menu.
        /// </summary>
        /// <returns>IEnumerable<IOrderItem> of all drinks on the menu.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice() { Size = size });
                drinks.Add(new CandlehearthCoffee() { Size = size });
                drinks.Add(new MarkarthMilk() { Size = size });
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Size = size, Flavor = flavor });
                }
                drinks.Add(new WarriorWater() { Size = size });
            }
            return drinks;
        }

        /// <summary>
        /// All items on the menu.
        /// </summary>
        /// <returns>IEnumerable<IOrderItem> of all items on the menu.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Drinks());
            return fullMenu;
        }
    }
}
