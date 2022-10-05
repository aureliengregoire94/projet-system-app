using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Product
    {
        protected float price { get; set; }

        public Product (float price) {
            this.price = price;
        }

        public Product () {

        }
    }
}