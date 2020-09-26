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

namespace POS_Milestone_1.Drinks
{
    /// <summary>
    /// Interaction logic for CustomizeAretinoAppleJuice.xaml
    /// </summary>
    public partial class CustomizeAretinoAppleJuice : UserControl
    {
        private MenuSelect ms = new MenuSelect();
        public CustomizeAretinoAppleJuice(MenuSelect menuItem)
        {
            InitializeComponent();
            ms = menuItem;
        }

        void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            ms.orderBorder.Child = ms.menu;
        }

        /*
        void CheckOnlyOneSizeAtATime(object sender, RoutedEventArgs e)
        {
            if(smallCheckBox.IsChecked == true)
            {
                mediumCheckBox.IsChecked = false;
                largeCheckBox.IsChecked = false;
            }
            else if(mediumCheckBox.IsChecked == true)
            {
                smallCheckBox.IsChecked = false;
                largeCheckBox.IsChecked = false;
            }
            else if(largeCheckBox.IsChecked == true)
            {
                smallCheckBox.IsChecked = false;
                mediumCheckBox.IsChecked = false;
            }
        }
        */
    }
}
