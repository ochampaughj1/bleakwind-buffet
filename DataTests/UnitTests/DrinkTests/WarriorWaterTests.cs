/*
 * Author: Jonathan Ochamapugh
 * Class: WarriorWater.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using System;

using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.Equal(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater w = new WarriorWater();
            w.Ice = true;
            Assert.True(w.Ice);
            w.Ice = false;
            Assert.False(w.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater w = new WarriorWater();
            w.Lemon = true;
            Assert.True(w.Lemon);
            w.Lemon = false;
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater w = new WarriorWater();
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
            w.Size = Size.Small;
            Assert.Equal(Size.Small, w.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(price, w.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(cal, w.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = size;
            });
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater w = new WarriorWater();
            w.Ice = includeIce;
            w.Lemon = includeLemon;

            if (!includeIce && includeLemon)
            {
                Assert.Contains("Hold ice", w.SpecialInstructions);
                Assert.Contains("Add lemon", w.SpecialInstructions);
            }
            else if (!includeIce && !includeLemon)
            {
                Assert.Contains("Hold ice", w.SpecialInstructions);
            }
            else if (includeLemon && includeIce)
            {
                Assert.Contains("Add lemon", w.SpecialInstructions);
            }
            else Assert.Empty(w.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(name, w.ToString());
        }
    }
}
