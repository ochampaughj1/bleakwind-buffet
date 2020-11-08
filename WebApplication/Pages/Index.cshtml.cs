using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
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
            this.SearchTerms = SearchTerms;
            this.Types = Types;
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByType(MenuItems, Types);
            MenuItems = Menu.FilterByCalories(MenuItems, CalorieMin, CalorieMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
