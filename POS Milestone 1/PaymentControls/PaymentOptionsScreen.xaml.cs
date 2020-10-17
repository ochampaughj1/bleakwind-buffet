using BleakwindBuffet.Data;
using POS_Milestone_1.PaymentControls;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        private MenuSelect menu;
        private CurrentOrderControlComponent receipt;

        public PaymentOptionsScreen(MenuSelect m, CurrentOrderControlComponent temp)
        {
            InitializeComponent();
            menu = m;
            temp.CompleteOrderButton.IsEnabled = false;
            receipt = temp;
        }

        void ReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            menu.orderBorder.Child = new ButtonControlComponent(menu);
            receipt.CompleteOrderButton.IsEnabled = true;
        }

        void CashButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CashRegister temp = new CashRegister(menu, order, receipt);
                menu.orderBorder.Child = temp;
            }
        }

        void CreditOrDebitClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                var result = CardReader.RunCard(order.Total);
                if(result == CardTransactionResult.Approved)
                {
                    PrintReciept();
                    order.Clear();
                    menu.orderBorder.Child = new ButtonControlComponent(menu);
                    DependencyObject parent = menu;
                    do
                    {
                        parent = LogicalTreeHelper.GetParent(parent);
                    }
                    while (parent != null && !(parent is MainWindow));
                    ((MainWindow)parent).DataContext = new Order();
                }
                else if(result == CardTransactionResult.Declined)
                {
                    MessageBox.Show("Card Declined");
                }
                else if(result == CardTransactionResult.ReadError)
                {
                    MessageBox.Show("Card Read Error, Try Again");
                }
                else if(result == CardTransactionResult.InsufficientFunds)
                {
                    MessageBox.Show("Insufficient Funds, Try Another Card Or Pay With Cash");
                }
                else if(result == CardTransactionResult.IncorrectPin)
                {
                    MessageBox.Show("Incorrect Pin, Please Try Again");
                }
            }
        }
        void PrintReciept()
        {
            if(DataContext is Order order)
            {
                List<string> currentOrder = new List<string>();
                currentOrder.Add("Order #" + order.Number);

                foreach (IOrderItem item in order)
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
                currentOrder.Add("Total Calories Of Order: " + order.Calories);
                currentOrder.Add("Subtotal: $" + String.Format("{0:0.00}", order.Subtotal));
                currentOrder.Add("Tax: $" + String.Format("{0:0.00}", order.Tax));
                currentOrder.Add("Total: $" + String.Format("{0:0.00}", order.Total));

                foreach(string str in currentOrder)
                {
                    RecieptPrinter.PrintLine(str);
                }
                RecieptPrinter.CutTape();
            }
        }
    }
}
