using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class konular
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Dersin Adı")]
        public int ders_id { get; set; }
        [Display(Name = "Konu Adı")]
        public string konu { get; set; }
        [Display(Name = "Youtube Yolu")]
        public string youtube { get; set; }
        public string video { get; set; }
        public string dokuman { get; set; }
        [Display(Name = "Sınav Durumu")]
        public int sinav { get; set; }
        [Display(Name = "Sıra Numarası")]
        public int sira { get; set; }
        public dersler dersler { get; set; }

    }
}
