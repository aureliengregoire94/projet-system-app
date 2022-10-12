using System;
using System.Collections.Generic;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Order
    {
        protected int orderId { get; set; }
        protected int clientId { get; set; }
        protected DateTime hour { get; set; }
        protected string clientName { get; set; }
        protected int assistantId  { get; set; }
        public OrderState orderState { get; set; } // check #OrderState to see the differents states
        protected List<Product> listProducts = new List<Product>();
        protected int deliveryId { get; set; }

        public Order (int deliveryId, int orderId, DateTime hour, string clientName, int clientId, int assistantId , OrderState orderState) {
            this.orderId = orderId;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantId = assistantId;
            this.orderState = orderState;
            this.clientId = clientId;
            this.deliveryId = deliveryId;
        }

        Boolean clientConfirmation () {
            return true;
        }

        List<Pizza> kitchenConfirmation () {
            return default;
        }

        Address deliveryConfirmation (int idClient) {
            return default;
        }

        Order assistantConfirmation () {
            return this;
        }


    }
}