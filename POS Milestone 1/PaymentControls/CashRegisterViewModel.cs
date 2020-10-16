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
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed Invoke helper method
        /// </summary>
        /// <param name="name">Name of property being invoked</param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private CashRegister cashRegister;
        private Order Order;

        public CashRegisterViewModel(Order order, CashRegister cr)
        {
            Order = order;
            cashRegister = cr;
        }

        public double Total
        {
            get => Order.Total;
        }

        public double Payment
        {
            get => (PaymentHundreds * 100) + (PaymentFifties * 50) + (PaymentTwenites * 20) + (paymentTens * 10) +
                (PaymentFives * 5) + (PaymentTwos * 2) + (PaymentOnes * 1) + (PaymentDollarCoins * 1) + (PaymentHalfDollars * 0.50) +
                (PaymentQuarters * 0.25) + (PaymentDimes * 0.10) + (PaymentNickels * 0.05) + (PaymentPennies * 0.01);
        }

        public double AmountOwedDisplay
        {
            get
            {
                if (AmountOwed < 0) return 0;
                else return AmountOwed;
            }
        }

        public double AmountOwed
        {
            get => Total - Payment;
        }

        
        public double ChangeDue
        {
            get 
            {
                if (Payment - AmountOwed > 0) return Math.Abs(AmountOwed);
                else return 0;
            }
        }

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

        private int changeHundreds = 0;

        public int ChangeHundreds
        {
            get { return changeHundreds; }
        }


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

        private int changeFifties = 0;

        public int ChangeFifties
        {
            get { return changeFifties; }
        }

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

        private int changeTwenties = 0;

        public int ChangeTwenties
        {
            get { return changeTwenties; }
        }

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

        private int changeTens = 0;

        public int ChangeTens
        {
            get { return changeTens; }
        }

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

        private int changeFives = 0;

        public int ChangeFives
        {
            get { return changeFives; }
        }

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

        private int changeTwos = 0;

        public int ChangeTwos
        {
            get { return changeTwos; }
        }

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

        private int changeOnes = 0;

        public int ChangeOnes
        {
            get { return changeOnes; }
        }

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

        private int changeDollarCoins = 0;

        public int ChangeDollarCoins
        {
            get { return changeDollarCoins; }
        }

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

        private int changeHalfDollars = 0;

        public int ChangeHalfDollars
        {
            get { return changeHalfDollars; }
        }

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

        private int changeQuarters = 0;

        public int ChangeQuarters
        {
            get { return changeQuarters; }
        }

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

        private int changeDimes = 0;

        public int ChangeDimes
        {
            get { return changeDimes; }
        }

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

        private int changeNickles = 0;

        public int ChangeNickles
        {
            get { return changeNickles; }
        }

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

        private int changePennies = 0;

        public int ChangePennies
        {
            get { return changePennies; }
        }


        public void FinializeSale()
        {
            CashDrawer.OpenDrawer();
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
        
        void ChangeOwedToCustomer()
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

            while ((originalAmount % 100) < originalAmount && RegisterHundreds > 0)
            {
                if(originalAmount - 100 > 0)
                {
                    changeHundreds++;
                    remainingAmount = originalAmount - 100;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 50) < originalAmount && RegisterFifties > 0)
            {
                if (originalAmount - 50 > 0)
                {
                    changeFifties++;
                    remainingAmount = originalAmount - 50;
                    originalAmount = remainingAmount;
                }  
            }
            while ((originalAmount % 20) < originalAmount && RegisterTwenties > 0)
            {
                if (originalAmount - 20 > 0)
                {
                    changeTwenties++;
                    remainingAmount = originalAmount - 20;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 10) < originalAmount && RegisterTens > 0)
            {
                if (originalAmount - 10 > 0)
                {
                    changeTens++;
                    remainingAmount = originalAmount - 10;
                    originalAmount = remainingAmount;
                }
                    
            }
            while ((originalAmount % 5) < originalAmount && RegisterFives > 0)
            {
                if (originalAmount - 5 > 0)
                {
                    changeFives++;
                    remainingAmount = originalAmount - 5;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 2) < originalAmount && RegisterTwos > 0)
            {
                if (originalAmount - 2 > 0)
                {
                    changeTwos++;
                    remainingAmount = originalAmount - 2;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 1) < originalAmount && RegisterOnes > 0)
            {
                if (originalAmount - 1 > 0)
                {
                    changeOnes++;
                    remainingAmount = originalAmount - 1;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 1) < originalAmount && RegisterDollarCoin > 0)
            {
                if (originalAmount - 1 > 0)
                {
                    changeDollarCoins++;
                    remainingAmount = originalAmount - 1;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.50) < originalAmount && RegisterHalfDollars > 0)
            {
                if (originalAmount - 0.50 > 0)
                {
                    changeHalfDollars++;
                    remainingAmount = originalAmount - 0.50;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.25) < originalAmount && RegisterQuarters > 0)
            {
                if (originalAmount - 0.25 > 0)
                {
                    changeQuarters++;
                    remainingAmount = originalAmount - 0.25;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.10) < originalAmount && RegisterDimes > 0)
            {
                if (originalAmount - 0.10 > 0)
                {
                    changeDimes++;
                    remainingAmount = originalAmount - 0.10;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.05) < originalAmount && RegisterNickels > 0)
            {
                if (originalAmount - 0.05 > 0)
                {
                    changeNickles++;
                    remainingAmount = originalAmount - 0.05;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.01) < originalAmount && RegisterPennies > 0)
            {
                if (originalAmount - 0.01 > 0)
                {
                    changePennies++;
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
