using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class cevaplar
    {
        [Key]
        public int id { get; set; }
        public int ogrenci_id { get; set; }
        public int konu_id { get; set; }
        public int test_id { get; set; }
        public int soru_sira { get; set; }
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }
        public string e { get; set; }
        public string sonuc { get; set; }

    }
}
