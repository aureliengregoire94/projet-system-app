using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Order
    {
        protected integer orderId;
        protected date hour;
        protected string clientName;
        protected string assistantName;
        protected string orderState;
        protected List<Product> ListProducts = new List<Product>();
    }
}