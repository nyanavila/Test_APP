using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting.Models;

namespace Accounting.Controllers
{
    public class GeneralJournalsController : Controller
    {
        private readonly GeneralJournalContext _context;

        public GeneralJournalsController(GeneralJournalContext context)
        {
            _context = context;    
        }

        // GET: GeneralJournals
        public async Task<IActionResult> Index()
        {
            return View(await _context.GeneralJournal.ToListAsync());
        }

        // GET: GeneralJournals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalJournal = await _context.GeneralJournal
                .SingleOrDefaultAsync(m => m.ID == id);
            if (generalJournal == null)
            {
                return NotFound();
            }

            return View(generalJournal);
        }

        // GET: GeneralJournals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralJournals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Date,Description,PostRef,Debit,Credit")] GeneralJournal generalJournal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalJournal);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(generalJournal);
        }

        // GET: GeneralJournals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalJournal = await _context.GeneralJournal.SingleOrDefaultAsync(m => m.ID == id);
            if (generalJournal == null)
            {
                return NotFound();
            }
            return View(generalJournal);
        }

        // POST: GeneralJournals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,Description,PostRef,Debit,Credit")] GeneralJournal generalJournal)
        {
            if (id != generalJournal.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalJournal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralJournalExists(generalJournal.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(generalJournal);
        }

        // GET: GeneralJournals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalJournal = await _context.GeneralJournal
                .SingleOrDefaultAsync(m => m.ID == id);
            if (generalJournal == null)
            {
                return NotFound();
            }

            return View(generalJournal);
        }

        // POST: GeneralJournals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalJournal = await _context.GeneralJournal.SingleOrDefaultAsync(m => m.ID == id);
            _context.GeneralJournal.Remove(generalJournal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool GeneralJournalExists(int id)
        {
            return _context.GeneralJournal.Any(e => e.ID == id);
        }
    }
}
