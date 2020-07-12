using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egitim.Models
{
    public class odevliste
    {
        public dersler Dersler { get; set; }
        public konular Konular { get; set; }
        public ogrenci Ogrenci { get; set; }

        public odev Odev { get; set; }
    }
}
