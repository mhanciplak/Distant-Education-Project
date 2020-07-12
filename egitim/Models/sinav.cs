using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class sinav
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Dersin Adı ")]
        public int ders_id { get; set; }
        [Display(Name = "Konu Adı ")]
        public int konu_id { get; set; }
        [Display(Name = "Test Numarası ")]
        public int test_id { get; set; }
        [Display(Name = "Soru Sırası ")]
        public int soru_sira { get; set; }
        [Display(Name = "Soru  ")]
        public string soru { get; set; }
        [Display(Name = "A Şıkkı Sorusu  ")]
        public string a { get; set; }
        [Display(Name = "B Şıkkı Sorusu  ")]
        public string b { get; set; }
        [Display(Name = "C Şıkkı Sorusu  ")]
        public string c { get; set; }
        [Display(Name = "D Şıkkı Sorusu  ")]
        public string d { get; set; }
        [Display(Name = "E Şıkkı Sorusu  ")]
        public string e { get; set; }
        public string cevap { get; set; }
        [Display(Name = "E Şıkkı Sorusu  ")]
        public ogrenci ogrenci { get; set; }
        public konular konular { get; set; }
    }
}
