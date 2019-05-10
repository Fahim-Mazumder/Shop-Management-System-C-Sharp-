using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management
{
    class Receipt
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double SellingPrice { get; set; }
        public string Total { get { return string.Format("{0}$", SellingPrice * Quantity); } }

    }
}
