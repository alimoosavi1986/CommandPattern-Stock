using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Stock
{
    public class OrderBuy : IOrder
    {
        private Stock stock;
        public OrderBuy(Stock stock)
        {
            this.stock = stock;
        }
        public string Execute()
        {
            return stock.Buy();
        }
    }

}
