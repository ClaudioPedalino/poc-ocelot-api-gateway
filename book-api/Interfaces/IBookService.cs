using book_api.Models;
using shared;
using System.Collections.Generic;

namespace book_api.Service
{
    public interface IBookService
    {
        IEnumerable<BookQueryResult> GetAll();

        Result Create(BookCommand request);
    }
}