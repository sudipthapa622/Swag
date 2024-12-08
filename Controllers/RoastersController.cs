using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Swag.Data;
using Swag.Models;

namespace Swag.Controllers
{
    public class RoastersController : Controller
    {
        private readonly SwagContext _context;

        public RoastersController(SwagContext context)
        {
            _context = context;
        }

        // GET: Roasters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Roaster.ToListAsync());
        }

        // GET: Roasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roaster = await _context.Roaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roaster == null)
            {
                return NotFound();
            }

            return View(roaster);
        }

        // GET: Roasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeName,StartDate,StartTime,EndDate,EndTime,Role,BreakStartTime,BreakEndTime")] Roaster roaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roaster);
        }

        // GET: Roasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roaster = await _context.Roaster.FindAsync(id);
            if (roaster == null)
            {
                return NotFound();
            }
            return View(roaster);
        }

        // POST: Roasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeName,StartDate,StartTime,EndDate,EndTime,Role,BreakStartTime,BreakEndTime")] Roaster roaster)
        {
            if (id != roaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoasterExists(roaster.Id))
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
            return View(roaster);
        }

        // GET: Roasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roaster = await _context.Roaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roaster == null)
            {
                return NotFound();
            }

            return View(roaster);
        }

        // POST: Roasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roaster = await _context.Roaster.FindAsync(id);
            if (roaster != null)
            {
                _context.Roaster.Remove(roaster);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoasterExists(int id)
        {
            return _context.Roaster.Any(e => e.Id == id);
        }
    }
}
