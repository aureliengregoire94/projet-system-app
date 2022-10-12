using System;

namespace WpfApp1{
    public class DeliveryMan : Employee {

        //
        public void sendConfirmation(Order order){
            order.orderState = OrderState.finished;
            // increase client's honored order by 1
        }
        
    }
}