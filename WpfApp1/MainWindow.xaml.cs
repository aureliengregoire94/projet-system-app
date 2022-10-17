using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
            Restaurant lapizza_delamama = new Restaurant();

            Assistant commissaire = new Assistant("Larbin", EmployeeType.assistant, lapizza_delamama);

            commissaire.createEmployee("esclave", EmployeeType.delivery);

            Application.Current.Properties["Restau"] = lapizza_delamama;
            Application.Current.Properties["Commis"] = commissaire;
            InitializeComponent();
        }
        
        private void Validation_Click(object sender, RoutedEventArgs e)
        {

            if (Cli.IsChecked == true)
            {

                MessageBox.Show("welcome");
                mainFrame.NavigationService.Navigate(new Uri("Client-interface.xaml", UriKind.Relative));
            }
            else if (Emp.IsChecked == true)
            {
                MessageBox.Show("Enter the employee Code");

                TextBox txt = new TextBox();
                txt.Name = "employee";
                Thickness margin = txt.Margin;
                margin.Left = 280;
                margin.Top = 300;
                margin.Bottom = 194;
                txt.Width = 170;
                txt.Height = 20;

                txt.KeyDown += new KeyEventHandler(PressEnter);

                interface1.Children.Add(txt);
            }
        }

        private void PressEnter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextBox txt = (TextBox)sender;
                MessageBox.Show(txt.Text);

                if(txt.Name == "delivery")
                {
                    if(int.Parse(txt.Text) == 1234)
                    {
                        interface1.Children.Remove(txt);
                        mainFrame.NavigationService.Navigate(new Uri("DeliveryMan.xaml", UriKind.Relative));
                    }
                        
                }
                if(txt.Name == "employee")
                {
                    if(int.Parse(txt.Text) == 0000)
                    {
                        interface1.Children.Remove(txt);
                        mainFrame.NavigationService.Navigate(new Uri("Commis.xaml", UriKind.Relative));
                    }
                }
            }
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
