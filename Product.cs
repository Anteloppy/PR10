using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10
{
    internal class Product
    {
        public int id { get; set; }
        public string vendor_code { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public decimal price { get; set; }
        public int max_disc { get; set; }
        public string provider { get; set; }
        public string manufacturer { get; set; }
        public string category { get; set; }
        public int cur_disc { get; set; }
        public int quantity_in_stock { get; set; }
        public string description { get; set; }
        public string picture { get; set; }
    }
}
