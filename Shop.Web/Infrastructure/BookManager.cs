using System;
using System.Collections.Generic;
using Shop.Web.Models;

namespace Shop.Web.Infrastructure
{
    public class BookManager : IBookChecker
    {
        public int currentDayOfYear = DateTime.Today.DayOfYear;
        public int currentYear = DateTime.Today.Year;

        public List<Book> previewsBookList = new List<Book>();
        public List<Book> newestBookList = new List<Book>();
        private bool IsNewest(Book book)
        {
            return (book.PublicDate.DayOfYear <= currentDayOfYear && book.PublicDate.DayOfYear >= currentDayOfYear - 14 && book.PublicDate.Year == currentYear) || false;
        }

        public void AddToNewest(Book book)
        {
            if (IsNewest(book))
            {
                newestBookList.Add(book);
            }
        }

        private bool IsPreview(Book book)
        {
            return (book.PublicDate.DayOfYear >= currentDayOfYear && book.PublicDate.DayOfYear <= currentDayOfYear + 14 && book.PublicDate.Year == currentYear) || false;
        }

        public void AddToPreview(Book book)
        {
            if (IsPreview(book))
            {
                previewsBookList.Add(book);
            }
        }
        

    }
}