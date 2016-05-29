using Shop.Web.DAL;
using Shop.Web.Infrastructure;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class DataController : Controller
    {
        private readonly ShopContext _db;
        private readonly BookManager _bookManager;

        public DataController(ShopContext context, BookManager bookManager)
        {
            this._db = context;
            this._bookManager = bookManager;
        }
        
        public JsonResult GetAllBooks()
        {
            //opóźniam wątek dla widoczności przeładowania
            Thread.Sleep(800);
            return Json(_db.Books.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBookByType(int bookType)
        {
            
            var booksByType = _db.Books.Where(b => b.Type.Value == bookType).ToList();
            Thread.Sleep(450);
            return Json(booksByType, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNewestBooks()
        {
            
            var books = _db.Books.ToList();
            books.ForEach(b => _bookManager.AddToNewest(b));
            Thread.Sleep(450);
            return Json(_bookManager.newestBookList, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetPreviewsBooks()
        {

            var books = _db.Books.ToList();

            books.ForEach(b => _bookManager.AddToPreview(b));
            Thread.Sleep(450);
            return Json(_bookManager.previewsBookList, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetOpportunityBooks()
        {

            var opportunityBooks = _db.Books.Where(b => b.Opportunity > 0).ToList();
            Thread.Sleep(450);
            return Json(opportunityBooks, JsonRequestBehavior.AllowGet);

        }
    }
}