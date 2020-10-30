/*
 * Author: Jonathan Ochampaugh
 * Class: CashRegisterViewModel.cs
 * Purpose: View Model of cash register acting as a mediator between the CashRegister class and the CashDrawer class in the RoundRegister.dll
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Schema;
using BleakwindBuffet.Data;
using RoundRegister;

namespace POS_Milestone_1.PaymentControls
{
    public class CashRegisterViewModel: INotifyPropertyChanged
    {
        /// <summary>
        /// Implements the interface of INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed Invoke helper method
        /// </summary>
        /// <param name="name">Name of property being invoked</param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Backing variables for the current Order and CashRegister
        /// </summary>
        private CashRegister cashRegister;
        private Order Order;

        /// <summary>
        /// Initializes the current order and cash register
        /// </summary>
        /// <param name="order">Current Order</param>
        /// <param name="cr">Current CashRegister</param>
        public CashRegisterViewModel(Order order, CashRegister cr)
        {
            Order = order;
            cashRegister = cr;
        }

        /// <summary>
        /// Property to get the total of the current order
        /// </summary>
        public double Total
        {
            get => Order.Total;
        }

        /// <summary>
        /// Property to get the total payment from the customer
        /// </summary>
        public double Payment
        {
            get => (PaymentHundreds * 100) + (PaymentFifties * 50) + (PaymentTwenites * 20) + (paymentTens * 10) +
                (PaymentFives * 5) + (PaymentTwos * 2) + (PaymentOnes * 1) + (PaymentDollarCoins * 1) + (PaymentHalfDollars * 0.50) +
                (PaymentQuarters * 0.25) + (PaymentDimes * 0.10) + (PaymentNickels * 0.05) + (PaymentPennies * 0.01);
        }

        /// <summary>
        /// Property to get the amount owed by customer display
        /// </summary>
        public double AmountOwedDisplay
        {
            get
            {
                if (AmountOwed < 0) return 0;
                else return AmountOwed;
            }
        }

        /// <summary>
        /// Property to get the amount owed by the customer
        /// </summary>
        public double AmountOwed
        {
            get => Total - Payment;
        }

        /// <summary>
        /// Property to get the change due to the customer
        /// </summary>
        public double ChangeDue
        {
            get 
            {
                if (Payment - AmountOwed > 0) return Math.Abs(AmountOwed);
                else return 0;
            }
        }

        /// <summary>
        /// Property to get and set the amount of Hundred bills in the register
        /// </summary>
        public int RegisterHundreds
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
                OnPropertyChanged("RegisterHundreds");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Hundreds given by the customer
        /// </summary>
        private int paymentHundreds = 0;
        public int PaymentHundreds
        {
            get
            {
                return paymentHundreds;
            }
            set
            {
                if (paymentHundreds != value)
                {
                    paymentHundreds = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentHundreds");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Hundreds owed to the customer
        /// </summary>
        private int changeHundreds = 0;

        public int ChangeHundreds
        {
            get { return changeHundreds; }
        }

        /// <summary>
        /// Property to get and set the amount of Fifty bills in the register
        /// </summary>
        public int RegisterFifties
        {
            get
            {
                return CashDrawer.Fifties;
            }
            set
            {
                CashDrawer.Fifties = value;
                OnPropertyChanged("RegisterFifties");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Fifties given by the customer
        /// </summary>
        private int paymentFifties = 0;
        public int PaymentFifties
        {
            get
            {
                return paymentFifties;
            }
            set
            {
                if (paymentFifties != value)
                {
                    paymentFifties = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentFifties");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Fifties owed to the customer
        /// </summary>
        private int changeFifties = 0;
        public int ChangeFifties
        {
            get { return changeFifties; }
        }

        /// <summary>
        /// Property to get and set the amount of Twenty bills in the register
        /// </summary>
        public int RegisterTwenties
        {
            get
            {
                return CashDrawer.Twenties;
            }
            set
            {
                CashDrawer.Twenties = value;
                OnPropertyChanged("RegisterTwenties");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Twenties given by the customer
        /// </summary>
        private int paymentTwenties = 0;
        public int PaymentTwenites
        {
            get
            {
                return paymentTwenties;
            }
            set
            {
                if (paymentTwenties != value)
                {
                    paymentTwenties = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentTwenites");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Twenties owed to the customer
        /// </summary>
        private int changeTwenties = 0;
        public int ChangeTwenties
        {
            get { return changeTwenties; }
        }

        /// <summary>
        /// Property to get and set the amount of Ten bills in the register
        /// </summary>
        public int RegisterTens
        {
            get
            {
                return CashDrawer.Tens;
            }
            set
            {
                CashDrawer.Tens = value;
                OnPropertyChanged("RegisterTens");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Tens given by the customer
        /// </summary>
        private int paymentTens = 0;
        public int PaymentTens
        {
            get
            {
                return paymentTens;
            }
            set
            {
                if (paymentTens != value)
                {
                    paymentTens = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentTens");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Tens owed to the customer
        /// </summary>
        private int changeTens = 0;
        public int ChangeTens
        {
            get { return changeTens; }
        }

        /// <summary>
        /// Property to get and set the amount of Five bills in the register
        /// </summary>
        public int RegisterFives
        {
            get
            {
                return CashDrawer.Fives;
            }
            set
            {
                CashDrawer.Fives = value;
                OnPropertyChanged("RegisterFives");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Fives given by the customer
        /// </summary>
        private int paymentFives = 0;
        public int PaymentFives
        {
            get
            {
                return paymentFives;
            }
            set
            {
                if (paymentFives != value)
                {
                    paymentFives = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentFives");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Fives owed to the customer
        /// </summary>
        private int changeFives = 0;
        public int ChangeFives
        {
            get { return changeFives; }
        }

        /// <summary>
        /// Property to get and set the amount of Two bills in the register
        /// </summary>
        public int RegisterTwos
        {
            get
            {
                return CashDrawer.Twos;
            }
            set
            {
                CashDrawer.Twos = value;
                OnPropertyChanged("RegisterTwos");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Twos given by the customer
        /// </summary>
        private int paymentTwos = 0;
        public int PaymentTwos
        {
            get
            {
                return paymentTwos;
            }
            set
            {
                if (paymentTwos != value)
                {
                    paymentTwos = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentTwos");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Twos owed to the customer
        /// </summary>
        private int changeTwos = 0;
        public int ChangeTwos
        {
            get { return changeTwos; }
        }

        /// <summary>
        /// Property to get and set the amount of One bills in the register
        /// </summary>
        public int RegisterOnes
        {
            get
            {
                return CashDrawer.Ones;
            }
            set
            {
                CashDrawer.Ones = value;
                OnPropertyChanged("RegisterOnes");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Ones given by the customer
        /// </summary>
        private int paymentOnes = 0;
        public int PaymentOnes
        {
            get
            {
                return paymentOnes;
            }
            set
            {
                if (paymentOnes != value)
                {
                    paymentOnes = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentOnes");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Ones owed to the customer
        /// </summary>
        private int changeOnes = 0;
        public int ChangeOnes
        {
            get { return changeOnes; }
        }

        /// <summary>
        /// Property to get and set the amount of Dollar coins in the register
        /// </summary>
        public int RegisterDollarCoin
        {
            get
            {
                return CashDrawer.Dollars;
            }
            set
            {
                CashDrawer.Dollars = value;
                OnPropertyChanged("RegisterDollarCoin");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Dollar Coins given by the customer
        /// </summary>
        private int paymentDollarCoins = 0;
        public int PaymentDollarCoins
        {
            get
            {
                return paymentDollarCoins;
            }
            set
            {
                if (paymentDollarCoins != value)
                {
                    paymentDollarCoins = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentDollarCoins");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Dollar Coins owed to the customer
        /// </summary>
        private int changeDollarCoins = 0;
        public int ChangeDollarCoins
        {
            get { return changeDollarCoins; }
        }

        /// <summary>
        /// Property to get and set the amount of Half Dollar coins in the register
        /// </summary>
        public int RegisterHalfDollars
        {
            get
            {
                return CashDrawer.HalfDollars;
            }
            set
            {
                CashDrawer.HalfDollars = value;
                OnPropertyChanged("RegisterHalfDollars");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Half Dollar coins given by the customer
        /// </summary>
        private int paymentHalfDollars = 0;
        public int PaymentHalfDollars
        {
            get
            {
                return paymentHalfDollars;
            }
            set
            {
                if (paymentHalfDollars != value)
                {
                    paymentHalfDollars = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentHalfDollars");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Half Dollar Coins owed to the customer
        /// </summary>
        private int changeHalfDollars = 0;
        public int ChangeHalfDollars
        {
            get { return changeHalfDollars; }
        }

        /// <summary>
        /// Property to get and set the amount of Quarters in the register
        /// </summary>
        public int RegisterQuarters
        {
            get
            {
                return CashDrawer.Quarters;
            }
            set
            {
                CashDrawer.Quarters = value;
                OnPropertyChanged("RegisterQuarters");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Quarters given by the customer
        /// </summary>
        private int paymentQuarters = 0;
        public int PaymentQuarters
        {
            get
            {
                return paymentQuarters;
            }
            set
            {
                if (paymentQuarters != value)
                {
                    paymentQuarters = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentQuarters");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Quarters owed to the customer
        /// </summary>
        private int changeQuarters = 0;
        public int ChangeQuarters
        {
            get { return changeQuarters; }
        }

        /// <summary>
        /// Property to get and set the amount of Dimes in the register
        /// </summary>
        public int RegisterDimes
        {
            get
            {
                return CashDrawer.Dimes;
            }
            set
            {
                CashDrawer.Dimes = value;
                OnPropertyChanged("RegisterDimes");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Dimes given by the customer
        /// </summary>
        private int paymentDimes = 0;
        public int PaymentDimes
        {
            get
            {
                return paymentDimes;
            }
            set
            {
                if (paymentDimes != value)
                {
                    paymentDimes = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentDimes");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Dimes owed to the customer
        /// </summary>
        private int changeDimes = 0;
        public int ChangeDimes
        {
            get { return changeDimes; }
        }

        /// <summary>
        /// Property to get and set the amount of Nickels in the register
        /// </summary>
        public int RegisterNickels
        {
            get
            {
                return CashDrawer.Nickels;
            }
            set
            {
                CashDrawer.Nickels = value;
                OnPropertyChanged("RegisterNickels");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Nickels given by the customer
        /// </summary>
        private int paymentNickels = 0;
        public int PaymentNickels
        {
            get
            {
                return paymentNickels;
            }
            set
            {
                if (paymentNickels != value)
                {
                    paymentNickels = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentNickels");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Nickels owed to the customer
        /// </summary>
        private int changeNickles = 0;
        public int ChangeNickles
        {
            get { return changeNickles; }
        }

        /// <summary>
        /// Property to get and set the amount of Pennies in the register
        /// </summary>
        public int RegisterPennies
        {
            get
            {
                return CashDrawer.Pennies;
            }
            set
            {
                CashDrawer.Pennies = value;
                OnPropertyChanged("RegisterPennies");
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Pennies given by the customer
        /// </summary>
        private int paymentPennies = 0;
        public int PaymentPennies
        {
            get
            {
                return paymentPennies;
            }
            set
            {
                if (paymentPennies != value)
                {
                    paymentPennies = value;
                    ChangeOwedToCustomer();
                    OnPropertyChanged("AmountOwed");
                    OnPropertyChanged("PaymentPennies");
                    OnPropertyChanged("ChangeDue");
                    OnPropertyChanged("AmountOwedDisplay");
                }
            }
        }

        /// <summary>
        /// Backing variable and property to get and set the amount of Pennies owed to the customer
        /// </summary>
        private int changePennies = 0;
        public int ChangePennies
        {
            get { return changePennies; }
        }

        /// <summary>
        /// Finalizes sale by adding payment to the register, giving change to the customer, resetting the payment, and prints a reciept of the order
        /// </summary>
        public void FinializeSale()
        {
            //Hundreds
            RegisterHundreds += PaymentHundreds;
            RegisterHundreds -= ChangeHundreds;
            paymentHundreds = 0;
            //Fifty
            RegisterFifties += PaymentFifties;
            RegisterFifties -= ChangeFifties;
            paymentFifties = 0;
            //Twenty
            RegisterTwenties += PaymentTwenites;
            RegisterTwenties -= changeTwenties;
            paymentTwenties = 0;
            //Ten
            RegisterTens += PaymentTens;
            RegisterTens -= changeTens;
            paymentTens = 0;
            //Five
            RegisterFives += PaymentFives;
            RegisterFives -= changeFives;
            paymentFives = 0;
            //Two
            RegisterTwos += PaymentTwos;
            RegisterTwos -= ChangeTwos;
            paymentTwos = 0;
            //One
            RegisterOnes += PaymentOnes;
            RegisterOnes -= changeOnes;
            paymentOnes = 0;
            //Dollar Coin
            RegisterDollarCoin += PaymentDollarCoins;
            RegisterDollarCoin -= changeDollarCoins;
            paymentDollarCoins = 0;
            //Half Dollar
            RegisterHalfDollars += PaymentHalfDollars;
            RegisterHalfDollars -= changeHalfDollars;
            paymentHalfDollars = 0;
            //Quarters
            RegisterQuarters += PaymentQuarters;
            RegisterQuarters -= ChangeQuarters;
            paymentQuarters = 0;
            //Dimes
            RegisterDimes += PaymentDimes;
            RegisterDimes -= changeDimes;
            paymentDimes = 0;
            //Nickels
            RegisterNickels += PaymentNickels;
            RegisterNickels -= changeNickles;
            paymentNickels = 0;
            //Pennies
            RegisterPennies += PaymentPennies;
            RegisterPennies -= changePennies;
            paymentPennies = 0;

            ChangeOwedToCustomer();
            PrintReciept();
        }
        
        /// <summary>
        /// Calculates and sets change owed to the customer
        /// </summary>
        public void ChangeOwedToCustomer()
        {
            double originalAmount = ChangeDue;
            double remainingAmount = originalAmount;
            changeHundreds = 0;
            changeFifties = 0;
            changeTwenties = 0;
            changeTens = 0;
            changeFives = 0;
            changeTwos = 0;
            changeOnes = 0;
            changeDollarCoins = 0;
            changeHalfDollars = 0;
            changeQuarters = 0;
            changeDimes = 0;
            changeNickles = 0;
            changePennies = 0;

            int temp = RegisterHundreds;
            while ((originalAmount % 100) < originalAmount && temp > 0)
            {
                if(originalAmount - 100 > 0)
                {
                    changeHundreds++;
                    temp--;
                    remainingAmount = originalAmount - 100;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterFifties;
            while ((originalAmount % 50) < originalAmount && temp > 0)
            {
                if (originalAmount - 50 > 0)
                {
                    changeFifties++;
                    temp--;
                    remainingAmount = originalAmount - 50;
                    originalAmount = remainingAmount;
                }  
            }
            temp = RegisterTwenties;
            while ((originalAmount % 20) < originalAmount && temp > 0)
            {
                if (originalAmount - 20 > 0)
                {
                    changeTwenties++;
                    temp--;
                    remainingAmount = originalAmount - 20;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterTens;
            while ((originalAmount % 10) < originalAmount && temp > 0)
            {
                if (originalAmount - 10 > 0)
                {
                    changeTens++;
                    temp--;
                    remainingAmount = originalAmount - 10;
                    originalAmount = remainingAmount;
                }
                    
            }
            temp = RegisterFives;
            while ((originalAmount % 5) < originalAmount && temp > 0)
            {
                if (originalAmount - 5 > 0)
                {
                    changeFives++;
                    temp--;
                    remainingAmount = originalAmount - 5;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterTwos;
            while ((originalAmount % 2) < originalAmount && temp > 0)
            {
                if (originalAmount - 2 > 0)
                {
                    changeTwos++;
                    temp--;
                    remainingAmount = originalAmount - 2;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterOnes;
            while ((originalAmount % 1) < originalAmount && temp > 0)
            {
                if (originalAmount - 1 > 0)
                {
                    changeOnes++;
                    temp--;
                    remainingAmount = originalAmount - 1;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterDollarCoin;
            while ((originalAmount % 1) < originalAmount && temp > 0)
            {
                if (originalAmount - 1 > 0)
                {
                    changeDollarCoins++;
                    temp--;
                    remainingAmount = originalAmount - 1;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterHalfDollars;
            while ((originalAmount % 0.50) < originalAmount && temp > 0)
            {
                if (originalAmount - 0.50 > 0)
                {
                    changeHalfDollars++;
                    temp--;
                    remainingAmount = originalAmount - 0.50;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterQuarters;
            while ((originalAmount % 0.25) < originalAmount && temp > 0)
            {
                if (originalAmount - 0.25 > 0)
                {
                    changeQuarters++;
                    temp--;
                    remainingAmount = originalAmount - 0.25;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterDimes;
            while ((originalAmount % 0.10) < originalAmount && temp > 0)
            {
                if (originalAmount - 0.10 > 0)
                {
                    changeDimes++;
                    temp--;
                    remainingAmount = originalAmount - 0.10;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterNickels;
            while ((originalAmount % 0.05) < originalAmount && temp > 0)
            {
                if (originalAmount - 0.05 > 0)
                {
                    changeNickles++;
                    temp--;
                    remainingAmount = originalAmount - 0.05;
                    originalAmount = remainingAmount;
                }
            }
            temp = RegisterPennies;
            while ((originalAmount % 0.01) < originalAmount && temp > 0)
            {
                if (originalAmount - 0.01 > 0)
                {
                    changePennies++;
                    temp--;
                    remainingAmount = originalAmount - 0.01;
                    originalAmount = remainingAmount;
                }
            }
            OnPropertyChanged("ChangeHundreds");
            OnPropertyChanged("ChangeFifties");
            OnPropertyChanged("ChangeTwenties");
            OnPropertyChanged("ChangeTens");
            OnPropertyChanged("ChangeFives");
            OnPropertyChanged("ChangeTwos");
            OnPropertyChanged("ChangeOnes");
            OnPropertyChanged("ChangeDollarCoins");
            OnPropertyChanged("ChangeHalfDollars");
            OnPropertyChanged("ChangeQuarters");
            OnPropertyChanged("ChangeDimes");
            OnPropertyChanged("ChangeNickles");
            OnPropertyChanged("ChangePennies");
        }

        /// <summary>
        /// Prints a reciept of the current order
        /// </summary>
        void PrintReciept()
        {
            List<string> currentOrder = new List<string>();
            currentOrder.Add("Order #" + Order.Number);

            foreach (IOrderItem item in Order)
            {
                currentOrder.Add(item.ToString() + ":");
                foreach (string instruction in item.SpecialInstructions)
                {
                    currentOrder.Add(instruction);
                }
                currentOrder.Add("Calories: " + item.Calories);
                currentOrder.Add("Price: $" + String.Format("{0:0.00}", item.Price));
                currentOrder.Add("");
            }
            currentOrder.Add("Total Calories Of Order: " + Order.Calories);
            currentOrder.Add("Subtotal: $" + String.Format("{0:0.00}", Order.Subtotal));
            currentOrder.Add("Tax: $" + String.Format("{0:0.00}", Order.Tax));
            currentOrder.Add("Total: $" + String.Format("{0:0.00}", Order.Total));

            foreach (string str in currentOrder)
            {
                RecieptPrinter.PrintLine(str);
            }
            RecieptPrinter.CutTape();
        }
    }
}
