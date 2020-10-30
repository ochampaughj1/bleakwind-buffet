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
using POS_Milestone_1.PaymentControls;
using RoundRegister;

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

        [Fact]
        public void ChangingPaymentFiftiesShouldNotifyPaymentFifties()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentFifties", () =>
            {
                crv.PaymentFifties++;
            });
        }

        [Fact]
        public void ChangingPaymentTwentiesShouldNotifyPaymentTwenties()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentTwenites", () =>
            {
                crv.PaymentTwenites++;
            });
        }

        [Fact]
        public void ChangingPaymentTensShouldNotifyPaymentTens()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentTens", () =>
            {
                crv.PaymentTens++;
            });
        }

        [Fact]
        public void ChangingPaymentFivesShouldNotifyPaymentFives()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentFives", () =>
            {
                crv.PaymentFives++;
            });
        }

        [Fact]
        public void ChangingPaymentTwosShouldNotifyPaymentTwos()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentTwos", () =>
            {
                crv.PaymentTwos++;
            });
        }

        [Fact]
        public void ChangingPaymentOnesShouldNotifyPaymentOnes()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentOnes", () =>
            {
                crv.PaymentOnes++;
            });
        }

        [Fact]
        public void ChangingPaymentDollarCoinsShouldNotifyPaymentDollarCoins()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentDollarCoins", () =>
            {
                crv.PaymentDollarCoins++;
            });
        }

        [Fact]
        public void ChangingPaymentHalfDollarsShouldNotifyPaymentHalfDollars()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentHalfDollars", () =>
            {
                crv.PaymentHalfDollars++;
            });
        }

        [Fact]
        public void ChangingPaymentQuartersShouldNotifyPaymentQuarters()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentQuarters", () =>
            {
                crv.PaymentQuarters++;
            });
        }

        [Fact]
        public void ChangingPaymentDimesShouldNotifyPaymentDimes()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentDimes", () =>
            {
                crv.PaymentDimes++;
            });
        }

        [Fact]
        public void ChangingPaymentNickelsShouldNotifyPaymentNickels()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentNickels", () =>
            {
                crv.PaymentNickels++;
            });
        }

        [Fact]
        public void ChangingPaymentPenniesShouldNotifyPaymentPennies()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.PropertyChanged(crv, "PaymentPennies", () =>
            {
                crv.PaymentPennies++;
            });
        }

        [Theory]
        [InlineData(8.72)]
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

        [Theory]
        [InlineData(8.72)]
        public void ShouldGetAmountOwedDisplay(double amountOwed)
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(mm);
            order.Add(dwf);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            Assert.Equal(amountOwed, Math.Round(crv.AmountOwedDisplay, 2));
        }

        [Theory]
        [InlineData(91.28, 1)]
        public void ShouldCalculateCorrectChange(double changeDue, int payment)
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(mm);
            order.Add(dwf);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            
            crv.ChangeOwedToCustomer();
            crv.PaymentHundreds = payment;

            Assert.Equal(changeDue, Math.Round(crv.ChangeDue, 2));
            Assert.Equal(0, crv.ChangeHundreds);
            Assert.Equal(0, crv.ChangeFifties);
            Assert.Equal(4, crv.ChangeTwenties);
            Assert.Equal(1, crv.ChangeTens);
            Assert.Equal(0, crv.ChangeFives);
            Assert.Equal(0, crv.ChangeTwos);
            Assert.Equal(1, crv.ChangeOnes);
            Assert.Equal(0, crv.ChangeDollarCoins);
            Assert.Equal(0, crv.ChangeHalfDollars);
            Assert.Equal(1, crv.ChangeQuarters);
            Assert.Equal(0, crv.ChangeDimes);
            Assert.Equal(0, crv.ChangeNickles);
            Assert.Equal(2, crv.ChangePennies);
        }

        [Theory]
        [InlineData(1)]
        public void FinalizeSaleShouldUpdateRegister(int payment)
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            order.Add(bb);
            order.Add(mm);
            order.Add(dwf);
            CashRegisterViewModel crv = new CashRegisterViewModel(order, null);
            crv.PaymentHundreds = payment;
            crv.ChangeOwedToCustomer();
            crv.FinializeSale();

            Assert.Equal(1, crv.RegisterHundreds);
            Assert.Equal(0, crv.RegisterFifties);
            Assert.Equal(1, crv.RegisterTwenties);
            Assert.Equal(9, crv.RegisterTens);
            Assert.Equal(4, crv.RegisterFives);
            Assert.Equal(0, crv.RegisterTwos);
            Assert.Equal(19, crv.RegisterOnes);
            Assert.Equal(0, crv.RegisterDollarCoin);
            Assert.Equal(0, crv.RegisterHalfDollars);
            Assert.Equal(79, crv.RegisterQuarters);
            Assert.Equal(100, crv.RegisterDimes);
            Assert.Equal(80, crv.RegisterNickels);
            Assert.Equal(198, crv.RegisterPennies);
            Assert.Equal(0, crv.PaymentHundreds);
            Assert.Equal(0, crv.PaymentFifties);
            Assert.Equal(0, crv.PaymentTwenites);
            Assert.Equal(0, crv.PaymentTens);
            Assert.Equal(0, crv.PaymentFives);
            Assert.Equal(0, crv.PaymentTwos);
            Assert.Equal(0, crv.PaymentOnes);
            Assert.Equal(0, crv.PaymentDollarCoins);
            Assert.Equal(0, crv.PaymentHalfDollars);
            Assert.Equal(0, crv.PaymentQuarters);
            Assert.Equal(0, crv.PaymentDimes);
            Assert.Equal(0, crv.PaymentNickels);
            Assert.Equal(0, crv.PaymentPennies);
        }
    }
}
