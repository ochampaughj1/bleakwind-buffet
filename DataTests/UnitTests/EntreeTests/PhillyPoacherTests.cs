﻿/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var php = new PhillyPoacher();
            Assert.PropertyChanged(php, "Sirloin", () =>
            {
                php.Sirloin = false;
            });

            Assert.PropertyChanged(php, "Sirloin", () =>
            {
                php.Sirloin = true;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var php = new PhillyPoacher();
            Assert.PropertyChanged(php, "Onion", () =>
            {
                php.Onion = false;
            });

            Assert.PropertyChanged(php, "Onion", () =>
            {
                php.Onion = true;
            });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var php = new PhillyPoacher();
            Assert.PropertyChanged(php, "Roll", () =>
            {
                php.Roll = false;
            });

            Assert.PropertyChanged(php, "Roll", () =>
            {
                php.Roll = true;
            });
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(p);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = true;
            Assert.True(p.Sirloin);
            p.Sirloin = false;
            Assert.False(p.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Onion = true;
            Assert.True(p.Onion);
            p.Onion = false;
            Assert.False(p.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Roll = true;
            Assert.True(p.Roll);
            p.Roll = false;
            Assert.False(p.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(7.23, p.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("784", p.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = includeSirloin;
            p.Onion = includeOnion;
            p.Roll = includeRoll;
            if(!p.Sirloin && !p.Onion && !p.Roll)
            {
                Assert.Contains("Hold sirloin", p.SpecialInstructions);
                Assert.Contains("Hold onions", p.SpecialInstructions);
                Assert.Contains("Hold roll", p.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Philly Poacher", p.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Philly Poacher", p.Name);
        }

        [Theory]
        [InlineData("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.")]
        public void ShouldReturnCorrectDescription(string description)
        {
            PhillyPoacher php = new PhillyPoacher();
            Assert.Equal(description, php.Description);
        }
    }
}