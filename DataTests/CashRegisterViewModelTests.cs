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
using POS_Milestone_1;
using POS_Milestone_1.PaymentControls;

namespace BleakwindBuffet.DataTests
{
    public class CashRegisterViewModelTests
    {
        [Fact]
        public void ShouldBeACashRegisterViewModel()
        {
            CashRegisterViewModel crv = new CashRegisterViewModel(null, null);
            Assert.IsAssignableFrom<CashRegisterViewModel>(crv);
        }

        [Fact]
        public void ChangingPaymentHundredsShouldNotifyAmountOwed()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            
            Assert.PropertyChanged(crv, "PaymentHundreds", () =>
            {
                crv.PaymentHundreds++;
            });
            Assert.PropertyChanged(crv, "AmountOwed", () =>
            {
                crv.PaymentHundreds++;
            });
            Assert.PropertyChanged(crv, "ChangeDue", () =>
            {
                crv.PaymentHundreds++;
            });
            Assert.PropertyChanged(crv, "AmountOwedDisplay", () =>
            {
                crv.PaymentHundreds++;
            });
        }

        [Theory]
        [InlineData(10.00)]
        public void ShouldGetAmountOwed(double amountOwed)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(mm);
            order.Add(dwf);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.Equal(amountOwed, Math.Round(crv.AmountOwed, 2));

        }
    }
}
