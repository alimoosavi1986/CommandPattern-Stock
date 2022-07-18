using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Stock
{
    public class OrderSell : IOrder
    {
        private Stock stock;
        public OrderSell(Stock stock)
        {
            this.stock = stock;
        }
        public string Execute()
        {
            return stock.Sell();
        }
    }

}
