using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Drink : Product
    {
        protected float volume { get; set; }

        public Drink (float volume, float price, string name) {
            this.volume = volume;
            this.price = price;
            this.name = name;
        }
    }
}