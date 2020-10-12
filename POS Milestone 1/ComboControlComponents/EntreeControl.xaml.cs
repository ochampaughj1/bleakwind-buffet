using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.Entrees;

namespace POS_Milestone_1.ComboControlComponents
{
    /// <summary>
    /// Interaction logic for EntreeControl.xaml
    /// </summary>
    public partial class EntreeControl : UserControl
    {
        private MenuSelect menu;
        private Combo combo;

        public EntreeControl(MenuSelect m, Combo c, Order o)
        {
            InitializeComponent();
            DataContext = o;
            menu = m;
            combo = c;
        }

        void ReturnToComboClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                menu.orderBorder.Child = new ComboControl(menu, combo, order);
            }
        }

        void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                BriarheartBurger bb = new BriarheartBurger();
                combo.Entree = bb;
                menu.orderBorder.Child = new CustomizeBriarheartBurger(menu, bb, order, combo);
            }
        }

        void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DoubleDraugr dd = new DoubleDraugr();
                combo.Entree = dd;
                menu.orderBorder.Child = new CustomizeDoubleDraugr(menu, dd, order, combo);
            }
        }

        
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                GardenOrcOmelette goo = new GardenOrcOmelette();
                combo.Entree = goo;
                menu.orderBorder.Child = new CustomizeGardenOrcOmelette(menu, goo, order, combo);
            }
        }

        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PhillyPoacher php = new PhillyPoacher();
                combo.Entree = php;
                menu.orderBorder.Child = new CustomizePhillyPoacher(menu, php, order, combo);
            }
        }

        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SmokehouseSkeleton sks = new SmokehouseSkeleton();
                combo.Entree = sks;
                menu.orderBorder.Child = new CustomizeSmokehouseSkeleton(menu, sks, order, combo);
            }
        }

        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                ThalmorTriple tt = new ThalmorTriple();
                combo.Entree = tt;
                menu.orderBorder.Child = new CustomizeThalmorTriple(menu, tt, order, combo);
            }
        }

        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                ThugsTBone ttb = new ThugsTBone();
                combo.Entree = ttb;
                menu.orderBorder.Child = new CustomizeThugsTBone(menu, ttb, order, combo);
            }
        }
        

    }
}
