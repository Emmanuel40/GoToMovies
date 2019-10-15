using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidiFlex.Models;
namespace VidiFlex.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Details(int id)
        {
            var customer = new List<Customer>
            { new Customer{Name = "John Smith" },
              new Customer{Name = "Mary Williams" }
            };
            return View(customers);
        }
    }
}