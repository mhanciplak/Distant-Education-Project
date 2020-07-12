using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using egitim.Data;
using egitim.Models;

namespace egitim.Controllers
{
    public class ogrencisController : Controller
    {
        private readonly DataContext _context;

        public ogrencisController(DataContext context)
        {
            _context = context;
        }

        // GET: ogrencis
        public async Task<IActionResult> Index()
        {
            return View(await _context.ogrencis.ToListAsync());

            // List<ogrenciliste> sorgu = (from c in _context.ogrencis join d in _context.derslers on c.ders_id equals d.id select new ogrenciliste { ogrenci = c, dersler = d }).ToList();
            // return View(sorgu);
        }

        // GET: ogrencis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.ogrencis
                .FirstOrDefaultAsync(m => m.id == id);
            if (ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        }

        // GET: ogrencis/Create
        public IActionResult Create()
        {
            List<dersler> derslerim = new List<dersler>();
            derslerim = _context.derslers.ToList();
            derslerim.Insert(0,new dersler { id=0,ders="Ders Seçimi Yapınız" });
            ViewBag.message = derslerim;
            return View();
        }

        // POST: ogrencis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,tcno,ad,soyad,telefon,dtarih,egitim,burs,onay,kayit,sube,ders_id,kul,sifre")] ogrenci ogrenci)
        {
           
                _context.Add(ogrenci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
          
           
        }

        // GET: ogrencis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<dersler> derslerim = new List<dersler>();
            derslerim = (from c in _context.derslers select c).ToList();
            derslerim.Insert(0, new dersler { id = 0, ders = "Ders Seçimi Yapınız" });
            ViewBag.message = derslerim;

            var ogrenci = await _context.ogrencis.FindAsync(id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            return View(ogrenci);
        }

        // POST: ogrencis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,tcno,ad,soyad,telefon,dtarih,egitim,burs,onay,kayit,sube,ders_id,kul,sifre")] ogrenci ogrenci)
        {
            if (id != ogrenci.id)
            {
                return NotFound();
            }

            
                try
                {
                    _context.Update(ogrenci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ogrenciExists(ogrenci.id))
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

        // GET: ogrencis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.ogrencis
                .FirstOrDefaultAsync(m => m.id == id);
            if (ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        }

        // POST: ogrencis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ogrenci = await _context.ogrencis.FindAsync(id);
            _context.ogrencis.Remove(ogrenci);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ogrenciExists(int id)
        {
            return _context.ogrencis.Any(e => e.id == id);
        }
    }

   
}
