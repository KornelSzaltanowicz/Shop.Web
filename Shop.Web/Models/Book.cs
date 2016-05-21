using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublicDate { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public int Type { get; set; }
    }
}