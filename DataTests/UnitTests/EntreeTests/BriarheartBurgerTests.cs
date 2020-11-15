/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests 
    {
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = true;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = true;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b);
        }
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = true;
            Assert.True(b.Bun);
            b.Bun = false;
            Assert.False(b.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = true;
            Assert.True(b.Ketchup);
            b.Ketchup = false;
            Assert.False(b.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = true;
            Assert.True(b.Mustard);
            b.Mustard = false;
            Assert.False(b.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = true;
            Assert.True(b.Pickle);
            b.Pickle = false;
            Assert.False(b.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = true;
            Assert.True(b.Cheese);
            b.Cheese = false;
            Assert.False(b.Cheese);
        }

        
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price);
        }

        
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("743", b.Calories.ToString());
        }
        
        

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = includeBun;
            b.Ketchup = includeKetchup;
            b.Mustard = includeMustard;
            b.Pickle = includePickle;
            b.Cheese = includeCheese;
            if (!b.Bun && !b.Ketchup && !b.Mustard && !b.Pickle && !b.Cheese)
            {
                Assert.Contains("Hold bun", b.SpecialInstructions);
                Assert.Contains("Hold ketchup", b.SpecialInstructions);
                Assert.Contains("Hold mustard", b.SpecialInstructions);
                Assert.Contains("Hold pickle", b.SpecialInstructions);
                Assert.Contains("Hold cheese", b.SpecialInstructions);
            }
            else Assert.Empty(b.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.Name);
        }

        [Theory]
        [InlineData("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.")]
        public void ShouldReturnCorrectDescription(string description)
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(description, bb.Description);
        }
    }
}