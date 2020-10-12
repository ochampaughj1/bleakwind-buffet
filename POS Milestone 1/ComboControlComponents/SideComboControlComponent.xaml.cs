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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.Sides;

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for SideComboControlComponent.xaml
    /// </summary>
    public partial class SideComboControlComponent : UserControl
    {
        private MenuSelect menu;
        private Combo combo;

        public SideComboControlComponent(MenuSelect m, Combo c, Order o)
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

        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                combo.Side = dwf;
                menu.orderBorder.Child = new CustomizeDragonbornWaffleFries(menu, dwf, order, combo);
            }
        }

        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                FriedMiraak fm = new FriedMiraak();
                combo.Side = fm;
                menu.orderBorder.Child = new CustomizeFriedMiraak(menu, fm, order, combo);
            }
        }

        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MadOtarGrits mog = new MadOtarGrits();
                combo.Side = mog;
                menu.orderBorder.Child = new CustomizeMadOtarGrits(menu, mog, order, combo);
            }
        }

        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VokunSalad vs = new VokunSalad();
                combo.Side = vs;
                menu.orderBorder.Child = new CustomizeVokunSalad(menu, vs, order, combo);
            }
        }
    }
}
