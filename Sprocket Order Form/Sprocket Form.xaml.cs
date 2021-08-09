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
using System.Windows.Shapes;

namespace Sprocket_Order_Form
{
    /// <summary>
    /// Interaction logic for Sprocket_Form.xaml
    /// </summary>
    public partial class Sprocket_Form : Window
    {
        private SprocketOrder order;

        public SprocketOrder Order
        {
            get { return order; }
            set { order = value; }
        }

        public Sprocket_Form() : this(new SprocketOrder())
        {
        }

        public Sprocket_Form(SprocketOrder order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void SubBtn_Click(object sender, RoutedEventArgs e)
        {
            // Just flags the add comand to do whats in the if statement
            DialogResult = true;
            Close();
        }
    }
}
