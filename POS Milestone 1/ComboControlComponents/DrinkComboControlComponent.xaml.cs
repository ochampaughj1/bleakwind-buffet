using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using POS_Milestone_1.Drinks;
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

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for DrinkComboControlComponent.xaml
    /// </summary>
    public partial class DrinkComboControlComponent : UserControl
    {
        private MenuSelect menu;
        private Combo combo;

        public DrinkComboControlComponent(MenuSelect m, Combo c, Order o)
        {
            InitializeComponent();
            DataContext = o;
            menu = m;
            combo = c;
        }

        void ReturnToComboClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                menu.orderBorder.Child = new ComboControl(menu, combo, order);
            }
        }

        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                combo.Drink = aj;
                menu.orderBorder.Child = new CustomizeAretinoAppleJuice(menu, aj, order, combo);
            }
        }

        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CandlehearthCoffee chc = new CandlehearthCoffee();
                combo.Drink = chc;
                menu.orderBorder.Child = new CustomizeCandlehearthCoffee(menu, chc, order, combo);
            }
        }

        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MarkarthMilk mm = new MarkarthMilk();
                combo.Drink = mm;
                menu.orderBorder.Child = new CustomizeMarkarthMilk(menu, mm, order, combo);
            }
        }

        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SailorSoda ss = new SailorSoda();
                combo.Drink = ss;
                menu.orderBorder.Child = new CustomizeSailorSoda(menu, ss, order, combo);
            }
        }

        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                WarriorWater ww = new WarriorWater();
                combo.Drink = ww;
                menu.orderBorder.Child = new CustomizeWarriorWater(menu, ww, order, combo);
            }
        }
    }
}
