using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductGame
    {
        [Key]
        public int Id { get; set; }
        [Range(0,5)]
        public int GameType { get; set; }
        public DateTime Premiere { get; set; }
        public string Pegi { get; set; }
        [Range(0, 4)]
        public int Platform { get; set; }
        public string GameMode { get; set; }

        public Product Product { get; set; }    


    }
}
