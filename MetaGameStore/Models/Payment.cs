using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Range(0, 3)]
        public int PaymentType { get; set; }
        public int Ammount { get; set; }
        public DateTime Date { get; set; }
        [Range(0, 3)]
        public int Status { get; set; }

        public Order Order { get; set; }
    }
}
