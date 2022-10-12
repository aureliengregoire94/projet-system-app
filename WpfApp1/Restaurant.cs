using System;
using System.Collections.Generic;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Restaurant
    {
        public List<Client> listClients = new List<Client>();
        public List<Employee> listEmployees = new List<Employee>();
        public List<Product> listAllProducts = new List<Product>();
        public List<Order> listOrders = new List<Order>();

        public Restaurant () {

        }
    }
}