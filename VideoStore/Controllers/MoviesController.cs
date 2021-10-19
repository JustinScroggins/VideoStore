using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;

namespace VideoStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var Movie = new Movie() { Id = 1, Name = "Shrek" };
            return View(Movie);
        }
    }
}