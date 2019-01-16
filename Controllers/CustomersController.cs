using System.Collections.Generic;
using System.Web.Mvc;
using CMovieWebApi.Models;

namespace CMovieWebApi.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers")]
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer() {Name = "John"},
                new Customer() {Name = "Angelina "}
            };
            
            return View();
        }
    }
}