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
    /// Logique d'interaction pour Deliveryman.xaml
    /// </summary>
    public partial class Deliveryman : Page
    {
        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        Assistant commis = (Assistant)Application.Current.Properties["Commis"];       
        public Deliveryman()
        {            
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        private void validation_Click(object sender, RoutedEventArgs e)
        {
            if(txtb.Text != null)
            {
                
            }
        }

        private void cancellation_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
