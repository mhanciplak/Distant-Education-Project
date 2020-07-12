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
    public class sinavsController : Controller
    {
        private readonly DataContext _context;

        public sinavsController(DataContext context)
        {
            _context = context;
        }

        // GET: sinavs
        public IActionResult Index()
        {
            List<sinavliste> rs3 = (from c in _context.derslers join d in _context.konulars on c.id equals d.ders_id join o in _context.sinavs on d.ders_id equals o.ders_id select new sinavliste { Dersler = c, Konular = d, Sinav = o }).ToList();
            return View(rs3);
        }

        // GET: sinavs/Details/5
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

        // GET: sinavs/Create
        public IActionResult Create()
        {
            ViewBag.message = _context.derslers.ToList();
            return View();
        }

        public JsonResult getkonugetirId(int id)
        {
            List<konular> konularim = new List<konular>();
            konularim = _context.konulars.Where(a => a.ders_id==id).ToList();
            konularim.Insert(0, new konular {id=0,konu="Konu Seçimi Yapınız" });

            return Json(new SelectList(konularim, "id", "konu"));
        }
        // POST: sinavs/Create
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

        // GET: sinavs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.message = _context.derslers.ToList();

            var sinav = await _context.sinavs.FindAsync(id);
            if (sinav == null)
            {
                return NotFound();
            }
            return View(sinav);
        }

        // POST: sinavs/Edit/5
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

        // GET: sinavs/Delete/5
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

        // POST: sinavs/Delete/5
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
