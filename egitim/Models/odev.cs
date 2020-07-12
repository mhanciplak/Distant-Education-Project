using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class odev
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Ders Adı")]
        public int ders_id  { get; set; }
        [Display(Name = "Konu Adı")]
        public int konu_id { get; set; }
        [Display(Name = "Ödev Konusu")]
        public string  odevs { get; set; }
        public dersler dersler { get; set; }
    }
}
