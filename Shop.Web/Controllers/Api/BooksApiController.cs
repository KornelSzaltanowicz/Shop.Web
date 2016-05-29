using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Shop.Web.DAL;
using Shop.Web.Models;

namespace Shop.Web.Controllers.Api
{
    public class BooksApiController : ApiController
    {
        private ShopContext db = new ShopContext();

        // GET: api/BooksApi
        public IQueryable<Book> GetBooks()
        {
            return db.Books;
        }

        // GET: api/BooksApi/1
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> GetBookByType(int bookType)
        {
            var books = await db.Books.Select(b => b).Where(b => b.Type.Value == bookType).ToListAsync();
            if (books == null)
            {
                return NotFound();
            }

            return Ok(books);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookExists(int id)
        {
            return db.Books.Count(e => e.BookId == id) > 0;
        }
    }
}