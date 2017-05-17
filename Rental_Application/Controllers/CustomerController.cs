using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental_Application.Models;
using System.Data.Entity;

namespace Rental_Application.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ViewResult Index()
        {
            var customer = _context.Customers.Include(c=>c.MemberShipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=>c.MemberShipType).SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {

        //    };
        //    //return new List<Customer>
        //    //{
        //    //    new Customer {id=1,CustomerName="Harsha" },
        //    //    new Customer {id=2,CustomerName="Rupesh" }

        //    //};
        //}
    }

}