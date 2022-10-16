using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Logique d'interaction pour employee.xaml
    /// </summary>
    public partial class employee : Page
    {

        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        Assistant commis = (Assistant)Application.Current.Properties["Commis"];
        public employee()
        {
            InitializeComponent();
        }

        private void addclient_Click(object sender, RoutedEventArgs e)
        {
            int datac = 0;
            if(Phone.Text != null)
            {
                datac += 1;               
            }
            int phone = int.Parse(Phone.Text);           
            if (fst_name.Text != null)
            {
                datac += 1;               
                
            }
            string surname = fst_name.Text;
            if (lst_name.Text != null)
            {
                datac += 1;
                
            }
            string name = lst_name.Text;
            if (city.Text != null)
            {
                datac += 1;
                
            }
            string town = city.Text;
            if (Street_name.Text != null)
            {
                datac += 1;
                
            }
            string streetname = Street_name.Text;
            if (h_num.Text != null)
            {
                datac += 1;
                
            }
            int house = int.Parse(h_num.Text);
            if (datac == 6)
            {

                commis.createClient(phone, surname, name, house, streetname, town);
                MessageBox.Show("New Client " + surname + " " + name + " Created");
                Phone.Clear();
                fst_name.Clear();
                lst_name.Clear();
                city.Clear();
                Street_name.Clear();
                h_num.Clear();
            }
                
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
    
}
