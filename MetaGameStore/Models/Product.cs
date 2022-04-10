using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        [Key]
        [ForeignKey("ProductGame")]
        public int id { get; set; }
        [Required, MaxLength(50)]
        public string producer { get; set; }
        [Required, MaxLength(50)]
        public string desription { get; set; }
        [Required, MaxLength(50)]
        public string name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public Byte[] photo{ get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public ProductGame ProductGame { get; set; }
    }
}
