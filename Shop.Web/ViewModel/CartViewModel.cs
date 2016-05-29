using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Shop.Web.Models;

namespace Shop.Web.ViewModel
{
    public class CartViewModel
    {

        [Required(ErrorMessage = "Wybierz okładkę")]
        public IEnumerable<SelectListItem> Covers { get; set; }
        [Required(ErrorMessage = "Wybierz Wydawnictwo")]
        public IEnumerable<SelectListItem> Publishers { get; set; }
        [Required(ErrorMessage = "Wybierz Datę publikacji")]
        public IEnumerable<SelectListItem> PublicationDates { get; set; }
        [Required(ErrorMessage = "Wybierz Nośnik")]
        public IEnumerable<SelectListItem> DataCarriers { get; set; }

    }
}