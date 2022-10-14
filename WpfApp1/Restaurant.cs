using System;
using System.Collections.Generic;
using System.Reflection;

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

        public List<Client> getListClients () {
            return this.listClients;
        }

        public List<Employee> getListEmployees() {
            return this.listEmployees;
        }

        public List<Product> getListAllProducts() {
            return this.listAllProducts;
        }

        public List<Order> getListOrders() {
            return this.listOrders;
        }

        public Employee getEmployeesByID (int id) {
            foreach (Employee e in listEmployees)
            {
                if (e.EmployeeID == id)
                {
                    return e;
                }
            }
            return default;
        }

        public Order getOrderByID (int id)
        {
            foreach (Order o in listOrders)
            {
                if (o.orderId == id)
                {
                    return o;
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

        public List<Client> sortingClientByNameAsc ()
        {
            List<Client> listClientsSorted = listClients;
            listClientsSorted.Sort((x, y) => string.Compare(x.last_name, y.last_name));
            return listClientsSorted;
        }
    }
}