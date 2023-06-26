using Dummy.Models;
using Dummy.ViewModel;
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

        public ActionResult New()
        {
            var membershipTypes = _context.MemberShipTypes.ToList();

            var newViewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes,
            };
            return View("CustomerForm", newViewModel);
        }


        [HttpPost]
        public ActionResult Save(Customers customer)
        {

            if (!ModelState.IsValid)
            {
                var customerViewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MemberShipTypes.ToList()
                };
                return View("CustomerForm", customerViewModel);
            }

            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.IsSubscriberToNewsletter = customer.IsSubscriberToNewsletter;
                customerInDb.MembershipType = customer.MembershipType;
            }
            _context.SaveChanges();

            return RedirectToAction("GetCustomer", "Customers");
        }

        public IActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return Content("404 Not found");
            }
            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MemberShipTypes.ToList()
            };
            return View("CustomerForm", viewModel); 
        }
    }
}
