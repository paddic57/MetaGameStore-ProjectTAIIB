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
        public double ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public int ProductDiscount { get; set; }

        [ForeignKey("Order")]
        public int IdOrder { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }
        public Product Product{ get; set; }
    }
}
