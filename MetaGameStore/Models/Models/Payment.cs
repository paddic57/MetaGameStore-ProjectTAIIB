using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Payment
    {
        [Key]
        public int id { get; set; }
        [Range(0, 3)]
        public int paymentType { get; set; }
        public int ammount { get; set; }
        public DateTime date { get; set; }
        [Range(0, 3)]
        public int status { get; set; }

        public Order order { get; set; }
    }
}
