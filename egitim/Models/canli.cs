using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class canli
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Dersin Adı")]
        
        public int ders_id  { get; set; }
        [Display(Name = "Link Adı")]
       

        public string link  { get; set; }
        [Display(Name = "Tarihi")]
        [Required(ErrorMessage = "Tarih Giriniz")]
        public string tarih  { get; set; }
        
        public dersler dersler { get; set; }
    }
}
