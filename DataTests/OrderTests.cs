/*
 * Author: Jonathan Ochampaugh
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
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
using System.Linq;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAnOrder()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<Order>(order);
        }

        [Fact]
        public void OrderNumberShouldBeOneByDefault()
        {
            Order order = new Order();
            Assert.Equal(1, order.Number);
        }

        [Fact]
        public void ShouldChangeTotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(bb);
            });
        }

        [Fact]
        public void ShouldChangeTax()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(bb);
            });
        }

        [Fact]
        public void ShouldChangeSubtotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(bb);
            });
        }

        [Fact]
        public void ShouldChangeCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(bb);
            });
        }

        [Fact]
        public void ShouldAddToOrder()
        {
            Order o = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combo c = new Combo(bb, mm, fm);
            o.Add(bb);
            o.Add(mm);
            o.Add(fm);
            o.Add(c);
            Assert.Contains(bb, o.order);
            Assert.Contains(mm, o.order);
            Assert.Contains(fm, o.order);
            Assert.Contains(c, o.order);
        }

        [Fact]
        public void ShouldRemoveItemFromOrder()
        {
            Order o = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            FriedMiraak fm = new FriedMiraak();
            Combo c = new Combo(bb, mm, fm);
            o.Add(bb);
            o.Add(mm);
            o.Add(fm);
            o.Add(c);
            Assert.Contains(bb, o.order);
            Assert.Contains(fm, o.order);
            Assert.Contains(mm, o.order);
            Assert.Contains(c, o.order);
            o.Remove(bb);
            o.Remove(fm);
            o.Remove(mm);
            o.Remove(c);
            Assert.DoesNotContain(bb, o.order);
            Assert.DoesNotContain(fm, o.order);
        }
        
        [Fact]
        public void SalesTaxShouldBeDefault()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
        }

        [Theory]
        [InlineData(0.50)]
        [InlineData(0.25)]
        public void ShouldSetSalesTaxRate(double salesTaxRate)
        {
            Order order = new Order();
            order.SalesTaxRate = salesTaxRate;
            Assert.Equal(salesTaxRate, order.SalesTaxRate);
        }

        
        [Theory]
        [InlineData(Size.Large, 836)]
        [InlineData(Size.Medium, 815)]
        [InlineData(Size.Small, 799)]
        public void ShouldReturnTotalCaloriesOfOrder(Size size, uint cal)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            order.Add(bb);
            order.Add(mm);
            Assert.Equal(cal, order.Calories);
        }
    }
}
