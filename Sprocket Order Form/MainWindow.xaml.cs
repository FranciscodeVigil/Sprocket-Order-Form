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

namespace Sprocket_Order_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SprocketOrder order = new();
        public MainWindow()
        {
            InitializeComponent();
            OrderList.ItemsSource = order.Items;
        }
        //Visibility toggle
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                AddressStuff.Visibility = Visibility.Hidden;
        }

        private void LocalCkb_Unchecked(object sender, RoutedEventArgs e)
        {
               AddressStuff.Visibility = Visibility.Visible;
        }
        //I tried to add it to the Lits box here but it wasn't working
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Sprocket_Form sprocketForm = new(order);
            sprocketForm.ShowDialog();
            if (sprocketForm.DialogResult == true)
            {
                //Defined address for order
                SprocketOrder order = sprocketForm.Order;
                order.Address = new Address();
                order.Address.Street = StreetTbx.Text;
                order.Address.City = CityTxb.Text;
                order.Address.State = StateTxb.Text;
                order.Address.ZipCode = ZipTxb.Text;

                switch (sprocketForm.ComboBox.SelectedItem)
                {
                    case "Aluminum":
                        AluminumSprocket aluminumSprocket = new(Convert.ToInt32(sprocketForm.IDTxb.Text), Convert.ToInt32(sprocketForm.NumITbx.Text), Convert.ToInt32(sprocketForm.NumTTxb.Text));
                        order.Items.Add(aluminumSprocket);
                        break;
                    case "Steel":
                        SteelSprocket steelSprocket = new(Convert.ToInt32(sprocketForm.IDTxb.Text), Convert.ToInt32(sprocketForm.NumITbx.Text), Convert.ToInt32(sprocketForm.NumTTxb.Text));
                        order.Items.Add(steelSprocket);
                        break;
                    case "Plastic":
                        PlasticSprocket plasticSprocket = new(Convert.ToInt32(sprocketForm.IDTxb.Text), Convert.ToInt32(sprocketForm.NumITbx.Text), Convert.ToInt32(sprocketForm.NumTTxb.Text));
                        order.Items.Add(plasticSprocket);
                        break;
                }
                //Something wrong here
                OrderList.ItemsSource = order.Items;
                OrderList.Items.Refresh();
            }

            else
            {
                MessageBox.Show("Item(s) canceld");
            }
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
