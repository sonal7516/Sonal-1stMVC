using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sonal_1stMVC.Models;


namespace Sonal_1stMVC.Controllers
{
    public class CustomerController : Controller

    {
        private ApplicationDbContext DbContext;
           public CustomerController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = DbContext.Locations.ToList();

            return View(locations);
        }
        public IActionResult CustomerList()
        {
            List<Customer> customers = DbContext.Customers.ToList();

            return View(customers);
        }

    }
}
