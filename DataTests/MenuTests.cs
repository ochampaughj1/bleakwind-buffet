﻿/*
 * Author: Jonathan Ochampaugh
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldContainEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsTBone; });
        }

        [Fact]
        public void ShouldContainDrinks()
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
        }

        [Fact]
        public void ShouldContainASide()
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });
        }

        [Fact]
        public void ShouldContainFullMenu()
        {
            Assert.Contains(Menu.Sides(), (item) => { return item is Side; });
            Assert.Contains(Menu.Drinks(), (item) => { return item is Drink; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is Entree; });
        }
}
