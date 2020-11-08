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
using System.Linq;

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
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new FriedMiraak() { Size = size });
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new MadOtarGrits() { Size = size });
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
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
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new CandlehearthCoffee() { Size = size });
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new MarkarthMilk() { Size = size });
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Size = size, Flavor = flavor });
                }
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
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

		/// <summary>
		/// Gets all the menu items in the menu
		/// </summary>
		public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }

		/// <summary>
		/// Searches the menu items in the menu for matches
		/// </summary>
		/// <param name="terms">The items to search for</param>
		/// <returns>The results of the search</returns>
		public static IEnumerable<IOrderItem> Search(string terms)
        {
			List<IOrderItem> results = new List<IOrderItem>();

			//null check
			if (terms == null) return All;

			
			foreach(IOrderItem item in All)
            {
				//Add the entree if the name matches
				if (item.ToString() != null && item.ToString().ToLower().Contains(terms.ToLower()))
                {
					results.Add(item);
                }
            }
			return results;
			
        }

		/// <summary>
		/// Filters the provided menu items by menu item types
		/// </summary>
		/// <param name="menu">The collection of menu items to filter</param>
		/// <param name="types">The types of menu items to include</param>
		/// <returns>A collection containing only movies that match the filter</returns>
		public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> menu, string[] types)
        {
			if (types == null || types.Count() == 0) return menu;

			List<IOrderItem> results = new List<IOrderItem>();
			if(types.Contains("Entrees"))
            {
				foreach(IOrderItem item in menu)
                {
					if(item is Entree)
                    {
						results.Add(item);
                    }
                }
            }
			if (types.Contains("Drinks"))
			{
				foreach (IOrderItem item in menu)
				{
					if (item is Drink)
					{
						results.Add(item);
					}
				}
			}
			if (types.Contains("Sides"))
			{
				foreach (IOrderItem item in menu)
				{
					if (item is Side)
					{
						results.Add(item);
					}
				}
			}
			return results;
		}

		/// <summary>
		/// Filters the provided collection of Menu Items to those with the Calories falling
		/// within the specified range.
		/// </summary>
		/// <param name="menu">The collection of menu items to filter</param>
		/// <param name="min">The minimum range value</param>
		/// <param name="max">The maximum range value</param>
		/// <returns>The filtered menu item collection</returns>
		public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
		{
			if (min == null && max == null) return menu;

			var results = new List<IOrderItem>();

			//only a maximum specified
			if (min == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Calories <= max) results.Add(item);
				}
				return results;
			}

			//only a minimum specified
			if (max == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Calories >= min) results.Add(item);
				}
				return results;
			}

			//Both minimum and maximum specified
			foreach (IOrderItem item in menu)
			{
				if (item.Calories >= min && item.Calories <= max)
				{
					results.Add(item);
				}
			}
			return results;
		}

		/// <summary>
		/// Filters the provided collection of Menu Items to those with the Prices falling
		/// within the specified range.
		/// </summary>
		/// <param name="menu">The collection of menu items to filter</param>
		/// <param name="min">The minimum range value</param>
		/// <param name="max">The maximum range value</param>
		/// <returns>The filtered menu item collection</returns>
		public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
		{
			if (min == null && max == null) return menu;

			var results = new List<IOrderItem>();

			//only a maximum specified
			if (min == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Price <= max) results.Add(item);
				}
				return results;
			}

			//only a minimum specified
			if (max == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Price >= min) results.Add(item);
				}
				return results;
			}

			//Both minimum and maximum specified
			foreach (IOrderItem item in menu)
			{
				if (item.Price >= min && item.Price <= max)
				{
					results.Add(item);
				}
			}
			return results;
		}

	}
}
