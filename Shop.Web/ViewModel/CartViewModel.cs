using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.ViewModel
{
    public class CartViewModel
    {
        public IEnumerable<SelectListItem> Covers { get; set; }
        public IEnumerable<SelectListItem> Publishers { get; set; }
        public IEnumerable<SelectListItem> PublicationDates { get; set; }
        //Nosnik
        public IEnumerable<SelectListItem> DataCarriers { get; set; }

    }
}