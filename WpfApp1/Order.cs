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
        protected string assistantName { get; set; }
        protected string orderState { get; set; }
        protected List<Product> listProducts = new List<Product>();

        public Order (int orderId, DateTime hour, string clientName, int clientId, string assistantName, string orderState) {
            this.orderId = orderId;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantName = assistantName;
            this.orderState = orderState;
            this.clientId = clientId;
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