using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for NumberBox.xaml
    /// </summary>
    public partial class NumberBox : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Creates a dependency property for Value of the number box
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumberBox), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

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
        /// Gets and sets the current value of the Numberbox
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set 
            { 
                SetValue(ValueProperty, value);
                OnPropertyChanged("Value");
            }
        }

        public NumberBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event to increment the current value in the NumberBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void IncrementButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Value++;
        }

        /// <summary>
        /// Click event to decrement the current value in the NumberBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DecrementButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            if(Value > 0)
            {
                Value--;
            }
            else
            {
                Value = 0;
            }
        }
    }
}
