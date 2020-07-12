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
    public class konularsController : Controller
    {
        private readonly DataContext _context;

        public konularsController(DataContext context)
        {
            _context = context;
        }

        // GET: konulars
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.konulars.ToListAsync());

        }

        // GET: konulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konular = await _context.konulars
                .FirstOrDefaultAsync(m => m.id == id);
            if (konular == null)
            {
                return NotFound();
            }

            return View(konular);
        }

        // GET: konulars/Create
        public IActionResult Create()
        {
            List<dersler> derslerim = new List<dersler>();
            derslerim = (from c in _context.derslers select c).ToList();
            derslerim.Insert(0, new dersler { id = 0, ders = "Ders Seçimi Yapınız" });
            ViewBag.message = derslerim;
            return View();
        }


        // POST: konulars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ders_id,konu,youtube,video,dokuman,sinav,sira")] konular konular)
        {
            
                _context.Add(konular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
           
        }

        // GET: konulars/Edit/5
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

            var konular = await _context.konulars.FindAsync(id);
            if (konular == null)
            {
                return NotFound();
            }
            return View(konular);
        }

        // POST: konulars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ders_id,konu,youtube,video,dokuman,sinav,sira")] konular konular)
        {
            if (id != konular.id)
            {
                return NotFound();
            }

            
                try
                {
                    _context.Update(konular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!konularExists(konular.id))
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

        // GET: konulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var konular = await _context.konulars
                .FirstOrDefaultAsync(m => m.id == id);
            if (konular == null)
            {
                return NotFound();
            }

            return View(konular);
        }

        // POST: konulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var konular = await _context.konulars.FindAsync(id);
            _context.konulars.Remove(konular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool konularExists(int id)
        {
            return _context.konulars.Any(e => e.id == id);
        }
    }
}
