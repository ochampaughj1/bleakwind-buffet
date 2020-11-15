/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }

        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(m);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.False(m.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.Equal(Size.Small, m.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = true;
            Assert.True(m.Ice);
            m.Ice = false;
            Assert.False(m.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(cal, m.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            var m = new MarkarthMilk();
            if (size == Size.Small) { m.Size = Size.Medium; }
            Assert.PropertyChanged(m, "Size", () =>
            {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            var m = new MarkarthMilk();
            if (size == Size.Small) { m.Size = Size.Medium; }
            Assert.PropertyChanged(m, "Price", () =>
            {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            var m = new MarkarthMilk();
            if (size == Size.Small) { m.Size = Size.Medium; }
            Assert.PropertyChanged(m, "Calories", () =>
            {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", m.SpecialInstructions);
            else Assert.Empty(m.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectNameBasedOnSize(Size size, string name)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(name, m.Name);
        }

        [Theory]
        [InlineData("Hormone-free organic 2% milk.")]
        public void ShouldReturnCorrectDescription(string description)
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(description, mm.Description);
        }
    }
}