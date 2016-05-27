using Shop.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
    public class BookController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult All()
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