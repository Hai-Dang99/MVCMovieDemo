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
    public class YoungController : Controller
    {
        private readonly ApplicationDBContext _context;

        public YoungController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Young
        public async Task<IActionResult> Index()
        {
            return View(await _context.Youngs.ToListAsync());
        }

        // GET: Young/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var young = await _context.Youngs
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (young == null)
            {
                return NotFound();
            }

            return View(young);
        }

        // GET: Young/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Young/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("YoungID,University,PersonID,PersonName")] Young young)
        {
            if (ModelState.IsValid)
            {
                _context.Add(young);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(young);
        }

        // GET: Young/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var young = await _context.Youngs.FindAsync(id);
            if (young == null)
            {
                return NotFound();
            }
            return View(young);
        }

        // POST: Young/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("YoungID,University,PersonID,PersonName")] Young young)
        {
            if (id != young.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(young);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YoungExists(young.PersonID))
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
            return View(young);
        }

        // GET: Young/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var young = await _context.Youngs
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (young == null)
            {
                return NotFound();
            }

            return View(young);
        }

        // POST: Young/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var young = await _context.Youngs.FindAsync(id);
            _context.Youngs.Remove(young);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YoungExists(string id)
        {
            return _context.Youngs.Any(e => e.PersonID == id);
        }
    }
}
