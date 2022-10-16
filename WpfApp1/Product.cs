using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Product
    {
        public float price { get; set; }
        public string name { get; set; }

        public Product (float price, string name) {
            this.price = price;
            this.name = name;
        }

        public Product () {

        }
    }
}