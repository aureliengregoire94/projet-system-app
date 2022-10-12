using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public enum OrderState
    {
        preparation, // Chef is cooking the meal
        delivering, // DeliveryMan is delivering the meal
        finished, // Order is delivered
        canceled, // Order is done, but there was a problem
    }
}
