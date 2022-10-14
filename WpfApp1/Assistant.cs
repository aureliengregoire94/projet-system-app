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

        public void endOrder(int orderId, int deliveryManId){
            resto.getOrderByID(orderId).orderState = OrderState.finished;
            resto.getEmployeesByID(deliveryManId).GetType(); // specification design pattern
        }

    }
}