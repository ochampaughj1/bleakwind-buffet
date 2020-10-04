/*
 * Author: Zachery Brunner & Jonathan Ochampaugh
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests
{
    public class DrinkTests
    {
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            var ss = new SailorSoda();
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
            Assert.PropertyChanged(ss, "Calories", () =>
            {
                ss.Size = size;
            });
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry)]
        [InlineData(SodaFlavor.Blackberry)]
        [InlineData(SodaFlavor.Grapefruit)]
        [InlineData(SodaFlavor.Lemon)]
        [InlineData(SodaFlavor.Peach)]
        [InlineData(SodaFlavor.Watermelon)]
        public void ChangingFlavorShouldNotifySodaFlavorProperty(SodaFlavor flavor)
        {
            var ss = new SailorSoda();
            Assert.PropertyChanged(ss, "SodaFlavor", () =>
            {
                ss.Flavor = flavor;
            });
        }
    }
}
