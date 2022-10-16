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
                    
                }
            }
        }
    }
}
