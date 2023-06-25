using Dummy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dummy.Controllers
{
    public class MoviesController : Controller
    {
        [Route("Movies/GetMovies")]
        public ActionResult GetMovies()
        {

            var getMovies = GetMovie();

            return View(getMovies);
        }

        public IEnumerable<Movies> GetMovie()
        {
            return new List<Movies>
            {
                new Movies(){Id=1,Name="Book1"},
                new Movies(){Id=2,Name="Book2"}
            };
        }

        public ActionResult Detail(int id)
        {
            var movie = GetMovie().SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return Content("HttpNotFound");

            return View(movie);
        }
    }
}
