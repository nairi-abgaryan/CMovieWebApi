using System.Collections.Generic;
using CMovieWebApi.Models;

namespace CMovieWebApi.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}