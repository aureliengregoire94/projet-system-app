using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Product
    {
        protected float price { get; set; }

        Product (float price) {
            this.price = price;
        }
    }
}