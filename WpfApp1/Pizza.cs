using System;

namespace WpfApp1 // Note: actual namespace depends on the project name.
{
    public class Pizza : Product
    {
        protected String type { get; set; }
        protected String size { get; set; }

        public Pizza (String type, float price, String size) {
            this.type = type;
            this.price = price;
            this.size = size;
        }
    }
}