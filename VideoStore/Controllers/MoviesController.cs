using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;
using VideoStore.ViewModels;

namespace VideoStore.Controllers
{
    public class MoviesController : Controller
    {
        Movie movie = new Movie() { Name = "Shrek!", Id = 1 };
        Movie movieTwo = new Movie() { Name = "Finding Nemo", Id = 2 };
        public ViewResult Index()
        {
            var viewModel = new IndexMovieListViewModel
            {
                Movies = new List<Movie> { movie, movieTwo }
            };
            
            return View(viewModel);
        }
        
        // GET: Movies/Random
        public ViewResult Random()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}