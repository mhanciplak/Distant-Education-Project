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
    public class derslersController : Controller
    {
        private readonly DataContext _context;

        public derslersController(DataContext context)
        {
            _context = context;
        }

        // GET: derslers
        public async Task<IActionResult> Index()
        {
            return View(await _context.derslers.ToListAsync());
        }

        // GET: derslers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersler = await _context.derslers
                .FirstOrDefaultAsync(m => m.id == id);
            if (dersler == null)
            {
                return NotFound();
            }

            return View(dersler);
        }

        // GET: derslers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: derslers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ders")] dersler dersler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dersler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dersler);
        }

        // GET: derslers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersler = await _context.derslers.FindAsync(id);
            if (dersler == null)
            {
                return NotFound();
            }
            return View(dersler);
        }

        // POST: derslers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ders")] dersler dersler)
        {
            if (id != dersler.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dersler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!derslerExists(dersler.id))
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
            return View(dersler);
        }

        // GET: derslers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dersler = await _context.derslers
                .FirstOrDefaultAsync(m => m.id == id);
            if (dersler == null)
            {
                return NotFound();
            }

            return View(dersler);
        }

        // POST: derslers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dersler = await _context.derslers.FindAsync(id);
            _context.derslers.Remove(dersler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool derslerExists(int id)
        {
            return _context.derslers.Any(e => e.id == id);
        }
    }
}
