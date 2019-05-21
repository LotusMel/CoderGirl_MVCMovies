using Microsoft.AspNetCore.Mvc;
using CoderGirl_MVCMovies.Data;

namespace CoderGirl_MVCMovies.Controllers
{

    public class DirectorController : Controller
    {

        private IMovieRespository movieRespository = RepositoryFactory.GetMovieRepository();

        public IActionResult Index()
        {
            return View();
        }
    }
}