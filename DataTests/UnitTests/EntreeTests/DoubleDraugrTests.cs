/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = true;
            Assert.True(d.Bun);
            d.Bun = false;
            Assert.False(d.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Ketchup = true;
            Assert.True(d.Ketchup);
            d.Ketchup = false;
            Assert.False(d.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mustard = true;
            Assert.True(d.Mustard);
            d.Mustard = false;
            Assert.False(d.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Pickle = true;
            Assert.True(d.Pickle);
            d.Pickle = false;
            Assert.False(d.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Cheese = true;
            Assert.True(d.Cheese);
            d.Cheese = false;
            Assert.False(d.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Tomato = true;
            Assert.True(d.Tomato);
            d.Tomato = false;
            Assert.False(d.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Lettuce = true;
            Assert.True(d.Lettuce);
            d.Lettuce = false;
            Assert.False(d.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mayo = true;
            Assert.True(d.Mayo);
            d.Mayo = false;
            Assert.False(d.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(7.32, d.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("843", d.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = includeBun;
            d.Ketchup = includeKetchup;
            d.Mustard = includeMustard;
            d.Pickle = includePickle;
            d.Cheese = includeCheese;
            d.Tomato = includeTomato;
            d.Lettuce = includeLettuce;
            d.Mayo = includeMayo;
            if (!d.Bun && !d.Ketchup && !d.Mustard && !d.Pickle && !d.Cheese && !d.Tomato && !d.Lettuce && !d.Mayo)
            {
                Assert.Contains("Hold bun", d.SpecialInstructions);
                Assert.Contains("Hold ketchup", d.SpecialInstructions);
                Assert.Contains("Hold mustard", d.SpecialInstructions);
                Assert.Contains("Hold pickle", d.SpecialInstructions);
                Assert.Contains("Hold cheese", d.SpecialInstructions);
                Assert.Contains("Hold tomato", d.SpecialInstructions);
                Assert.Contains("Hold lettuce", d.SpecialInstructions);
                Assert.Contains("Hold mayo", d.SpecialInstructions);
            }
            else Assert.Empty(d.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.Name);
        }

        [Theory]
        [InlineData("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.")]
        public void ShouldReturnCorrectDescription(string description)
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(description, dd.Description);
        }
    }
}