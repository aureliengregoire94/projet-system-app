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
    /// Logique d'interaction pour visualisation.xaml
    /// </summary>
    public partial class visualisation : Page
    {

        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        Assistant commis = (Assistant)Application.Current.Properties["Commis"];
        public visualisation()
        {
            InitializeComponent();
        }

        private void abc_Click(object sender, RoutedEventArgs e)
        {
            List<Client> listclient = restau.sortingClientByNameAsc();
            String affichage = "";
            foreach (Client client in listclient)
            {
                affichage += client.printClientInfos() + "\n";
            }
            MessageBox.Show(affichage);
        }

        private void clients_by_town_Click(object sender, RoutedEventArgs e)
        {
            List<Client> listclient = restau.sortingClientByCity();
            String affichage = "";
            foreach (Client client in listclient)
            {
                affichage += client.printClientInfos() + "\n";
            }
            MessageBox.Show(affichage);
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {
            List<Order> ListOrder = restau.getListOrders();
            String affichage = "{ Order ID, Client ID, Delivery ID, Assistant ID, Prix total } \n";
            foreach (Order order in ListOrder)
            {
                affichage += "{ " + order.orderId + ", " + order.clientId + ", " + order.deliveryId + ", " + order.assistantId + ", " + order.calculPrice() + "$ } \n";

            }
            MessageBox.Show(affichage);
        }
    }
}
