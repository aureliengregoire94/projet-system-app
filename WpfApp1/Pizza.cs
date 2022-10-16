using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Pizza : Product
    {
        public PizzaSize size { get; set; }
        public PizzaGarnishment type { get; set; }
        public Pizza (float price, PizzaSize size, PizzaGarnishment type, string name) {
            this.price = price;
            this.size = size;
            this.type = type;
            this.name = name;
        }
    }
}