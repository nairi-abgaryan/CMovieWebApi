using System.Collections.Generic;
using System.Web.Mvc;
using CMovieWebApi.Models;
using CMovieWebApi.ViewModels;

namespace CMovieWebApi.Controllers
{
    public class MoviesController : Controller
    {
        // GET all movies
        [Route("movies")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("random/movies")]
        public ActionResult Random()
        {
            var movie = new Movie(){Id = 1, Name = "Avengers"};
            
            var customers = new List<Customer>()
            {
                new Customer() {Id = 1, Name = "Customer 1"},
                new Customer() {Id = 2, Name = "Customer 2"}
            };

            var randomMovie = new RandomMovieViewModel(){Movie = movie, Customers = customers};
            
            return View(randomMovie);
        }
    }
}