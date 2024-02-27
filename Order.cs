using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10
{
    internal class Order
    {
        public int id { get; set; }
        public int number { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public string day_order { get; set; }
        public string day_delivery { get; set; }
        public string pickup_point { get; set; }
        public string user { get; set; }
        public int code { get; set; }
        public string status { get; set; }
    }
}
