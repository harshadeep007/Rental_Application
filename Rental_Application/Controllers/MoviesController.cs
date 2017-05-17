using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental_Application.Models;

namespace Rental_Application.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {id=1,MovieName="Fast & Furious 8" },
                new Movie {id=2,MovieName="Need For Speed" }
            };
        }
    }
}