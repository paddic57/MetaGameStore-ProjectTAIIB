using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Range (0,4)]
        public int user_type { get; set; }
        [MaxLength(50)]
        public string username { get; set; }
        [MaxLength(50)]
        public string password { get; set; }
        [MaxLength(50)]
        public string email { get; set; }
        [MaxLength (9)]
        public int phone_number { get; set; }
        [MaxLength(50)]
        public string city { get; set; }
        [MaxLength(6)]
        public string postal_code { get; set; }
        [MaxLength(50)]
        public string address { get; set; }
        [MaxLength(50)]
        public string country { get; set; }

        
    }
}
