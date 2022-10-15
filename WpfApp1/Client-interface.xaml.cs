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
        public Client_interface()
        {
            InitializeComponent();
        }

        private void TextBox_Keydown (object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextBox txt = (TextBox)sender;
                MessageBox.Show(txt.Text);
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }
    }
}
