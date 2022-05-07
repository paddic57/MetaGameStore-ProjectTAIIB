using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public double Price { get; set; }
        public DateTime Date { get; set; }
        [Required, MaxLength(50)]
        public string ShippingName { get; set; }
        [Required, MaxLength(50)]
        public string ShippingCity { get; set; }
        [Required, MaxLength(50)]
        public string ShippingAddress { get; set; }
        [Required, MaxLength(6)]
        public string ShippingPostalCode { get; set; }
        [Required, MaxLength(50)]
        public string ShippingCountry { get; set; }

        public User User { get; set; }

        ICollection<OrderDetails> OrderDetails { get; set; }

        [ForeignKey("Payment")]
        public int IdPayment { get; set; }
        public Payment Payment { get; set; }
    }
}
