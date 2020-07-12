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
    public class odevsController : Controller
    {
        private readonly DataContext _context;

        public odevsController(DataContext context)
        {
            _context = context;
        }

        // GET: odevs
        public IActionResult Index()
        {
           

            List<tumodevliste> rs3 = (from c in _context.derslers join d in _context.konulars on c.id equals d.ders_id join o in _context.odevs on d.ders_id equals o.ders_id select new tumodevliste { Dersler = c, Konular = d, Odev = o }).ToList();

            return View(rs3);
        }

        // GET: odevs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odev = await _context.odevs
                .FirstOrDefaultAsync(m => m.id == id);
            if (odev == null)
            {
                return NotFound();
            }

            return View(odev);
        }

        // GET: odevs/Create
        public IActionResult Create()
        {
            List<dersler> derslerim = new List<dersler>();
            derslerim = (from c in _context.derslers select c).ToList();
            derslerim.Insert(0, new dersler { id = 0, ders = "Ders Seçimi Yapınız" });
            ViewBag.message = derslerim;
            return View();
        }
        public JsonResult getkonugetirId(int id)
        {
            List<konular> konularim = new List<konular>();
            konularim = _context.konulars.Where(a => a.ders_id == id).ToList();
            konularim.Insert(0, new konular { id = 0, konu = "Konu Seçimi Yapınız" });

            return Json(new SelectList(konularim, "id", "konu"));
        }
        // POST: odevs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ders_id,konu_id,odevs")] odev odev)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odev);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(odev);
        }

        // GET: odevs/Edit/5
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
            var odev = await _context.odevs.FindAsync(id);
            if (odev == null)
            {
                return NotFound();
            }
            return View(odev);
        }

        // POST: odevs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ders_id,konu_id,odevs")] odev odev)
        {
            if (id != odev.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odev);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!odevExists(odev.id))
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
            return View(odev);
        }

        // GET: odevs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odev = await _context.odevs
                .FirstOrDefaultAsync(m => m.id == id);
            if (odev == null)
            {
                return NotFound();
            }

            return View(odev);
        }

        // POST: odevs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var odev = await _context.odevs.FindAsync(id);
            _context.odevs.Remove(odev);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool odevExists(int id)
        {
            return _context.odevs.Any(e => e.id == id);
        }
    }
}
