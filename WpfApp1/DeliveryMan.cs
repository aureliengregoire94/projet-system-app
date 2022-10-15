using System;

namespace WpfApp1
{
    public class DeliveryMan : Employee {

        //
        public void sendConfirmation(Order order){
            order.orderState = OrderState.finished;
            resto.getClientByID(order.clientId).completed_orders += 1;
        }

        public DeliveryMan(string Name, string type, Restaurant resto)
        {
            this.resto = resto;
            this.EmployeeID = Globals.indexEmployee;
            Globals.indexEmployee += 1;
            this.Name = Name;
            this.type = type;
        }
    }
}