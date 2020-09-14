/*
 * Author: Jonathan Ochampaugh
 * Class: IOrderItemTests.cs
 * Purpose: Test the IOrderItem.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests
{
    public class IOrderItemTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
            Assert.IsAssignableFrom<IOrderItem>(aj);

            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chc);
            Assert.IsAssignableFrom<IOrderItem>(chc);

            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(m);
            Assert.IsAssignableFrom<IOrderItem>(m);

            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(s);
            Assert.IsAssignableFrom<IOrderItem>(s);

            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
            Assert.IsAssignableFrom<IOrderItem>(w);

        }
       
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b);
            Assert.IsAssignableFrom<IOrderItem>(b);

            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);
            Assert.IsAssignableFrom<IOrderItem>(d);

            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(g);
            Assert.IsAssignableFrom<IOrderItem>(g);

            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(p);
            Assert.IsAssignableFrom<IOrderItem>(p);

            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(sk);
            Assert.IsAssignableFrom<IOrderItem>(sk);

            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(t);
            Assert.IsAssignableFrom<IOrderItem>(t);

            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }
        
        [Fact]
        public void ShouldBeAssignableToAbstractSidesClass()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dwf);
            Assert.IsAssignableFrom<IOrderItem>(dwf);

            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
            Assert.IsAssignableFrom<IOrderItem>(fm);

            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
            Assert.IsAssignableFrom<IOrderItem>(mog);

            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }
    }
}
