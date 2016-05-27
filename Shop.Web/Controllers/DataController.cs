using Shop.Web.DAL;
using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class DataController : Controller
    {
        private ShopContext db = new ShopContext();
        private int currentDayOfYear = DateTime.Today.DayOfYear;
        private int currentYear = DateTime.Today.Year;
        private List<Book> previewsBookList = new List<Book>();
        private List<Book> newestBookList = new List<Book>();

        // GET: Data/GetAllBooks
        public JsonResult GetAllBooks()
        {
            return Json(db.Books.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBookByType(int bookType)
        {
            var booksByType =  db.Books.Where(b => b.Type.Value == bookType).ToList();

            return Json(booksByType, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNewestBooks()
        {

            var books = db.Books.ToList();
            books.ForEach(b => AddToNewest(b));
            
            return Json(newestBookList, JsonRequestBehavior.AllowGet);

        }

        private bool IsNewest(Book book)
        {
            return (book.PublicDate.DayOfYear <= currentDayOfYear && book.PublicDate.DayOfYear >= currentDayOfYear - 14 && book.PublicDate.Year == currentYear) || false;
        }

        private void AddToNewest(Book book)
        {
            if (IsNewest(book))
            {
                newestBookList.Add(book);
            }
        }

        public JsonResult GetPreviewsBooks()
        {
            var books = db.Books.ToList();

            books.ForEach(b => AddToPreview(b));
            
            return Json(previewsBookList, JsonRequestBehavior.AllowGet);

        }

        private bool IsPreview(Book book)
        {
            return (book.PublicDate.DayOfYear >= currentDayOfYear && book.PublicDate.DayOfYear <= currentDayOfYear + 14 && book.PublicDate.Year == currentYear) || false;
        }

        private void AddToPreview(Book book)
        {
            if (IsPreview(book))
            {
                previewsBookList.Add(book);
            }
        }

        public JsonResult GetOpportunityBooks()
        {

            var opportunityBooks = db.Books.Where(b => b.Opportunity > 0).ToList();
            
            return Json(opportunityBooks, JsonRequestBehavior.AllowGet);

        }
    }
}