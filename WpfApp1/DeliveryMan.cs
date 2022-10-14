using System;

namespace WpfApp1{
    public class DeliveryMan : Employee {

        //
        public void sendConfirmation(Order order){
            order.orderState = OrderState.finished;
            resto.getClientByID(order.clientId).completed_orders += 1;
        }

        public void print (string message)
        {
            // printing message argument in the GUI
        }
        
    }
}