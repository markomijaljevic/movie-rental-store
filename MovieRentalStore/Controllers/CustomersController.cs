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
        // GET: Customers

        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Lucas Mora"},
                new Customer {Id = 2, Name = "Mark Mora"},
                new Customer {Id = 3, Name = "Thomas Neil"}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };
            
            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult CustomerDetails(int id)
        {

            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Lucas Mora"},
                new Customer {Id = 2, Name = "Mark Mora"},
                new Customer {Id = 3, Name = "Thomas Neil"}
            };

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                    return View(customer);
            }

            return HttpNotFound();
        }

    }
}