using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoToMovies.Models;

namespace GoToMovies.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}