using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class dersler
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Dersin Adı")]
        public string ders { get; set; }
        public ICollection<konular> konulars { get; set; }
        public ICollection<sinav> sinavs { get; set; }
        public ICollection<odev> odevs { get; set; }
        public ICollection<canli> canli { get; set; }
    }
}
