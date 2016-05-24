using Shop.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Shop.Web.Controllers
{
    public class HomeController : Controller
    {

        private ShopContext db;
        private int currentDate = DateTime.Today.DayOfYear;

        public HomeController(ShopContext context)
        {
            this.db = context;
        }

        public ActionResult Index()
        {
            var books = db.Books.Take(20);
            return View(books);
        }


        public ActionResult GetBooksByType(int bookType)
        {
            var booksByType = db.Books.Where(b => b.Type.Value == bookType).OrderByDescending(b => b.Title).ToList();

            
            if (Request.IsAjaxRequest())
            {
                Thread.Sleep(500);
                return PartialView("_BooksByType", booksByType);
                
            }
            else
            {
                return View(booksByType);
            }
        }

        public ActionResult GetNewestBooks()
        {
            
            var newestBooks = db.Books.Where(b => b.PublicDate.DayOfYear <= currentDate && b.PublicDate.DayOfYear >= currentDate - 14).ToList();

            return PartialView("_BooksByType", newestBooks);

        }

        public ActionResult GetPreviewsBooks()
        {
            var previewsBooks = db.Books.Where(b => b.PublicDate.DayOfYear >= currentDate && b.PublicDate.DayOfYear <= currentDate + 14).ToList();

            return PartialView("_BooksByType", previewsBooks);

        }

        public ActionResult GetOpportunityBooks()
        {

            var opportunityBooks = db.Books.Where(b => b.Opportunity > 0).ToList();

            return PartialView("_BooksByType", opportunityBooks);

        }

        //public ActionResult SearchBook(string searchTxt, )

    }
}