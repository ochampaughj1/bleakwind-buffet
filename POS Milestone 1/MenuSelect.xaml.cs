/* Author: Jonathan Ochampaugh
 * Class Name: MenuSelect.cs
 * Purpose: Switches between screens based on buttons clicked
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using POS_Milestone_1.Drinks;
using POS_Milestone_1.Entrees;
using POS_Milestone_1.Sides;
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

namespace POS_Milestone_1
{
    /// <summary>
    /// Interaction logic for MenuSelect.xaml
    /// </summary>
    public partial class MenuSelect : UserControl
    {
        /// <summary>
        /// Initializes the menu ButtonControlComponent, the receipt CurrentOrderControlComponent, and sets the button menu border to menu and sets the receipt border to the receipt
        /// </summary>
        public MenuSelect()
        {
            InitializeComponent();
            ButtonControlComponent menu = new ButtonControlComponent(this);
            CurrentOrderControlComponent receipt = new CurrentOrderControlComponent(this);
            orderBorder.Child = menu;
            currentOrderBorder.Child = receipt;
        }
    }
}
