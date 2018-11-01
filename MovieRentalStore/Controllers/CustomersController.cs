using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalStore.Models;
using MovieRentalStore.ViewModel;

namespace MovieRentalStore.Controllers
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

        public ActionResult Index()
        {
            var customers = new CustomersViewModel()
            {
                Customers =  _context.Customers
            };

            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult CustomerDetails(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
     
        }

    }
}