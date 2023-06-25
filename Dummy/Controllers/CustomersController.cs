using Dummy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Dummy.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Customers/GetCustomer")]
        public ActionResult GetCustomer()
        {

            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult Detail(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return Content("HttpNotFound");

            return View(customer);
        }
    }
}
