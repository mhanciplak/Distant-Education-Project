using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using egitim.Models;
using Microsoft.Extensions.Configuration;
using egitim.Data;
using Microsoft.AspNetCore.Session;
using System.Text;
using System.Net.Sockets;
using Microsoft.AspNetCore.Http;

namespace egitim.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(string kul, string sifre)
        {
            var sorgu = _context.ogrencis.Where(x => x.kul == kul && x.sifre == sifre).SingleOrDefault();
            if(sorgu!=null)
            {
                string ders = Convert.ToString(sorgu.ders_id);
                HttpContext.Session.SetString("kul", kul);
                HttpContext.Session.SetString("ders_id", ders);
                return RedirectToAction("Index", "main");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        public IActionResult admin()
        {
           
            ViewData["Message"] = "Your application description page.";

            return View();
        }

       [HttpPost]
        public IActionResult adminlogin(string kul, string sifre)
        {
            var sorgu = _context.admins.Where(x => x.kul == kul && x.sifre == sifre).SingleOrDefault();
            if (sorgu != null)
            {
                var bytes = Encoding.UTF8.GetBytes(kul);
                HttpContext.Session.Set("kul", bytes);

                return RedirectToAction("admin", "main");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult Cikis()
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
