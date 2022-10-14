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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void validation_Click(object sender, RoutedEventArgs e)
        {
            if(Cli.IsChecked == true)
            {
                MessageBox.Show("Enter the order ID");
            }
            else if(Own.IsChecked == true)
            {
                MessageBox.Show("Enter the owner code");
            }
            else if(Emp.IsChecked == true)
            {
                MessageBox.Show("Enter the employee Code");
            }
            else if(Deliv.IsChecked == true)
            {
                MessageBox.Show("Enter the Delivery Code");
            }

        }
    }
}
