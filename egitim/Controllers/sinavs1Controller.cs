using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using egitim.Data;
using egitim.Models;
using Microsoft.AspNetCore.Http;

namespace egitim.Controllers
{
    public class sinavs1Controller : Controller
    {
        private readonly DataContext _context;

        public sinavs1Controller(DataContext context)
        {
            _context = context;
        }

        // GET: sinavs1
        public IActionResult Index()
        {
           string ders =HttpContext.Session.GetString("ders_id");
            int dersim = int.Parse(ders);
            //List<sinavliste> rs2 = (from k in _context.konulars  join sv in _context.sinavs on k.id equals sv.konu_id select new sinavliste {Konular=k,Sinav=sv }).ToList() ;

            List<sinavliste> rs2 = (from c in _context.konulars join d in _context.derslers on c.ders_id equals d.id where d.id==dersim  select new sinavliste {Konular=c, Dersler=d }).ToList();


            return View(rs2);
        }
        [HttpGet]
        public IActionResult sinavgor(int id)
        {
            var r3 =_context.sinavs.Where(x=>x.konu_id==id).ToList();
            return View(r3);
        }
        [HttpPost]
        public IActionResult kayit([Bind("id,cevap")] sinav sinav)
        {
            sinav tablo = new sinav();
            for(int i=0;i<sinav.cevap.Length;i++)
            {
                string cevabim = sinav.cevap[i].ToString();
            }
            return View();
        }

        // GET: sinavs1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinav = await _context.sinavs
                .FirstOrDefaultAsync(m => m.id == id);
            if (sinav == null)
            {
                return NotFound();
            }

            return View(sinav);
        }

        // GET: sinavs1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sinavs1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ders_id,konu_id,test_id,soru_sira,soru,a,b,c,d,e,cevap")] sinav sinav)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinav);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sinav);
        }

        // GET: sinavs1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinav = await _context.sinavs.FindAsync(id);
            if (sinav == null)
            {
                return NotFound();
            }
            return View(sinav);
        }

        // POST: sinavs1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ders_id,konu_id,test_id,soru_sira,soru,a,b,c,d,e,cevap")] sinav sinav)
        {
            if (id != sinav.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinav);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sinavExists(sinav.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sinav);
        }

        // GET: sinavs1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinav = await _context.sinavs
                .FirstOrDefaultAsync(m => m.id == id);
            if (sinav == null)
            {
                return NotFound();
            }

            return View(sinav);
        }

        // POST: sinavs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sinav = await _context.sinavs.FindAsync(id);
            _context.sinavs.Remove(sinav);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sinavExists(int id)
        {
            return _context.sinavs.Any(e => e.id == id);
        }
    }
}
