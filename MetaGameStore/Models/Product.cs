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
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Producer { get; set; }
        [Required, MaxLength(50)]
        public string Desription { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Byte[] Photo{ get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public ProductGame ProductGame { get; set; }
    }
}
