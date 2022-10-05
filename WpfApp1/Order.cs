using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Order
    {
        protected int orderId { get; set; }
        protected int clientId { get; set; }
        protected DateTime hour { get; set; }
        protected string clientName { get; set; }
        protected string assistantName { get; set; }
        protected string orderState { get; set; }
        protected List<Product> ListProducts { get => listProducts; set => listProducts = value; }

        Order (int orderId, date hour, string clientName, int idClient, string assistantName, string orderState, List<Product> ListProducts) {
            this.orderId = orderId;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantName = assistantName;
            this.orderState = orderState;
            this.ListProducts = ListProducts;
            this.clientId = idClient;
        }

        Order (int orderId, date hour, string clientName, int idClient, string assistantName, string orderState) {
            this.orderId = orderId;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantName = assistantName;
            this.orderState = orderState;
            this.clientId = idClient;
        }

        Boolean clientConfirmation () {
            return true;
        }

        List<Pizza> kitchenConfirmation () {
            return new List<Pizza>();
        }

        Address deliveryConfirmation (int idClient) {
            return default;
        }

        Order assistantConfirmation () {
            return this;
        }


    }
}