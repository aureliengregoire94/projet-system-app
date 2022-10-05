using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    internal class Pizza : Product
    {
        protected String type { get; set; }
        protected String size { get; set; }

        Drink (String type, String name, String size) {
            this.name = name;
            this.type = type;
            this.size = size;
        }
    }
}