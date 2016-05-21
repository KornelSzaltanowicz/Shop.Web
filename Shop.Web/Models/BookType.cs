using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    //Nośnik: Druk, eBook, PDF, EPUB, MOBI
    public class BookType
    {
        public int BookTypeId { get; set; }
        public string Name { get; set; }
    }
}