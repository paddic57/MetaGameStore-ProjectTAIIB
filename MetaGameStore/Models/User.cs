using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Range (0,4)]
        public int UserType { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength (9)]
        public int PhoneNumber { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(6)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
