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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Client_interface.xaml
    /// </summary>
    public partial class Client_interface : Page
    {
        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        public Client_interface()
        {
            InitializeComponent();
        }

        private void TextBox_Keydown (object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextBox txt = (TextBox)sender;
                if(txt.Text != null)
                {
                    List<Order> ur_orders = restau.getAllOrdersFromClient(int.Parse(txt.Text));
                    if(ur_orders != null && ur_orders.Any())
                    {
                        string affichage = "";
                        foreach (Order order in ur_orders)
                        {
                            affichage += "{ " + order.orderId + ", " + order.clientId + ", " + order.deliveryId + ", " + order.assistantId + ", " + order.calculPrice() + "$ } \n";

                        }
                        MessageBox.Show(affichage);
                    }
                    else
                    {
                        MessageBox.Show("no order to ur name");
                    }
                }
                else
                {
                    MessageBox.Show("enter valid input");
                }
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
