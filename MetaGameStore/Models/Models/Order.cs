using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Order
    {
        public int id { get; set; }
        public int idPayment { get; set; }
        public int idUser { get; set; }

        public double price { get; set; }
        public DateTime date { get; set; }
        public string shippingName { get; set; }
        public string shippingCity { get; set; }
        public string shippingAddress { get; set; }
        public string shippingPostalCode { get; set; }
        public string shippingCountry { get; set; }
    }
}
