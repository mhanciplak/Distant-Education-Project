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
    public class canlisogrenciController : Controller
    {
        private readonly DataContext _context;

        public canlisogrenciController(DataContext context)
        {
            _context = context;
        }

        // GET: canlisogrenci
        public async Task<IActionResult> Index()
        {

            return View(await _context.canli.ToListAsync());
        }

        // GET: canlisogrenci/Details/5
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

        // GET: canlisogrenci/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: canlisogrenci/Create
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

        // GET: canlisogrenci/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canli = await _context.canli.FindAsync(id);
            if (canli == null)
            {
                return NotFound();
            }
            return View(canli);
        }

        // POST: canlisogrenci/Edit/5
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

        // GET: canlisogrenci/Delete/5
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

        // POST: canlisogrenci/Delete/5
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
