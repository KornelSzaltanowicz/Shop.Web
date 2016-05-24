using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime PublicDate { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Autor")]
        public virtual Author Author { get; set; }
        [Display(Name = "Wydawnictwo")]
        public virtual Publisher Publisher { get; set; }
        public BookType Type { get; set; }
        // 1 - super okazja 
        public int Opportunity { get; set; }
    }
}