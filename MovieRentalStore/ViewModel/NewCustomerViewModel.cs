using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentalStore.Models;

namespace MovieRentalStore.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}