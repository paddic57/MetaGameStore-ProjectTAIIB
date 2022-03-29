using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class OrderDetails
    {
        public int idOrder { get; set; }
        public int idProduct { get; set; }
        public double productPrice { get; set; }
        public int productCount { get; set; }
        public int productDiscount { get; set; }
    }
}
