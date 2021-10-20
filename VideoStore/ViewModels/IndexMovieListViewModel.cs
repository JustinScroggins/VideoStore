using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoStore.Models;

namespace VideoStore.ViewModels
{
    public class IndexMovieListViewModel
    {
        public List<Movie> Movies { get; set; }
    }
}