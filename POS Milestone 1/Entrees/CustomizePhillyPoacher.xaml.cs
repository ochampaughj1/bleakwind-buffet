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

namespace POS_Milestone_1.Entrees
{
    /// <summary>
    /// Interaction logic for CustomizePhillyPoacher.xaml
    /// </summary>
    public partial class CustomizePhillyPoacher : UserControl
    {
        private MenuSelect ms = new MenuSelect();
        public CustomizePhillyPoacher(MenuSelect menuItem)
        {
            InitializeComponent();
            ms = menuItem;
        }

        void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            ms.orderBorder.Child = ms.menu;
        }
    }
}
