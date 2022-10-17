using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Order
    {
        public int orderId { get; set; }
        public int clientId { get; set; }
        protected DateTime hour { get; set; }
        protected string clientName { get; set; }
        public int assistantId { get; set; }
        public OrderState orderState { get; set; } // check #OrderState to see the differents states
        public List<Product> listProducts = new List<Product>();
        public int deliveryId { get; set; }

        public Order(DateTime hour, string clientName, int clientId, int assistantId, OrderState orderState, int deliveryId)
        {
            this.orderId = Globals.indexOrder;
            Globals.indexOrder += 1;
            this.hour = hour;
            this.clientName = clientName;
            this.assistantId = assistantId;
            this.orderState = orderState;
            this.clientId = clientId;
            this.deliveryId = deliveryId;

        }
        public string calculPrice()
        {
            float sum = 0;
            foreach (Product p in listProducts)
            {
                sum += p.price;
            }
            return "commande number " + this.orderId + " price : " +sum;
        }
    }
}