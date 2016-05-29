using Shop.Web.Models;
using System.Collections.Generic;

namespace Shop.Web.Infrastructure
{
    public interface IBookChecker
    {
        void AddToPreview(Book book);
        void AddToNewest(Book book);
    }
}
