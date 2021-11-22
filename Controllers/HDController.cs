using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Data;
using MVCMovie.Models;

namespace MVCMovie.Controllers
{
    public class HDController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HDController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: HD
        public async Task<IActionResult> Index()
        {
            return View(await _context.HD.ToListAsync());
        }

        // GET: HD/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hD = await _context.HD
                .FirstOrDefaultAsync(m => m.HDID == id);
            if (hD == null)
            {
                return NotFound();
            }

            return View(hD);
        }

        // GET: HD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HDID,HDName")] HD hD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hD);
        }

        // GET: HD/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hD = await _context.HD.FindAsync(id);
            if (hD == null)
            {
                return NotFound();
            }
            return View(hD);
        }

        // POST: HD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HDID,HDName")] HD hD)
        {
            if (id != hD.HDID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HDExists(hD.HDID))
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
            return View(hD);
        }

        // GET: HD/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hD = await _context.HD
                .FirstOrDefaultAsync(m => m.HDID == id);
            if (hD == null)
            {
                return NotFound();
            }

            return View(hD);
        }

        // POST: HD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hD = await _context.HD.FindAsync(id);
            _context.HD.Remove(hD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HDExists(string id)
        {
            return _context.HD.Any(e => e.HDID == id);
        }
    }
}
