﻿/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = false;
            });

            Assert.PropertyChanged(ss, "Ice", () =>
            {
                ss.Ice = true;
            });
        }

        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(s);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(Size.Small, s.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, s.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda s = new SailorSoda();
            s.Ice = true;
            Assert.True(s.Ice);
            s.Ice = false;
            Assert.False(s.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda s = new SailorSoda();
            s.Size = Size.Large;
            Assert.Equal(Size.Large, s.Size);
            s.Size = Size.Medium;
            Assert.Equal(Size.Medium, s.Size);
            s.Size = Size.Small;
            Assert.Equal(Size.Small, s.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, s.Flavor);
            s.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, s.Flavor);
            s.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, s.Flavor);
            s.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, s.Flavor);
            s.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, s.Flavor);
            s.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, s.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda s = new SailorSoda();
            s.Size = size;
            Assert.Equal(price, s.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda s = new SailorSoda();
            s.Size = size;
            Assert.Equal(cal, s.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda s = new SailorSoda();
            s.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", s.SpecialInstructions);
            else Assert.Empty(s.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            var ss = new SailorSoda();
            if(size == Size.Small) { ss.Size = Size.Medium; }
            Assert.PropertyChanged(ss, "Size", () =>
            {
                ss.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            var ss = new SailorSoda();
            if (size == Size.Small) { ss.Size = Size.Medium; }
            Assert.PropertyChanged(ss, "Price", () =>
            {
                ss.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            var ss = new SailorSoda();
            if (size == Size.Small) { ss.Size = Size.Medium; }
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = size;
            });
        }

        [Theory]
        [InlineData(SodaFlavor.Blackberry)]
        [InlineData(SodaFlavor.Cherry)]
        [InlineData(SodaFlavor.Grapefruit)]
        [InlineData(SodaFlavor.Lemon)]
        [InlineData(SodaFlavor.Peach)]
        [InlineData(SodaFlavor.Watermelon)]
        public void ChangingFlavorShouldNotifySodaFlavorProperty(SodaFlavor flavor)
        {
            var ss = new SailorSoda();
            if(flavor == SodaFlavor.Cherry) { ss.Flavor = SodaFlavor.Blackberry; }
            Assert.PropertyChanged(ss, "Flavor", () =>
            {
                ss.Flavor = flavor;
            });
        }


        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = flavor;
            s.Size = size;
            Assert.Equal(name, s.ToString());
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectNameBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = flavor;
            s.Size = size;
            Assert.Equal(name, s.Name);
        }

        [Theory]
        [InlineData("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.")]
        public void ShouldReturnCorrectDescription(string description)
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(description, ss.Description);
        }
    }
}