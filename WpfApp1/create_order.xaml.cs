using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
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
using System.Xml.Linq;


namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour create_order.xaml
    /// </summary>
    public partial class create_order : Page
    {
        Restaurant restau = (Restaurant)Application.Current.Properties["Restau"];
        Assistant commis = (Assistant)Application.Current.Properties["Commis"];
        Order orders = (Order)Application.Current.Properties[(String)Application.Current.Properties["Phone_client"]];

        public create_order()
        {
            ///pizza_types.ItemsSource = Enum.GetValues(typeof(PizzaType)).Cast<PizzaType>();
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        private void validation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(orders.calculPrice() + "$");
            restau.preparationOrder(orders);
        }

        private void validateFood_Click(object sender, RoutedEventArgs e)
        {
            if (pizza_types.Text != "Pizza flavours" || Pizzasizes.Text != "Pizza Sizes" || Pizzagar.Text != "Pizza Garnishments")
            {
                PizzaType piz_t;
                PizzaSize piz_s;
                PizzaGarnishment piz_g;

                switch(pizza_types.Text)
                {
                    case "margarita":
                        piz_t = PizzaType.margarita;
                        break;
                    case "napolitana":                        
                        piz_t = PizzaType.napolitana;
                        break;
                    case "regina":
                        piz_t = PizzaType.regina;
                        break;
                    default:
                        piz_t = PizzaType.margarita;
                        break;
                }

                switch (Pizzasizes.Text)
                {
                    case "small":
                        piz_s = PizzaSize.small;
                        break;
                    case "medium":
                        piz_s = PizzaSize.medium;
                        break;
                    case "big":
                        piz_s = PizzaSize.big;
                        break;
                    default:
                        piz_s = PizzaSize.small;
                        break;
                }

                switch (Pizzagar.Text)
                {
                    case "tomatoSauce":
                        piz_g = PizzaGarnishment.tomatoSauce;
                        break;
                    case "cheese":
                        piz_g = PizzaGarnishment.cheese;
                        break;
                    case "vege":
                        piz_g = PizzaGarnishment.vege;
                        break;
                    case "allGarnish":
                        piz_g = PizzaGarnishment.allGarnish;
                        break;
                    default:
                        piz_g = PizzaGarnishment.tomatoSauce;
                        break;
                }

                MessageBox.Show("Pizza Validated");

                orders.listProducts.Add(restau.AddPizza(piz_t, piz_g, piz_s));
            }
                
        }

        private void validateDrink_Click(object sender, RoutedEventArgs e)
        {
            if(drinks.Text != null)
            {
                DrinkType dd;
                switch (drinks.Text)
                {
                    case "coca":
                        dd = DrinkType.coca;
                        break;
                    case "bear":
                        dd = DrinkType.bear;
                        break;
                    case "water":
                        dd = DrinkType.water;
                        break;
                    default:
                        dd = DrinkType.water;
                        break;
                }

                MessageBox.Show("Drink validated");

                orders.listProducts.Add(restau.AddDrink(dd));
            }
        }
    }
}


