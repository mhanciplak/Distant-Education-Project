using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class sinav_durum
    {
        [Key]
        public int id { get; set; }
        public int ogrenci_id { get; set; }
        public int ders_id { get; set; }
        public int konu_id { get; set; }
        public int durum { get; set; }
        public int onay { get; set; }
        public ogrenci ogrenci { get; set; }
        public dersler dersler { get; set; }
        public konular konular { get; set; }


    }
}
