using System;

namespace WpfApp1
{
    public class Assistant : Employee{
         public Assistant (string Name, string type, Restaurant resto)
         {
            this.resto = resto;
            this.EmployeeID = Globals.indexEmployee;
            Globals.indexEmployee += 1;
            this.Name = Name;
            this.type = type;
         }

        public void createClient(int client_phone, int order_number, string first_name, string last_name, int number, string streetname, string city)
        {
            Address address = new Address(number, streetname, city);
            resto.getListClients().Add(new Client (client_phone, order_number, first_name, last_name, address));
            
        }

        public void createEmployee (string Name, string type)
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
            kitchenConfirmation("");
            //deliveryConfirmation(order.deliveryId, c.printAddress()); // adding 5min delay // refer to commentary Order line
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
            resto.getOrderByID(orderId).orderState = OrderState.finished;
            //resto.getEmployeesByID(deliveryManId).GetType(); // specification design pattern
        }

        public void clientConfirmation (int clientId, string message) {
            resto.getClientByID(clientId).print(message);
        }

        public void kitchenConfirmation (string message) {
            // printing message argument in the GUI
        }

        public void deliveryConfirmation (int employeId, string message) {
            resto.getEmployeesByID(employeId).print(message);
        }

        public void assistantConfirmation (int employeeId, string message) {
            resto.getEmployeesByID(employeeId).print(message);
        }

    }
}


