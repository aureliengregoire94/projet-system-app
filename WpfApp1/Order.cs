using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Order
    {
        protected integer orderId { get; set; }
        protected date hour { get; set; }
        protected string clientName { get; set; }
        protected string assistantName { get; set; }
        protected string orderState { get; set; }
        protected List<Product> ListProducts { get => listProducts; set => listProducts = value; }
        
        Order (integer orderId, date hour, string clientName, string assistantName, string orderState, List<Product> ListProducts) {
            this.orderId = orderId;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantName = assistantName;
            this.orderState = orderState;
            this.ListProducts = ListProducts;
        }

        Order (integer orderId, date hour, string clientName, string assistantName, string orderState) {
            this.orderId = orderId;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantName = assistantName;
            this.orderState = orderState;
        }
    }
}