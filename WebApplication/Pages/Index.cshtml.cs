using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// Collection of IOrderItem menu items
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; }

        /// <summary>
        /// Filtered Search Terms
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Filtered menu item types
        /// </summary>
        public string[] Types { get; set; }

        /// <summary>
        /// Filtered calorie min
        /// </summary>
        public int? CalorieMin { get; set; }

        /// <summary>
        /// Filtered calorie max
        /// </summary>
        public int? CalorieMax { get; set; }

        /// <summary>
        /// Filtered price min
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Filtered price max
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets the search results for the display on the page
        /// </summary>
        public void OnGet(string SearchTerms, string[] Types, int? CalorieMin, int? CalorieMax, double? PriceMin, double? PriceMax)
        {
            MenuItems = Menu.All;
            this.SearchTerms = SearchTerms;
            this.Types = Types;
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            //Search Menu Items for the Search Terms
            if (SearchTerms != null)
            {
                IEnumerable<IOrderItem> searchResults = new List<IOrderItem>();
                List<IOrderItem> prop = new List<IOrderItem>();
                string[] temp = SearchTerms.Split(" ");
                
                foreach (string s in temp)
                {
                    searchResults = MenuItems.Where(item => item.ToString() != null && item.ToString().Contains(s, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(s, StringComparison.InvariantCultureIgnoreCase));
                    prop.AddRange(searchResults.ToList());
                }
                MenuItems = prop;
            }

            //Filter by Menu Item Type
            if (Types != null && Types.Length != 0)
            {
                MenuItems = MenuItems.Where(item => (item is Entree && Types.Contains("Entrees"))
                || (item is Drink && Types.Contains("Drinks")) || (item is Side && Types.Contains("Sides")));
            }
            
            //Filter by Calories
            if(CalorieMin != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories >= CalorieMin);
            }
            if(CalorieMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories <= CalorieMax);
            }
            if(CalorieMax != null && CalorieMin != null)
            {
                MenuItems = MenuItems.Where(item => item.Calories <= CalorieMax && item.Calories >= CalorieMin);
            }

            //Filter by Price
            if (PriceMin != null)
            {
                MenuItems = MenuItems.Where(item => item.Price >= PriceMin);
            }
            if (PriceMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Price <= PriceMax);
            }
            if (PriceMin != null && PriceMax != null)
            {
                MenuItems = MenuItems.Where(item => item.Price <= PriceMax && item.Price >= PriceMin);
            }
            
            //PREVIOUS FILTERS
            //MenuItems = Menu.Search(SearchTerms);
            //MenuItems = Menu.FilterByType(MenuItems, Types);
            //MenuItems = Menu.FilterByCalories(MenuItems, CalorieMin, CalorieMax);
            //MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
