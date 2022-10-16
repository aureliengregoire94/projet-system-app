using System;
using System.Collections.Generic;
using System.Drawing;

namespace WpfApp1
{
    public class Assistant : Employee{
         public Assistant (string Name, EmployeeType type, Restaurant resto)
         {
            this.resto = resto;
            this.EmployeeID = Globals.indexEmployee;
            Globals.indexEmployee += 1;
            this.Name = Name;
            this.type = type;
         }

        // verifying in the restaurant db ( getClientByPhone ) is the client ( client_phone ) exists
        public Boolean isClient (int client_phone)
        {
            if (resto.getClientByPhone (client_phone) != null)
            {
                return true;
            }
            return false;
        }

        public void createClient(int client_phone, string first_name, string last_name, int number, string streetname, string city)
        {
            Address address = new Address(number, streetname, city);
            resto.getListClients().Add(new Client (client_phone, first_name, last_name, address));
            
        }

        public void createEmployee (string Name, EmployeeType type)
        {
            resto.getListEmployees().Add( new Employee(Name, type, this.resto) );
        }

        public Order takeOrder(int clientPhoneNumber){
            Client c = resto.getClientByPhone(clientPhoneNumber);

            // creating the new order
            Order order = new Order(DateTime.Now, c.last_name, c.clientId, this.EmployeeID, OrderState.preparation, 0); // 0 : delivery, how to manage that
            // TODO add the products
            resto.getListOrders().Add(order);

            // sending all the confirmations
            clientConfirmation(c.clientId, "Order " +order.orderId+ " in "+ order.orderState);
            kitchenConfirmation(order.listProducts);
            //deliveryConfirmation(order); // adding 5min delay // refer to commentary Order line
            assistantConfirmation(this.EmployeeID, "Order " +order.orderId+ " in preparation");

            return order;
        }

        public void changeOrderState(Order order, OrderState orderState){
            order.orderState = orderState;
        }

        public void checkOrder(Order order){
            Console.Write(""+order.orderState+"");
        }

        public void endOrder(int orderId, int deliveryManId){

            Order o = resto.getOrderByID(orderId);
            o.orderState = OrderState.finished;
            Employee e = resto.getEmployeesByID(deliveryManId);
            if (e.type == EmployeeType.delivery)
            {

                ((DeliveryMan)e).sendConfirmation(o);
            }
            else
            {
                print("error " + o.deliveryId + " is not an deliveryman");
            }
        }

        public void clientConfirmation (int clientId, string message) {
            resto.getClientByID(clientId).print(message);
        }

        public void kitchenConfirmation (List<Product> products) {
            foreach (Product p in products)
            {
                print("\n" + p.name);
            }
        }

        public void deliveryConfirmation (Order order) {
            Employee e = resto.getEmployeesByID(order.deliveryId);
            if (e.type == EmployeeType.delivery)
            {
                ((DeliveryMan)e).sendConfirmation(order);
            }
            else
            {
                print("error " + order.deliveryId + " is not an deliveryman");
            }
        }

        public void assistantConfirmation (int employeeId, string message) {
            resto.getEmployeesByID(employeeId).print(message);
        }
        public void addPizzaToOrder (PizzaType type, PizzaGarnishment garni, PizzaSize size, Order order)
        {
            order.listProducts.Add(resto.AddPizza(type, garni, size));
        }
        public void addDrinkToOrder(DrinkType type, Order order)
        {
            order.listProducts.Add(resto.AddDrink(type));
        }

    }
}