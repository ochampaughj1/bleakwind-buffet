/*
 * Author: Jonathan Ochampaugh
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
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

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldReturnCorrectItemName()
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            mm.Size = Size.Large;
            fm.Size = Size.Medium;
            Combo c = new Combo(bb, mm, fm);
            Assert.Contains("Large Markarth Milk:", c.SpecialInstructions);
            Assert.Contains("Medium Fried Miraak:", c.SpecialInstructions);
            Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
        }

        [Fact]
        public void ShouldChangeEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combo combo = new Combo(bb, mm, fm);
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new DoubleDraugr();
            });
        }

        [Fact]
        public void ShouldChangeDrink()
        {
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combo combo = new Combo(bb, mm, fm);
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new SailorSoda();
            });
        }

        [Fact]
        public void ShouldChangeSide()
        {
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combo combo = new Combo(bb, mm, fm);
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void ShouldBeACombo()
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            fm.Size = Size.Medium;
            Combo c = new Combo(bb, mm, fm);
            Assert.IsAssignableFrom<Combo>(c);
        }

        [Fact]
        public void ShouldGetName()
        {
            Combo combo = new Combo(null, null, null);
            combo.ComboNumber = 1;
            string name = combo.Name;
            Assert.Equal(name, combo.Name);
        }

        [Fact]
        public void ShouldGetEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo combo = new Combo(bb, null, null);
            Assert.Equal(combo.Entree, bb);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldGetDrink(Size size)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Combo combo = new Combo(null, ss, null);
            Assert.Equal(combo.Drink, ss);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldGetSide(Size size)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Combo combo = new Combo(null, null, dwf);
            Assert.Equal(combo.Side, dwf);
        }

        [Theory]
        [InlineData(1)]
        public void ShouldChangeComboNumber(int count)
        {
            Combo combo = new Combo(null, null, null);
            Assert.Equal(count, combo.ComboNumber);
        }

        [Theory]
        [InlineData(Size.Large, 1142)]
        [InlineData(Size.Medium, 1051)]
        [InlineData(Size.Small, 950)]
        public void ShouldTotalWholeCombosCaloriesBasedOnSize(Size size, uint cal)
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            fm.Size = size;
            mm.Size = size;
            Combo c = new Combo(bb, mm, fm);
            Assert.Equal(cal, c.Calories);
        }

        [Theory]
        [InlineData(Size.Large, 9.42)]
        [InlineData(Size.Medium, 8.44)]
        [InlineData(Size.Small, 8.15)]
        public void ShouldGetTotalPriceOfComboBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            fm.Size = size;
            mm.Size = size;
            Combo c = new Combo(bb, mm, fm);
            Assert.Equal(price, Math.Round(c.Price, 2));
        }

        [Theory]
        [InlineData(true, Size.Small)]
        [InlineData(true, Size.Medium)]
        [InlineData(true, Size.Large)]
        [InlineData(false, Size.Small)]
        [InlineData(false, Size.Medium)]
        [InlineData(false, Size.Large)]
        public void ShouldGetSpecialInstructionsOfCombo(bool specialInstructions, Size size)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo c = new Combo(bb, aj, dwf);
            aj.Ice = specialInstructions;
            bb.Bun = specialInstructions;
            aj.Size = size;
            dwf.Size = size;
            if (specialInstructions && size == Size.Small)
            {
                Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
                Assert.Contains("Small Aretino Apple Juice:", c.SpecialInstructions);
                Assert.Contains("Small Dragonborn Waffle Fries:", c.SpecialInstructions);
                Assert.Contains("Add ice, ", c.SpecialInstructions);
            }
            else if (specialInstructions && size == Size.Medium)
            {
                Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
                Assert.Contains("Medium Aretino Apple Juice:", c.SpecialInstructions);
                Assert.Contains("Medium Dragonborn Waffle Fries:", c.SpecialInstructions);
                Assert.Contains("Add ice, ", c.SpecialInstructions);
            }
            else if (specialInstructions && size == Size.Large)
            {
                Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
                Assert.Contains("Large Aretino Apple Juice:", c.SpecialInstructions);
                Assert.Contains("Large Dragonborn Waffle Fries:", c.SpecialInstructions);
                Assert.Contains("Add ice, ", c.SpecialInstructions);
            }
            else if (!(specialInstructions) && size == Size.Small)
            {
                Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
                Assert.Contains("Small Aretino Apple Juice:", c.SpecialInstructions);
                Assert.Contains("Small Dragonborn Waffle Fries:", c.SpecialInstructions);
                Assert.Contains("Hold bun, ", c.SpecialInstructions);
            }
            else if (!(specialInstructions) && size == Size.Medium)
            {
                Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
                Assert.Contains("Medium Aretino Apple Juice:", c.SpecialInstructions);
                Assert.Contains("Medium Dragonborn Waffle Fries:", c.SpecialInstructions);
                Assert.Contains("Hold bun, ", c.SpecialInstructions);
            }
            else if (!(specialInstructions) && size == Size.Large)
            {
                Assert.Contains("Briarheart Burger:", c.SpecialInstructions);
                Assert.Contains("Large Aretino Apple Juice:", c.SpecialInstructions);
                Assert.Contains("Large Dragonborn Waffle Fries:", c.SpecialInstructions);
                Assert.Contains("Hold bun, ", c.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData("")]
        public void ShouldReturnCorrectDescription(string description)
        {
            FriedMiraak fm = new FriedMiraak();
            MarkarthMilk mm = new MarkarthMilk();
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo(bb, mm, fm);
            Assert.Equal(description, c.Description);
        }
    }
}
