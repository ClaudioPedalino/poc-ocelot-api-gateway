using book_api.Entities;
using book_api.Models;
using shared;
using shared.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace book_api.Service
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;

        public BookService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<BookQueryResult> GetAll()
        {
            var result = _context.Books.ToList();

            return result.Select(item => new BookQueryResult()
            {
                Id = item.Id,
                CreateAt = item.CreateAt,
                Title = item.Title,
                Author = item.Author,
                Genre = item.Genre,
                Price = item.Price,
                TotalPages = item.TotalPages,
            });
        }

        public Result Create(BookCommand request)
        {
            var entity = new Book();
            entity.Title = request.Title;
            entity.Author = request.Author;
            entity.Genre = request.Genre;
            entity.Price = request.Price;
            entity.TotalPages = request.TotalPages;
            entity.CreateAt = DateTime.UtcNow.AddHours(-3);
            entity.CreateBy = "pepe";
            entity.DeleteAt = default;
            entity.DeleteBy = default;
            entity.IsDelete = false;

            _context.Books.Add(entity);
            _context.SaveChanges();
            return Result.Succes($"{nameof(Book)} created with id: {entity.Id}");
        }
    }
}