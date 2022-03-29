using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Product
    {
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
    }
}
