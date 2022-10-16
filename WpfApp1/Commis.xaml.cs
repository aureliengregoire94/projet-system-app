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
    /// Logique d'interaction pour Commis.xaml
    /// </summary>
    public partial class Commis : Page
    {
        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        Assistant commis = (Assistant)Application.Current.Properties["Commis"];
        public Commis()
        {
            InitializeComponent();
        }

        private void Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if(Phone.Text != null)
                {
                    Application.Current.Properties["Phone_client"] = Phone.Text;
                    if(commis.isClient(int.Parse(Phone.Text)))
                    {
                        Application.Current.Properties[Phone.Text] = commis.takeOrder(int.Parse(Phone.Text));
                        com_frame.NavigationService.Navigate(new Uri("create_order.xaml", UriKind.Relative));
                    }
                    else
                    {
                        com_frame.NavigationService.Navigate(new Uri("Employee.xaml", UriKind.Relative));
                    }
                }
            }
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (commis.isOrder(int.Parse(ID.Text)))
                {                   
                    com_frame.NavigationService.Navigate(new Uri("Order_gestion.xaml", UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("invalid id");
                    ID.Clear();
                }
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        private void overview_Click(object sender, RoutedEventArgs e)
        {
            com_frame.NavigationService.Navigate(new Uri("visualisation.xaml", UriKind.Relative));
        }
    }
}
