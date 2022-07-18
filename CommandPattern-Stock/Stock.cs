using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Stock
{
    public class Stock
    {
        public int Cnt { get; set; }
        public string Name { get; set; }

        public string Sell()
        {
            return "Information Selling Order = Cont:"+Cnt+" Name:"+Name;
        }
        public string Buy()
        {
            return "Information Buying Order = Cont:" + Cnt + " Name:" + Name;
        }
    }

}
