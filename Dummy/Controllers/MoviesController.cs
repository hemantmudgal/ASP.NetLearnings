using Dummy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Dummy.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Movies/GetMovies")]
        public ActionResult GetMovies()
        {

            var getMovies = _context.Movies.Include(c => c.Genre).ToList();

            return View(getMovies);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return Content("HttpNotFound");

            return View(movie);
        }
    }
}
