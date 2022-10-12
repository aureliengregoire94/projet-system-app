using System;

namespace WpfApp1{
    public class Assistant : Employee{

        public Order takeOrder(string clientPhoneNumber){
            return default;
        }

        public void changeOrderState(Order order, OrderState orderState){
            order.orderState = orderState;
        }

        public void checkOrder(Order order){
            Console.Write(order.ToString());
        }

        public void endOrder(int orderId, string deliveryId){
            // Restaurant.listOrders.Find(i => i.orderId == orderId).orderState = finished; BUG
            //Restaurant.listEmployees.Find(j=>j.EmployeeID).print("");
        }

    }
}