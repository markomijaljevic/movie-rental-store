using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieRentalStore.Models;

namespace MovieRentalStore.ViewModel
{
    public class CustomersViewModel
    {
        public DbSet<Customer> Customers { get; set; }
    }
}