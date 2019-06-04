using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoderGirl_MVCMovies.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoderGirl_MVCMovies.Controllers
{
    public class MovieController : Controller
    {
        public static IMovieRepository movieRepository = RepositoryFactory.GetMovieRepository();

        public IActionResult Index()
        {
            ViewBag.Movies = movieRepository;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            movieRepository.Save(movie);
            return RedirectToAction(actionName: nameof(Index));
        }
    }
}