using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Order
    {
        [Key]
        [ForeignKey("Payment")]
        public int id { get; set; }
        
        

        public double price { get; set; }
        public DateTime date { get; set; }
        [Required, MaxLength(50)]
        public string shippingName { get; set; }
        [Required, MaxLength(50)]
        public string shippingCity { get; set; }
        [Required, MaxLength(50)]
        public string shippingAddress { get; set; }
        [Required, MaxLength(6)]
        public string shippingPostalCode { get; set; }
        [Required, MaxLength(50)]
        public string shippingCountry { get; set; }

        [ForeignKey("User")]
        public int idUser { get; set; }
        public User User { get; set; }

        ICollection<OrderDetails> OrderDetails { get; set; }

        public Payment Payment { get; set; }
    }
}
