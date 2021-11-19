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
    public class LHDController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LHDController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LHD
        public async Task<IActionResult> Index()
        {
            var applicationDBContext = _context.LHD.Include(l => l.Category);
            return View(await applicationDBContext.ToListAsync());
        }

        // GET: LHD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD = await _context.LHD
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.LHDID == id);
            if (lHD == null)
            {
                return NotFound();
            }

            return View(lHD);
        }

        // GET: LHD/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID");
            return View();
        }

        // POST: LHD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LHDID,LHDName,CategoryID")] LHD lHD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lHD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", lHD.CategoryID);
            return View(lHD);
        }

        // GET: LHD/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD = await _context.LHD.FindAsync(id);
            if (lHD == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", lHD.CategoryID);
            return View(lHD);
        }

        // POST: LHD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LHDID,LHDName,CategoryID")] LHD lHD)
        {
            if (id != lHD.LHDID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lHD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LHDExists(lHD.LHDID))
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
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", lHD.CategoryID);
            return View(lHD);
        }

        // GET: LHD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHD = await _context.LHD
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.LHDID == id);
            if (lHD == null)
            {
                return NotFound();
            }

            return View(lHD);
        }

        // POST: LHD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lHD = await _context.LHD.FindAsync(id);
            _context.LHD.Remove(lHD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LHDExists(int id)
        {
            return _context.LHD.Any(e => e.LHDID == id);
        }
    }
}
