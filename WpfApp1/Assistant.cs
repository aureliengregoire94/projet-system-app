using System;
using WpfApp1;

namespace WpfApp1{
    public class Assistant : Employee{
         public Assistant ()
        {

        }

        public void createClient(int client_phone, int order_number, string first_name, string last_name, Address address)
        {
            resto.getListClients.Add(new Client (Globals.indexClient, client_phone, order_number, first_name, last_name, address));
            Globals.indexClient +=1;
            
        }

        public void createEmployee (string Name, string type)
        {
            resto.getListEmployees.Add(Globals.indexEmployee, Name, type, this.resto);
            Globals.indexEmployee +=1;
        }

        public Order takeOrder(string clientPhoneNumber){
            Client c = resto.getClientByPhone(clientPhoneNumber);

            // creating the new order
            Order order = new Order(Globals.indexOrder, DateTime.Now, c.last_name, this.EmployeeID, orderState.preparation, 0); // 0 : delivery, how to manage that
            Globals.indexOrder +=1;

            // sending all the confirmations
            clientConfirmation(c.clientId, "Order " +order.orderId+ " in "+ order.orderState);
            kitchenConfirmation("");
            deliveryConfirmation(order.deliveryId, c.printAddress); // adding 5min delay // refer to commentary Order line
            assistantConfirmation(this.EmployeeID, this.print("Order " +order.orderId+ " in preparation"));
        }

        public void changeOrderState(Order order, OrderState orderState){
            order.orderState = orderState;
        }

        public void checkOrder(Order order){
            Console.Write(""+order.orderState+"");
        }

        public void endOrder(int orderId, int deliveryManId){
            resto.getOrderByID(orderId).orderState = OrderState.finished;
            resto.getEmployeesByID(deliveryManId).GetType(); // specification design pattern
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