using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public double productPrice { get; set; }
        public int productCount { get; set; }
        public int productDiscount { get; set; }

        [ForeignKey("Order")]
        public int idOrder { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]
        public int idProduct { get; set; }
        public Product Product{ get; set; }
    }
}
