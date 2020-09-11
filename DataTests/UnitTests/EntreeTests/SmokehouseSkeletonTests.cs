/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(sk);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.SausageLink = true;
            Assert.True(sk.SausageLink);
            sk.SausageLink = false;
            Assert.False(sk.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.Egg = true;
            Assert.True(sk.Egg);
            sk.Egg = false;
            Assert.False(sk.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.HashBrowns = true;
            Assert.True(sk.HashBrowns);
            sk.HashBrowns = false;
            Assert.False(sk.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.Pancake = true;
            Assert.True(sk.Pancake);
            sk.Pancake = false;
            Assert.False(sk.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.Equal(5.62, sk.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.Equal("602", sk.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.SausageLink = includeSausage;
            sk.Egg = includeEgg;
            sk.HashBrowns = includeHashbrowns;
            sk.Pancake = includePancake;
            if(!sk.SausageLink && !sk.Egg && !sk.HashBrowns && !sk.Pancake)
            {
                Assert.Contains("Hold sausage", sk.SpecialInstructions);
                Assert.Contains("Hold eggs", sk.SpecialInstructions);
                Assert.Contains("Hold hash browns", sk.SpecialInstructions);
                Assert.Contains("Hold pancakes", sk.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", sk.ToString());
        }
    }
}