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
    public class NLNController : Controller
    {
        private readonly ApplicationDBContext _context;

        public NLNController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: NLN
        public async Task<IActionResult> Index()
        {
            return View(await _context.NLN_1.ToListAsync());
        }

        // GET: NLN/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nLN = await _context.NLN_1
                .FirstOrDefaultAsync(m => m.HDID == id);
            if (nLN == null)
            {
                return NotFound();
            }

            return View(nLN);
        }

        // GET: NLN/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NLN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NLNID,University,HDID,HDName")] NLN nLN)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nLN);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nLN);
        }

        // GET: NLN/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nLN = await _context.NLN_1.FindAsync(id);
            if (nLN == null)
            {
                return NotFound();
            }
            return View(nLN);
        }

        // POST: NLN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NLNID,University,HDID,HDName")] NLN nLN)
        {
            if (id != nLN.HDID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nLN);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NLNExists(nLN.HDID))
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
            return View(nLN);
        }

        // GET: NLN/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nLN = await _context.NLN_1
                .FirstOrDefaultAsync(m => m.HDID == id);
            if (nLN == null)
            {
                return NotFound();
            }

            return View(nLN);
        }

        // POST: NLN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nLN = await _context.NLN_1.FindAsync(id);
            _context.NLN_1.Remove(nLN);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NLNExists(string id)
        {
            return _context.NLN_1.Any(e => e.HDID == id);
        }
    }
}
