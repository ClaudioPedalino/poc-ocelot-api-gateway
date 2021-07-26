using book_api.Models;
using book_api.Service;
using Microsoft.AspNetCore.Mvc;
using shared;
using System.Collections.Generic;

namespace book_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookQueryResult>> GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpPost]
        public ActionResult<Result> Create(BookCommand book)
        {
            var response = _bookService.Create(book);
            return response.HasError
                ? BadRequest(response)
                : Ok(response);
        }
    }
}