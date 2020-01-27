using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoToMovies.Models;

namespace GoToMovies.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}