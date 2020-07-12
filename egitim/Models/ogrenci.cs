using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class ogrenci
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "TC Numarası")]
        public string tcno { get; set; }
        [Display(Name = "Adınız")]
        public string ad { get; set; }
        [Display(Name = "Soyadınız")]
        public string soyad { get; set; }
        [Display(Name = "Telefon")]
        public string  telefon { get; set; }
        [Display(Name = "Tarih")]
        public string dtarih { get; set; }
        [Display(Name = "Eğitim Durumu")]
        public string egitim { get; set; }
        [Display(Name = "Burs Durumu")]
        public string burs { get; set; }
        [Display(Name = "Onay Durumu")]
        public string onay  { get; set; }
        [Display(Name = "Kayıt Durumu")]
        public string kayit { get; set; }
        [Display(Name = "Bölüm")]
        public string sube  { get; set; }
        [Display(Name = "Ders Adı")]
        public int ders_id  { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string kul{ get; set; }
        [Display(Name = "Şifre")]
        public string sifre  { get; set; }
        public ICollection<sinav> sinavs { get; set; }
        public ICollection<odev> odevs { get; set; }
        
    }
}
