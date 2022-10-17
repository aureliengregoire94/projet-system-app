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
    /// Logique d'interaction pour order_gestion.xaml
    /// </summary>
    public partial class order_gestion : Page
    {

        string order_id = (string)Application.Current.Properties["Order_toset"];
        Assistant commis = (Assistant)Application.Current.Properties["Commis"];
        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        public order_gestion()
        {
            InitializeComponent();
        }

        private void validation_Click(object sender, RoutedEventArgs e)
        {
            Order ord = restau.getOrderById(int.Parse(order_id));

            OrderState ord_s;

            switch (Status.Text)
            {
                case "preparation":
                    ord_s = OrderState.preparation;
                    break;
                case "napolitana":
                    ord_s = OrderState.delivering;
                    break;
                case "finished":
                    ord_s = OrderState.finished;
                    break;
                default:
                    ord_s = OrderState.preparation;
                    break;
            }

            commis.changeOrderState(ord, ord_s);

            this.NavigationService.Navigate("Commis.xaml");
        }
    }
}
