using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental_Application.Models;

namespace Rental_Application.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.id == id);
            if (customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {id=1,CustomerName="Harsha" },
                new Customer {id=2,CustomerName="Rupesh" }

            };
        }
    }

}