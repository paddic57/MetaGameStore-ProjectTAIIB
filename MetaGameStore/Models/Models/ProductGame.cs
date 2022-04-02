using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProductGame
    {
        [Key]
        public int Id { get; set; }
        [Range(0,5)]
        public int game_type { get; set; }
        public DateTime premiere { get; set; }
        public string pegi { get; set; }
        [Range(0, 4)]
        public int platform { get; set; }
        public string game_mode { get; set; }

        public Product Product { get; set; }    


    }
}
