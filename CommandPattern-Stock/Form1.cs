using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern_Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OrderBroker broker = new OrderBroker();
                OrderBuy buy = new OrderBuy(new Stock() { Cnt = 10, Name = "Egg" });
                OrderSell sell = new OrderSell(new Stock() { Cnt = 5, Name = "Egg" });
                broker.AddOrder(buy);
                broker.AddOrder(sell);
                var orderList = broker.PlaceOrders();

                foreach (var item in orderList)
                {
                    listBox1.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
