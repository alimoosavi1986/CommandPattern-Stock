using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Stock
{
    public class OrderBroker
    {
        private List<IOrder> ordersList;
        public OrderBroker()
        {
            ordersList = new List<IOrder>();
        }

        public void AddOrder(IOrder order)
        {
            ordersList.Add(order);
        }

        public List<string> PlaceOrders()
        {
            List<string> lst = new List<string>();

            foreach (var item in ordersList)
            {
                lst.Add(item.Execute());
            }
            ordersList.Clear();
            return lst;
        }
    }

}
