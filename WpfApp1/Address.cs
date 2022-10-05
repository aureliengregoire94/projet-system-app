using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Address
    {
        public int number;
        public string streetname; 
        public string city;

        public Address(int number, string streetname, string city)
        {
            this.number = number;
            this.streetname = streetname;
            this.city = city;
        }
    }
}
