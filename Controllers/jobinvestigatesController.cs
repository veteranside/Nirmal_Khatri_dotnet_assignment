using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nirmal_Khatri_dotnet_assignment.Data;
using Nirmal_Khatri_dotnet_assignment.Models;

namespace Nirmal_Khatri_dotnet_assignment.Controllers
{
    public class jobinvestigatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public jobinvestigatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: jobinvestigates
        public async Task<IActionResult> Index()
        {
            return View(await _context.jobinvestigate.ToListAsync());
        }

        // GET: jobinvestigates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobinvestigate = await _context.jobinvestigate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobinvestigate == null)
            {
                return NotFound();
            }

            return View(jobinvestigate);
        }

        // GET: jobinvestigates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: jobinvestigates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,PhoneNumber,Post,Salary")] jobinvestigate jobinvestigate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobinvestigate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobinvestigate);
        }

        // GET: jobinvestigates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobinvestigate = await _context.jobinvestigate.FindAsync(id);
            if (jobinvestigate == null)
            {
                return NotFound();
            }
            return View(jobinvestigate);
        }

        // POST: jobinvestigates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,PhoneNumber,Post,Salary")] jobinvestigate jobinvestigate)
        {
            if (id != jobinvestigate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobinvestigate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!jobinvestigateExists(jobinvestigate.Id))
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
            return View(jobinvestigate);
        }

        // GET: jobinvestigates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobinvestigate = await _context.jobinvestigate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobinvestigate == null)
            {
                return NotFound();
            }

            return View(jobinvestigate);
        }

        // POST: jobinvestigates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobinvestigate = await _context.jobinvestigate.FindAsync(id);
            if (jobinvestigate != null)
            {
                _context.jobinvestigate.Remove(jobinvestigate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool jobinvestigateExists(int id)
        {
            return _context.jobinvestigate.Any(e => e.Id == id);
        }
    }
}
