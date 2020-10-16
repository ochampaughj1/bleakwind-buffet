using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace POS_Milestone_1.PaymentControls
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        private MenuSelect menu;
        private Order currentOrder;

        public CashRegister(MenuSelect m, Order order)
        {
            InitializeComponent();
            DataContext = order;
            TotalTextBlock.Text = String.Format("{0:0.00}", order.Total);
            menu = m;
            DataContext = new CashRegisterViewModel(order, this);
            currentOrder = order;
        }

        void ReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            menu.orderBorder.Child = new ButtonControlComponent(menu);
        }

        void FinalizeSaleClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashRegisterViewModel crv)
            {
                crv.FinializeSale();
            }
            currentOrder.Clear();
            menu.orderBorder.Child = new ButtonControlComponent(menu);
            DependencyObject parent = menu;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (parent != null && !(parent is MainWindow));
            ((MainWindow)parent).DataContext = new Order();
        }
    }
}
