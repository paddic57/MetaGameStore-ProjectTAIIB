using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Product
    {
        public int id { get; set; }
        public string producer { get; set; }
        public string desription { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public Byte[] photo{ get; set; }
    }
}
