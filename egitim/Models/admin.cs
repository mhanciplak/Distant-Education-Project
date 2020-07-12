using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class admin
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Kullanıcı Adı")]
        public string kul { get; set; }
        [Display(Name = "Şifreniz")]
        public string sifre { get; set; }
    }
}
