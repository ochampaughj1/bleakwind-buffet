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
        
    }
}
