using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Drink : Product
    {
        protected String name { get; set; }
        protected float volume { get; set; }

        Drink (float volume, String name, float price) {
            this.name = name;
            this.volume = volume;
            this.price = price;
        }
    }
}