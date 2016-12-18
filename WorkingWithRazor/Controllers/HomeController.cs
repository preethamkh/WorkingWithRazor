using System;
using System.Web.Mvc;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var names = new[] {"Apple", "Orange", "Pear"};
            return View(names);
        }

        public ActionResult List()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }

        [ChildActionOnly]
        public ActionResult TimeWithParam(DateTime time)
        {
            return PartialView(time);
        }
    }
}