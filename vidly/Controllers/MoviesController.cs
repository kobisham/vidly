using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name= "Shrek!"};
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("ID: " + id);
        }

        // /Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year}/{month:range(1,12)}")]
        public ActionResult ByReleaseYear(int year,int month)
        {
            return Content(year + "/" + month);

        }
    }
}