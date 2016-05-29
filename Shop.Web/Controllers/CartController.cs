using Shop.Web.DAL;
using Shop.Web.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class CartController : Controller
    {
        private ShopContext db;

        public CartController(ShopContext context)
        {
            this.db = context;
        }

        // GET: Cart
        public ActionResult AddToCart()
        {
            var coverTypes = db.Covers.ToList();
            var publishers = db.Publishers.ToList();
            var publicationDates = db.PublicationDate.ToList();
            var dataCarriers = db.DataCarrier.ToList();

            IEnumerable<SelectListItem> coverTypesItem = coverTypes.Select(c => new SelectListItem { Text = c.Type.ToString(), Value = c.Type.ToString() });
            IEnumerable<SelectListItem> publishersItem = publishers.Select(p => new SelectListItem { Text = p.Name, Value = p.Name });
            IEnumerable<SelectListItem> publicationDatesItem = publicationDates.Select(pd => new SelectListItem { Text = pd.Date.ToString("yyyy"), Value = pd.Date.ToShortDateString() });
            IEnumerable<SelectListItem> dataCarriersItem = dataCarriers.Select(d => new SelectListItem { Text = d.Type.ToString(), Value = d.DataCarrierId.ToString() });

            CartViewModel viewModel = new CartViewModel { Covers = coverTypesItem, Publishers = publishersItem, PublicationDates = publicationDatesItem, DataCarriers = dataCarriersItem };

            return PartialView("_CartData", viewModel);

        }

    }
}