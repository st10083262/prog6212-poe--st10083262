using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using progfinal11111.Data;
using progfinal11111.Models;

namespace progfinal11111.Controllers
{
    public class Class1Controller : Controller
    {
        private readonly prog6212 _context;

        public Class1Controller(prog6212 context)
        {
            _context = context;
        }

        // GET: Class1
        public async Task<IActionResult> Index()
        {
              return View(await _context.Class1.ToListAsync());
        }

        // GET: Class1/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Class1 == null)
            {
                return NotFound();
            }

            var class1 = await _context.Class1
                .FirstOrDefaultAsync(m => m.Username == id);
            if (class1 == null)
            {
                return NotFound();
            }

            return View(class1);
        }

        // GET: Class1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Class1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Username,Password")] Class1 class1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(class1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(class1);
        }

        // GET: Class1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Class1 == null)
            {
                return NotFound();
            }

            var class1 = await _context.Class1.FindAsync(id);
            if (class1 == null)
            {
                return NotFound();
            }
            return View(class1);
        }

        // POST: Class1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Username,Password")] Class1 class1)
        {
            if (id != class1.Username)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(class1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Class1Exists(class1.Username))
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
            return View(class1);
        }

        // GET: Class1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Class1 == null)
            {
                return NotFound();
            }

            var class1 = await _context.Class1
                .FirstOrDefaultAsync(m => m.Username == id);
            if (class1 == null)
            {
                return NotFound();
            }

            return View(class1);
        }

        // POST: Class1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Class1 == null)
            {
                return Problem("Entity set 'progfinal11111Context.Class1'  is null.");
            }
            var class1 = await _context.Class1.FindAsync(id);
            if (class1 != null)
            {
                _context.Class1.Remove(class1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Class1Exists(string id)
        {
          return _context.Class1.Any(e => e.Username == id);
        }

       
    }
}
