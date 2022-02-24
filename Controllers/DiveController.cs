#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scuba_Dive_Log.Data;
using Scuba_Dive_Log.Models;

namespace Scuba_Dive_Log.Controllers
{
    public class DiveController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiveController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dive
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiveLog.ToListAsync());
        }

        // GET: Dive/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dive = await _context.DiveLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dive == null)
            {
                return NotFound();
            }

            return View(dive);
        }

        // GET: Dive/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dive/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DiveSite,DiveDate,DiveBuddy,DiveType,MaxDepth,DiveTime,WaterType,BodyOfWater,Weather,WaterTemperature,Visibility,Waves,Current,Surge,SuitType,Weight,Weighting,CylinderType")] Dive dive)
        {

            if (ModelState.IsValid)
            {
                dive.Id = Guid.NewGuid();
                _context.Add(dive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dive);
        }

        // GET: Dive/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dive = await _context.DiveLog.FindAsync(id);
            if (dive == null)
            {
                return NotFound();
            }
            return View(dive);
        }

        // POST: Dive/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,DiveSite,DiveDate,DiveBuddy,DiveType,MaxDepth,DiveTime,WaterType,BodyOfWater,Weather,WaterTemperature,Visibility,Waves,Current,Surge,SuitType,Weight,Weighting,CylinderType")] Dive dive)
        {
            if (id != dive.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiveExists(dive.Id))
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
            return View(dive);
        }

        // GET: Dive/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dive = await _context.DiveLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dive == null)
            {
                return NotFound();
            }

            return View(dive);
        }

        // POST: Dive/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var dive = await _context.DiveLog.FindAsync(id);
            _context.DiveLog.Remove(dive);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiveExists(Guid id)
        {
            return _context.DiveLog.Any(e => e.Id == id);
        }
    }
}
