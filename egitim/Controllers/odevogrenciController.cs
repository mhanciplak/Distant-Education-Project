using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using egitim.Data;
using egitim.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
namespace egitim.Controllers
{
    public class odevogrenciController : Controller
    {
        private readonly DataContext _context;

        public odevogrenciController (DataContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            int ders =Convert.ToInt32(HttpContext.Session.GetString("ders_id"));

            List<odevliste> rs2 =(from p in _context.derslers join pc in _context.konulars on p.id equals pc.ders_id join c in _context.ogrencis on pc.ders_id equals c.ders_id where c.ders_id==ders select new odevliste  { Ogrenci = c, Dersler = p,Konular = pc}).ToList();

            //List<odevliste> rs2 = (from c in _context.ogrencis join d in _context.konulars on c.id equals d.ders_id select new odevliste { Ogrenci = c, Konular = d }).ToList();
            return View(rs2);
        }
        public IActionResult Edit(int? id)
        {
             int ders =Convert.ToInt32(HttpContext.Session.GetString("ders_id"));
            if (id == null)
            {
                return NotFound();
            }
            List<dersler> derslerim = new List<dersler>();
            derslerim = (from c in _context.derslers select c).ToList();
            derslerim.Insert(0, new dersler { id = 0, ders = "Ders Seçimi Yapınız" });
            ViewBag.message = derslerim;


            var odev = _context.odevs.Where(x => x.ders_id == ders && x.id == id).SingleOrDefault();
            if (odev == null)
            {
                return NotFound();
            }
            return View(odev);
        }

    }
}