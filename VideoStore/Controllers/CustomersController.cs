using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;
using VideoStore.ViewModels;

namespace VideoStore.Controllers
{
    public class CustomersController : Controller
    {
        Customer personOne = new Customer() { Name = "John Smith", Id = 1 };
        Customer personTwo = new Customer() { Name = "Mary Williams", Id = 2 };

        [Route("customers")]
        public ActionResult Index()
        {
            var viewModel = new CustomerListViewModel
            {
                Customers = new List<Customer> { personOne, personTwo }
            };

            return View(viewModel);
        }
    }
}