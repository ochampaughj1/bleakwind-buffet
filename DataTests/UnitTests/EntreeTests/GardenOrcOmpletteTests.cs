/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = true;
            Assert.True(g.Broccoli);
            g.Broccoli = false;
            Assert.False(g.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Mushrooms = true;
            Assert.True(g.Mushrooms);
            g.Mushrooms = false;
            Assert.False(g.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Tomato = true;
            Assert.True(g.Tomato);
            g.Tomato = false;
            Assert.False(g.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Cheddar = true;
            Assert.True(g.Cheddar);
            g.Cheddar = false;
            Assert.False(g.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal(4.57, g.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal("404", g.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = includeBroccoli;
            g.Mushrooms = includeMushrooms;
            g.Cheddar = includeCheddar;
            g.Tomato = includeTomato;
            if (!g.Broccoli && !g.Mushrooms && !g.Cheddar && !g.Tomato)
            {
                Assert.Contains("Hold broccoli", g.SpecialInstructions);
                Assert.Contains("Hold mushrooms", g.SpecialInstructions);
                Assert.Contains("Hold cheddar", g.SpecialInstructions);
                Assert.Contains("Hold tomato", g.SpecialInstructions);
            }
            else Assert.Empty(g.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", g.ToString());
        }
    }
}