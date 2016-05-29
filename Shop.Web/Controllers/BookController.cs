using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Type(int bookType)
        {
            return View();

        }

        public ViewResult Newest()
        {

            return View();

        }

        public ViewResult Previews()
        {
            return View();

        }

        public ViewResult Opportunity()
        {

            return View();

        }
    }
}