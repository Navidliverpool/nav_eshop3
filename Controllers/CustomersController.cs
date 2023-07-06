using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nav_eshop3.Data;
using nav_eshop3.Models;
using nav_eshop3.ViewModels;

namespace nav_eshop3.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
              return _context.SalesCustomers != null ? 
                          View(await _context.SalesCustomers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.SalesCustomers'  is null.");
        }

        //// GET: Customers/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.SalesCustomers == null)
        //    {
        //        return NotFound();
        //    }

        //    var salesCustomer = await _context.SalesCustomers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (salesCustomer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(salesCustomer);
        //}

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email")] SalesCustomerVM salesCustomerVM)
        {
            if (ModelState.IsValid)
            {
                var salesCustomer = new SalesCustomer
                {
                    Email = salesCustomerVM.Email,
                    FirstName = salesCustomerVM.FirstName,
                    LastName = salesCustomerVM.LastName
                };
                _context.Add(salesCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesCustomerVM);
        }

        //// GET: Customers/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.SalesCustomers == null)
        //    {
        //        return NotFound();
        //    }

        //    var salesCustomer = await _context.SalesCustomers.FindAsync(id);
        //    if (salesCustomer == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(salesCustomer);
        //}

        //// POST: Customers/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email")] SalesCustomer salesCustomer)
        //{
        //    if (id != salesCustomer.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(salesCustomer);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SalesCustomerExists(salesCustomer.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(salesCustomer);
        //}

        //// GET: Customers/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.SalesCustomers == null)
        //    {
        //        return NotFound();
        //    }

        //    var salesCustomer = await _context.SalesCustomers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (salesCustomer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(salesCustomer);
        //}

        // POST: Customers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.SalesCustomers == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.SalesCustomers'  is null.");
        //    }
        //    var salesCustomer = await _context.SalesCustomers.FindAsync(id);
        //    if (salesCustomer != null)
        //    {
        //        _context.SalesCustomers.Remove(salesCustomer);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SalesCustomerExists(int id)
        //{
        //  return (_context.SalesCustomers?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
