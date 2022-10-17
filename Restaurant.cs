using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using System.IO;
using System.Text;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Restaurant
    {
        public List<Client> listClients = new List<Client>();
        public List<Employee> listEmployees = new List<Employee>();
        public List<Product> listAllProducts = new List<Product>();
        public List<Order> listOrders = new List<Order>();

        public Restaurant()
        {
            //listEmployees.Add(new DeliveryMan("default delivery", EmployeeType.delivery, this));
        }
        public Pizza AddPizza(PizzaType type, PizzaGarnishment garni, PizzaSize size)
        {
            float price = 0;
            string name = "";
            // defining the base pizza price
            switch (type)
            {
                case PizzaType.margarita:
                    price = 10;
                    name = "margarita";
                    break;
                case PizzaType.napolitana:
                    price = 12;
                    name = "napolitana";
                    break;
                case PizzaType.regina:
                    price = 14;
                    name = "regina";
                    break;
                default:
                    price = 1;
                    break;
            }
            // putting a ratio related to the size
            switch (size)
            {
                case PizzaSize.small:
                    price *= 1;
                    name += " small ";
                    break;
                case PizzaSize.medium:
                    price *= (float)1.2;
                    name += " medium ";
                    break;
                case PizzaSize.big:
                    price *= (float)1.5;
                    name += " big ";
                    break;
                default:
                    price *= 1;
                    break;
            }
            // putting a bonus related to the garnishment
            switch (garni)
            {
                case PizzaGarnishment.tomatoSauce:
                    price *= 1;
                    name += " tomato sauce ";
                    break;
                case PizzaGarnishment.cheese:
                    price += 2;
                    name += " cheese ";
                    break;
                case PizzaGarnishment.vege:
                    price += 2;
                    name += " vege ";
                    break;
                case PizzaGarnishment.allGarnish:
                    price += 3;
                    name += " allGarnish ";
                    break;
                default:
                    price *= 1;
                    break;
            }
            return (new Pizza(price, size, garni, name));
        }
        public Drink AddDrink(DrinkType type)
        {
            // putting a bonus related to the garnishment
            float price;
            float volume;
            string name;
            switch (type)
            {
                case DrinkType.coca:
                    price = 2;
                    volume = (float)0.33;
                    name = "coca " + volume + "L";
                    break;
                case DrinkType.bear:
                    price = 4;
                    volume = (float)0.5;
                    name = "bear " + volume + "L";
                    break;
                case DrinkType.water:
                    price = 1;
                    volume = (float)1;
                    name = "water " + volume + "L";
                    break;
                default:
                    price = 1;
                    volume = 1;
                    name = "";
                    break;
            }
            return (new Drink(volume, price, name));
        }

        public List<Client> getListClients()
        {
            return this.listClients;
        }

        public List<Employee> getListEmployees()
        {
            return this.listEmployees;
        }

        public List<Product> getListAllProducts()
        {
            return this.listAllProducts;
        }

        public List<Order> getListOrders()
        {
            return this.listOrders;
        }

        public Employee getEmployeesByID(int id)
        {
            foreach (Employee e in listEmployees)
            {
                if (e.EmployeeID == id)
                {
                    return e;
                }
            }
            return default;
        }
        public Client getClientByID(int id)
        {
            foreach (Client c in listClients)
            {
                if (c.clientId == id)
                {
                    return c;
                }
            }
            return default;
        }

        public Client getClientByPhone(int tel)
        {
            return listClients.Find(r => r.Client_phone == tel);
        }

        public Order getOrderById(int id)
        {
            return listOrders.Find(r => r.orderId == id);
        }
        public List<Client> sortingClientByNameAsc()
        {
            List<Client> listClientsSorted = listClients;
            listClientsSorted.Sort((x, y) => string.Compare(x.last_name, y.last_name));
            return listClientsSorted;
        }

        public List<Client> sortingClientByCity()
        {
            List<Client> listClientsSorted = listClients;
            listClientsSorted.Sort((x, y) => string.Compare(x.address.city, y.address.city));
            return listClientsSorted;
        }


        public List<Order> getAllOrdersFromClient (int telClient)
        {
            Client c = getClientByPhone(telClient);
            List<Order> listOrders = new List<Order>();
            foreach (Order o in listOrders)
            {
                if (o.clientId == c.clientId)
                {
                    listOrders.Add(o);
                }
            }
            return listOrders;
        }

        /*public Dictionary<int, float> sortingClientByOrders ()
        {
            var clientsXsumSpent = new Dictionary<int, float>();
            foreach (Client c in listClients)
            {
                List<Order> orderOfClients = new List<Order>();
                foreach (Order o in listOrders)
                {
                    if (o.clientId == c.clientId)
                    {
                        orderOfClients.Add(o);
                    }
                }

                float sumOrders = 0;
                foreach (Order o in orderOfClients)
                {
                    foreach (Product p in o.listProducts)
                    {
                        sumOrders += p.price;
                    }
                    Console.WriteLine("\n id " + c.clientId + "," + sumOrders);
                    clientsXsumSpent.Add(c.clientId, sumOrders);
                }   
            }
            return (Dictionary<int, float>) clientsXsumSpent.OrderBy(key => key.Value);
        }*/

        public void addOrderWithFile(string path)
        {
            string fileContent = File.ReadAllText(path, Encoding.UTF8);

        }

        public void preparationOrder(Order o)
        {

            foreach (Product p in o.listProducts)
            {
                System.Threading.Thread.Sleep(5000);
            }
            o.orderState = OrderState.delivering;
        }
    }
}