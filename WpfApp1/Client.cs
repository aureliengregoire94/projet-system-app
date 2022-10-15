using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Client
    {
        public int Client_phone;
        public int order_number;
        public string first_name;
        public string last_name;
        public Address address;
        public int completed_orders;
        public int clientId;

        public Client(int client_phone, int order_number, string first_name, string last_name, Address address)
        {
            this.clientId = Globals.indexClient;
            Globals.indexClient += 1;
            this.Client_phone = client_phone;
            this.order_number = order_number;
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.completed_orders = 0;
        }

        public Client()
        {

        }

        public void print (string message)
        {
            // printing message argument in the GUI
        }

        public string printAddress ()
        {
            return first_name + " " + last_name + "\n " +address.number + " " +address.streetname+ ", " +address.city;
        }

    }
}
