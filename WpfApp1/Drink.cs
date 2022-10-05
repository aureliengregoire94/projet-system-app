using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Drink : Product
    {
        protected String name;
        protected float volume;

        Drink (float volume, String name, float price) {
            this.name = name;
            this.volume = volume;
            this.price = price;
        }
    }
}