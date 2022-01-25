using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Classes
{
    public class OrderManager
    {
        public static Order CreateOrder(dynamic data)
        {
            Order newOrder = new Order();
            newOrder.userName = data.userName;
            newOrder.address = data.address;
            newOrder.productName = data.productName;
            newOrder.price = data.price;
            newOrder.compName = data.compName;
            return newOrder;
        }
    }
}
