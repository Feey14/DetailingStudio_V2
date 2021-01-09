using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DetailingStudio_v2.Data;
using DetailingStudio_v2.Models;

namespace DetailingStudio_v2.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Services)
                .Include(o => o.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            // order.ApplicationUser = await _context.Users.FirstOrDefaultAsync(m => m.Id == order.ApplicationUserId);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.services = await _context.Services.ToListAsync();
            ViewBag.affiliates = await _context.Affiliates.ToListAsync();

            Order order = new Order();

            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);
                
                order.Email = user.Email;
                order.FirstName = user.Name;
                order.LastName = user.Surname;
                order.PhoneNumber = user.PhoneNumber;
            }

            return View(order);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderDate,OrderPaymentStatus,TotalPrice,OrderDetails,OrderStatus,CustomerID,CarBodyType,OrderStartTime,OrderEndTime,ServiceIds,AffiliateId,CustomerID")] Order order)
        {
            ViewBag.affiliates = await _context.Affiliates.ToListAsync();
            ViewBag.services = await _context.Services.ToListAsync();
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    order.ApplicationUserId = _userManager.GetUserId(User);
                    order.ApplicationUser = await _userManager.GetUserAsync(User);
                }

                order.OrderEndTime = order.OrderStartTime;

                foreach(var serviceId in order.ServiceIds)
                {
                    var service = await _context.Services
                    .FirstOrDefaultAsync(m => m.Id == serviceId);
                    if (service == null)
                    {
                        return NotFound();
                    }
                    order.OrderEndTime = order.OrderEndTime.AddHours(service.OrderExecutionTime);
                    order.Services.Add(service);
                    order.TotalPrice += service.Price;
                }

                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderDate,OrderPaymentStatus,TotalPrice,OrderDetails,OrderStatus,CustomerID,CarBodyType,OrderStartTime,OrderEndTime")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }

        public async Task<string> GetData(int[] ids)
        {
            if (ids.Any()){
                decimal price = 0.00M;

                foreach (var id in ids) 
                {
                    var service = await _context.Services.FirstOrDefaultAsync(m => m.Id == id);
                    price += (decimal)service.Price;
                }

                var teste = String.Format("{0:0.00}", price);

                return String.Format("{0:0.00}", price);
            }
            return string.Empty;
        }
    }
}
