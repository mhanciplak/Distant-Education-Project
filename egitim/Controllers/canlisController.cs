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
    public class canlisController : Controller
    {
        private readonly DataContext _context;

        public canlisController(DataContext context)
        {
            _context = context;
        }

        // GET: canlis
        public async Task<IActionResult> Index()
        {
            return View(await _context.canli.ToListAsync());
        }

        // GET: canlis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canli = await _context.canli
                .FirstOrDefaultAsync(m => m.id == id);
            if (canli == null)
            {
                return NotFound();
            }

            return View(canli);
        }

        // GET: canlis/Create
        public IActionResult Create()
        {

            List<dersler> derslerim = new List<dersler>();
            derslerim = (from c in _context.derslers select c).ToList();
            derslerim.Insert(0, new dersler { id = 0, ders = "Ders Seçimi Yapınız" });
            ViewBag.message = derslerim;
            return View();
        }

        // POST: canlis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ders_id,link,tarih")] canli canli)
        {
            if (ModelState.IsValid)
            {
                _context.Add(canli);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(canli);
        }

        // GET: canlis/Edit/5
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

            var canli = await _context.canli.FindAsync(id);
            if (canli == null)
            {
                return NotFound();
            }
            return View(canli);
        }

        // POST: canlis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ders_id,link,tarih")] canli canli)
        {
            if (id != canli.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(canli);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!canliExists(canli.id))
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
            return View(canli);
        }

        // GET: canlis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canli = await _context.canli
                .FirstOrDefaultAsync(m => m.id == id);
            if (canli == null)
            {
                return NotFound();
            }

            return View(canli);
        }

        // POST: canlis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var canli = await _context.canli.FindAsync(id);
            _context.canli.Remove(canli);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool canliExists(int id)
        {
            return _context.canli.Any(e => e.id == id);
        }
    }
}
